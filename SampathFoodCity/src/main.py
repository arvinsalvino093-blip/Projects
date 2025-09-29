import pandas as pd
import matplotlib.pyplot as plt
from datetime import datetime
from src.data_structures.linked_list import LinkedList
from src.data_structures.stack import Stack
from src.data_structures.queue import Queue
from src.managers.product_manager import ProductManager
from src.managers.branch_manager import BranchManager
from src.analysis.sales_analysis import MonthlySalesAnalysis
from src.analysis.price_analysis import PriceAnalysis
from src.analysis.weekly_sales_analysis import WeeklySalesAnalysis
from src.analysis.product_preference import ProductPreferenceAnalysis
from src.analysis.distribution_analysis import DistributionAnalysis
from src.interfaces.analysis import IAnalysis
from abc import ABC, abstractmethod
import uuid

# Command Pattern
class Command(ABC):
    @abstractmethod
    def execute(self):
        pass

    @abstractmethod
    def undo(self):
        pass

class AddProductCommand(Command):
    def __init__(self, manager: ProductManager, product_id: str, name: str, category: str, price: float):
        self.manager = manager
        self.product_id = product_id
        self.name = name
        self.category = category
        self.price = price

    def execute(self):
        self.manager.add_product(self.product_id, self.name, self.category, self.price)

    def undo(self):
        data = self.manager.load_data()
        data = data[data['ProductID'] != self.product_id]
        self.manager.save_data(data)

# Factory Method Pattern
class AnalysisFactory:
    @staticmethod
    def create_analysis(analysis_type: str, file_path: str) -> IAnalysis:
        if analysis_type == "monthly":
            return MonthlySalesAnalysis(file_path)
        elif analysis_type == "price":
            return PriceAnalysis(file_path)
        elif analysis_type == "weekly":
            return WeeklySalesAnalysis(file_path)
        elif analysis_type == "preference":
            return ProductPreferenceAnalysis(file_path)
        elif analysis_type == "distribution":
            return DistributionAnalysis(file_path)
        else:
            raise ValueError("Unknown analysis type")

# Singleton Pattern for Main Menu
class MainMenu:
    _instance = None

    def __new__(cls, *args, **kwargs):
        if cls._instance is None:
            cls._instance = super(MainMenu, cls).__new__(cls)
        return cls._instance

    def __init__(self, file_path: str):
        if not hasattr(self, 'initialized'):
            self.file_path = file_path
            self.product_manager = ProductManager(file_path)
            self.branch_managers = {branch: BranchManager(file_path, branch) for branch in 
                ['Jaffna', 'Colombo', 'Kandy', 'Galle', 'Matara', 'Negombo', 
                 'Kurunegala', 'Anuradhapura', 'Polonnaruwa', 'Batticaloa', 'Trincomalee', 'Ratnapura']}
            self.action_history = LinkedList()
            self.undo_stack = Stack()
            self.analysis_queue = Queue()
            self.initialized = True

    def display_menu(self):
        """Display the main menu and handle user input."""
        while True:
            print("\n=== Sampath Food City Sales Analysis System ===")
            print("1. Manage Products")
            print("2. Manage Branches")
            print("3. Monthly Sales Analysis")
            print("4. Price Analysis")
            print("5. Weekly Sales Analysis")
            print("6. Product Preference Analysis")
            print("7. Distribution Analysis")
            print("8. Exit")
            choice = input("Enter your choice: ")
            self.action_history.append(f"Selected option {choice} at {datetime.now()}")
            
            if choice == "1":
                self.manage_products()
            elif choice == "2":
                self.manage_branches()
            elif choice == "3":
                self.run_analysis("monthly")
            elif choice == "4":
                self.run_analysis("price")
            elif choice == "5":
                self.run_analysis("weekly")
            elif choice == "6":
                self.run_analysis("preference")
            elif choice == "7":
                self.run_analysis("distribution")
            elif choice == "8":
                print("Exiting...")
                break
            else:
                print("Invalid choice. Try again.")

    def manage_products(self):
        """Manage product-related operations."""
        while True:
            print("\n=== Manage Products ===")
            print("1. Add Product")
            print("2. Update Product")
            print("3. Back to Main Menu")
            choice = input("Enter your choice: ")
            self.action_history.append(f"Product menu option {choice} at {datetime.now()}")
            
            if choice == "1":
                product_id = input("Enter Product ID: ")
                name = input("Enter Product Name: ")
                category = input("Enter Category: ")
                price = float(input("Enter Unit Price: "))
                command = AddProductCommand(self.product_manager, product_id, name, category, price)
                command.execute()
                self.undo_stack.push(command)
            elif choice == "2":
                product_id = input("Enter Product ID to update: ")
                name = input("Enter new Product Name: ")
                category = input("Enter new Category: ")
                price = float(input("Enter new Unit Price: "))
                self.product_manager.update_product(product_id, name, category, price)
            elif choice == "3":
                break
            else:
                print("Invalid choice. Try again.")

    def manage_branches(self):
        """Manage branch-related operations."""
        print("\nAvailable Branches:", ", ".join(self.branch_managers.keys()))
        branch = input("Enter Branch Name: ")
        if branch not in self.branch_managers:
            print("Branch not found.")
            return
        # Implement branch management similar to product management if needed

    def run_analysis(self, analysis_type: str):
        """Run the specified analysis."""
        analysis = AnalysisFactory.create_analysis(analysis_type, self.file_path)
        self.analysis_queue.enqueue(analysis)
        
        while not self.analysis_queue.is_empty():
            current_analysis = self.analysis_queue.dequeue()
            if analysis_type == "monthly":
                branch = input("Enter Branch Name: ")
                start_month = input("Enter Start Month (YYYY-MM): ")
                end_month = input("Enter End Month (YYYY-MM): ")
                data = current_analysis.analyze(branch=branch, month_range=(start_month, end_month))
                current_analysis.visualize(data)
            elif analysis_type == "price":
                product_id = input("Enter Product ID: ")
                start_month = input("Enter Start Month (YYYY-MM): ")
                end_month = input("Enter End Month (YYYY-MM): ")
                data = current_analysis.analyze(product_id=product_id, month_range=(start_month, end_month))
                current_analysis.visualize(data)
            elif analysis_type == "weekly":
                month = input("Enter Month (YYYY-MM): ")
                data = current_analysis.analyze(month=month)
                current_analysis.visualize(data)
            elif analysis_type == "preference":
                branch = input("Enter Branch Name: ")
                start_month = input("Enter Start Month (YYYY-MM): ")
                end_month = input("Enter End Month (YYYY-MM): ")
                data = current_analysis.analyze(branch=branch, month_range=(start_month, end_month))
                current_analysis.visualize(data)
            elif analysis_type == "distribution":
                branch = input("Enter Branch Name: ")
                start_month = input("Enter Start Month (YYYY-MM): ")
                end_month = input("Enter End Month (YYYY-MM): ")
                data = current_analysis.analyze(branch=branch, month_range=(start_month, end_month))
                current_analysis.visualize(data)

if __name__ == "__main__":
    file_path = "C:/Users/A.S.Asbury/PycharmProjects/SampathFoodCity/data/sampath_food_city.xlsx"
    menu = MainMenu(file_path)
    menu.display_menu()
