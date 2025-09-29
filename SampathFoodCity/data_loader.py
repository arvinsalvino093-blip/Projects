import pandas as pd
import logging
import os

# Clean Code: Configure logging for consistent debugging
logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s')

# OOP: Encapsulation of data loading logic
# SOLID (SRP): Solely responsible for loading data from Excel files
class DataLoader:
    """Class to load data from an Excel file."""
    def __init__(self, file_path: str):
        # Data Structure: Dictionary to store sheet names and DataFrames
        self.file_path = file_path
        self.data = {}
        self.load_data()
        logging.info(f"DataLoader initialized with file: {file_path}")

    # Clean Code: Focused method with robust error handling
    def load_data(self):
        """Load data from the Excel file into a dictionary of DataFrames."""
        try:
            if not os.path.exists(self.file_path):
                logging.error(f"Excel file not found: {self.file_path}")
                raise FileNotFoundError(f"Excel file not found: {self.file_path}")
            # Data Structure: Dictionary to store sheet names and DataFrames
            excel_data = pd.read_excel(self.file_path, sheet_name=None)
            for sheet_name, df in excel_data.items():
                self.data[sheet_name] = df
            logging.info(f"Loaded {len(self.data)} sheets from {self.file_path}")
        except Exception as e:
            logging.error(f"Error loading data from {self.file_path}: {e}")
            raise

    # Clean Code: Simple getter method
    def get_data(self):
        """Return the loaded data."""
        return self.data

