import os
from typing import Dict, List, Optional
from dataclasses import dataclass
from config_manager import ConfigManager
from auth_manager import AuthManager
from data_loader import DataLoader
from analysis_factory import AnalysisFactory
import logging

# Clean Code: Configure logging with a consistent format for debugging and monitoring
logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s')

# Data Structure: Dataclass to encapsulate menu option data (name and action)
# Clean Code: Meaningful name and minimal boilerplate with dataclass
@dataclass
class MenuOption:
    """Represents a menu option with a name and associated action."""
    name: str
    action: callable

# OOP: Encapsulation of menu display and selection logic in a single class
# SOLID (SRP): Menu class has a single responsibility of handling menu interactions
# Design Pattern: Command pattern, as MenuOption encapsulates actions
class Menu:
    """Manages menu display and selection logic."""
    def __init__(self, title: str, options: List[MenuOption]):
        # Data Structure: List to store menu options in order
        self.title = title
        self.options = options

    # Clean Code: Small, focused method with clear name and type hints
    def display(self) -> Optional[MenuOption]:
        """Display the menu and return the selected option."""
        # Clean Code: Consistent formatting and clear output
        print(f"\n=== {self.title} ===")
        for i, option in enumerate(self.options, 1):
            print(f"{i}. {option.name}")
        while True:
            try:
                choice = int(input(f"Select a number (1-{len(self.options)}): ")) - 1
                if 0 <= choice < len(self.options):
                    return self.options[choice]
                # Clean Code: Proper error handling with user feedback and logging
                logging.warning(f"Invalid choice in {self.title}: {choice + 1}")
                print(f"Invalid choice. Please select a number between 1 and {len(self.options)}.")
            except ValueError:
                logging.warning(f"Non-numeric input in {self.title}")
                print("Invalid input. Please enter a number.")
        return None

