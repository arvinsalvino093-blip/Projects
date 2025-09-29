import pandas as pd
from src.interfaces.data_manager import IDataManager

class ProductManager(IDataManager):
    def __init__(self, file_path: str):
        self.file_path = file_path
        self.sheet_name = "Products"
        self.__data = None

    def load_data(self) -> pd.DataFrame:
        """Load product data from Excel."""
        try:
            self.__data = pd.read_excel(self.file_path, sheet_name=self.sheet_name)
            return self.__data
        except Exception as e:
            print(f"Error loading products: {e}")
            return pd.DataFrame()

    def save_data(self, data: pd.DataFrame):
        """Save product data to Excel."""
        try:
            with pd.ExcelWriter(self.file_path, mode='a', if_sheet_exists='replace') as writer:
                data.to_excel(writer, sheet_name=self.sheet_name, index=False)
            self.__data = data
        except Exception as e:
            print(f"Error saving products: {e}")

    def add_product(self, product_id: str, name: str, category: str, price: float):
        """Add a new product."""
        data = self.load_data()
        if product_id in data['ProductID'].values:
            print("Product ID already exists.")
            return
        new_product = pd.DataFrame({
            'ProductID': [product_id],
            'ProductName': [name],
            'Category': [category],
            'UnitPrice': [price]
        })
        self.save_data(pd.concat([data, new_product], ignore_index=True))

    def update_product(self, product_id: str, name: str, category: str, price: float):
        """Update an existing product."""
        data = self.load_data()
        if product_id not in data['ProductID'].values:
            print("Product ID not found.")
            return
        data.loc[data['ProductID'] == product_id, ['ProductName', 'Category', 'UnitPrice']] = [name, category, price]
        self.save_data(data)