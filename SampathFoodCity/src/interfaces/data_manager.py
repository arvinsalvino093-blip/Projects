from abc import ABC, abstractmethod
import pandas as pd

class IDataManager(ABC):
    @abstractmethod
    def load_data(self) -> pd.DataFrame:
        pass

    @abstractmethod
    def save_data(self, data: pd.DataFrame):
        pass