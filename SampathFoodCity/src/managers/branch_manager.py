import pandas as pd
from src.interfaces.data_manager import IDataManager

class BranchManager(IDataManager):
    def __init__(self, file_path: str, branch_name: str):
        self.file_path = file_path
        self.sheet_name = branch_name
        self.__data = None

    def load_data(self) -> pd.DataFrame:
        """Load branch sales data from Excel."""
        try:
            self.__data = pd.read_excel(self.file_path, sheet_name=self.sheet_name)
            return self.__data
        except Exception as e:
            print(f"Error loading branch data: {e}")
            return pd.DataFrame()

    def save_data(self, data: pd.DataFrame):
        """Save branch sales data to Excel."""
        try:
            with pd.ExcelWriter(self.file_path, mode='a', if_sheet_exists='replace') as writer:
                data.to_excel(writer, sheet_name=self.sheet_name, index=False)
            self.__data = data
        except Exception as e:
            print(f"Error saving branch data: {e}")