# OOP: Encapsulation of the entire application logic
# SOLID (SRP): Responsible for orchestrating subsystems, not implementing their logic
# Design Pattern: Facade pattern, providing a simplified interface to subsystems
class SalesAnalysisSystem:
    """Main system class for Sampath Food City Sales Analysis."""
    def __init__(self):
        # OOP: Composition of subsystem objects (ConfigManager, AuthManager, etc.)
        # SOLID (DIP): Depends on abstractions (e.g., ConfigManager, AuthManager)
        self.config_manager = ConfigManager()
        self.auth_manager = AuthManager()
        self.data_loader = DataLoader(self.config_manager.get_config('data_file'))
        self.output_dir = self.config_manager.get_config('output_dir')
        # Data Structure: Dictionary to store loaded data (sheets as DataFrames)
        self.data = self.data_loader.get_data()
        # Data Structure: Lists for menu options, ensuring ordered display
        self.branches = sorted(self.data['Transactions']['Branch'].unique())
        self.products = sorted(self.data['Products']['Product_Name'].unique())
        self.months = ['January', 'February', 'March', 'April', 'May', 'June',
                       'July', 'August', 'September', 'October', 'November', 'December']
        self.years = ['2023', '2024', '2025']

    # Clean Code: Small, focused method with clear name and error handling
    def validate_month_range(self, start_month: str, end_month: str) -> bool:
        """Validate if start month is before or equal to end month."""
        start_idx = self.months.index(start_month)
        end_idx = self.months.index(end_month)
        if start_idx > end_idx:
            logging.error(f"Invalid month range: {start_month} to {end_month}")
            print("Error: Start month must be before or equal to end month.")
            return False
        return True

    # SOLID (OCP): Easily extensible to new analysis types via AnalysisFactory
    # Clean Code: Single method to handle analysis execution with clear parameters
    def run_analysis(self, analysis_type: str, params: Dict) -> None:
        """Execute analysis and display results."""
        try:
            # Design Pattern: Factory pattern via AnalysisFactory to get strategy
            # SOLID (LSP): Any AnalysisStrategy subclass can be used here
            strategy = AnalysisFactory.get_analysis_strategy(analysis_type)
            results = strategy.analyze(self.data, **params)
            print("\n=== Analysis Results ===")
            print(results.to_string(index=False))
            strategy.visualize(self.output_dir)
        except Exception as e:
            # Clean Code: Robust error handling with logging
            logging.error(f"Error during analysis: {e}")
            print(f"Error: {e}")

    # Design Pattern: Command pattern, as MenuOptions encapsulate actions
    # SOLID (OCP): New menu options can be added without modifying this method
    def main_menu(self) -> Menu:
        """Create and return the main menu."""
        return Menu("Main Menu", [
            MenuOption("Monthly Sales Analysis (Per Branch)", lambda: self.run_analysis('monthly_sales', {
                'branch': Menu("Select Branch", [MenuOption(b, lambda: b) for b in self.branches]).display().name,
                'start_month': Menu("Select Start Month", [MenuOption(m, lambda: m) for m in self.months]).display().name,
                'end_month': Menu("Select End Month", [MenuOption(m, lambda: m) for m in self.months]).display().name,
                'year': int(Menu("Select Year", [MenuOption(y, lambda: y) for y in self.years]).display().name)
            }) if self.validate_month_range(
                Menu("Select Start Month", [MenuOption(m, lambda: m) for m in self.months]).display().name,
                Menu("Select End Month", [MenuOption(m, lambda: m) for m in self.months]).display().name
            ) else None),
            MenuOption("Product Price Analysis", lambda: self.run_analysis('product_price', {
                'product_name': Menu("Select Product", [MenuOption(p, lambda: p) for p in self.products]).display().name,
                'start_month': Menu("Select Start Month", [MenuOption(m, lambda: m) for m in self.months]).display().name,
                'end_month': Menu("Select End Month", [MenuOption(m, lambda: m) for m in self.months]).display().name,
                'year': int(Menu("Select Year", [MenuOption(y, lambda: y) for y in self.years]).display().name)
            }) if self.validate_month_range(
                Menu("Select Start Month", [MenuOption(m, lambda: m) for m in self.months]).display().name,
                Menu("Select End Month", [MenuOption(m, lambda: m) for m in self.months]).display().name
            ) else None),
            MenuOption("Weekly Sales Analysis (Entire Network)", lambda: self.run_analysis('weekly_sales', {
                'month': Menu("Select Month", [MenuOption(m, lambda: m) for m in self.months]).display().name,
                'year': int(Menu("Select Year", [MenuOption(y, lambda: y) for y in self.years]).display().name)
            })),
            MenuOption("Product Preference Analysis (Per Branch)", lambda: self.run_analysis('product_preference', {
                'branch': Menu("Select Branch", [MenuOption(b, lambda: b) for b in self.branches]).display().name,
                'start_month': Menu("Select Start Month", [MenuOption(m, lambda: m) for m in self.months]).display().name,
                'end_month': Menu("Select End Month", [MenuOption(m, lambda: m) for m in self.months]).display().name,
                'year': int(Menu("Select Year", [MenuOption(y, lambda: y) for y in self.years]).display().name)
            }) if self.validate_month_range(
                Menu("Select Start Month", [MenuOption(m, lambda: m) for m in self.months]).display().name,
                Menu("Select End Month", [MenuOption(m, lambda: m) for m in self.months]).display().name
            ) else None),
            MenuOption("Distribution vs Sales Analysis", lambda: self.run_analysis('distribution_vs_sales', {
                'branch': Menu("Select Branch", [MenuOption(b, lambda: b) for b in self.branches]).display().name,
                'start_month': Menu("Select Start Month", [MenuOption(m, lambda: m) for m in self.months]).display().name,
                'end_month': Menu("Select End Month", [MenuOption(m, lambda: m) for m in self.months]).display().name,
                'year': int(Menu("Select Year", [MenuOption(y, lambda: y) for y in self.years]).display().name)
            }) if self.validate_month_range(
                Menu("Select Start Month", [MenuOption(m, lambda: m) for m in self.months]).display().name,
                Menu("Select End Month", [MenuOption(m, lambda: m) for m in self.months]).display().name
            ) else None),
            MenuOption("Add New User (Admin Only)", lambda: self.auth_manager.add_user(
                input("Enter new username: "), input("Enter new password: ")
            ) if self.current_user == 'admin' else print("Access denied. Only admin can add new users.")),
            MenuOption("Logout", lambda: False),
            MenuOption("Exit", lambda: False)
        ])

    # Clean Code: Main entry point with clear flow and error handling
    def run(self):
        """Run the sales analysis system."""
        while True:
            print("\n=== Sampath Food City Sales Analysis System ===")
            username = input("Enter username (or 'exit' to quit): ")
            if username.lower() == 'exit':
                logging.info("User exited the system.")
                break
            password = input("Enter password: ")

            # OOP: Using AuthManager for authentication
            if self.auth_manager.login(username, password):
                self.current_user = username
                logging.info(f"User {username} logged in successfully.")
                while True:
                    # Design Pattern: Command pattern via MenuOption actions
                    selected_option = self.main_menu().display()
                    if selected_option.name == "Logout" or selected_option.name == "Exit":
                        logging.info(f"User {username} logged out.")
                        break
                    selected_option.action()
                    if selected_option.name == "Exit":
                        return
            else:
                print("Invalid username or password.")
                logging.warning(f"Failed login attempt for username: {username}")

if __name__ == "__main__":
    # Clean Code: Clear entry point for running the application
    SalesAnalysisSystem().run()