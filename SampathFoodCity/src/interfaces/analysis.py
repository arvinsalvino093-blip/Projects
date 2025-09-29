from abc import ABC, abstractmethod

class IAnalysis(ABC):
    @abstractmethod
    def analyze(self, **kwargs) -> dict:
        pass

    @abstractmethod
    def visualize(self, data: dict):
        pass