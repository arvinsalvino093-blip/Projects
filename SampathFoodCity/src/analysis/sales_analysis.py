import pandas as pd
import matplotlib.pyplot as plt
from src.interfaces.analysis import IAnalysis

class AnalysisBase(IAnalysis):
    def __init__(self, file_path: str):
        self.file_path = file_path

    def load_all_branch_data(self) -> dict[str, pd.DataFrame]:
        """Load data from all branch sheets."""
        try:
            xl = pd.ExcelFile(self.file_path)
            branches = [sheet for sheet in xl.sheet_names if sheet != 'Products' and sheet != 'Distribution']
            return {branch: pd.read_excel(self.file_path, sheet_name=branch) for branch in branches}
        except Exception as e:
            print(f"Error loading branch data: {e}")
            return {}

class MonthlySalesAnalysis(AnalysisBase):
    def analyze(self, branch: str, month_range: tuple) -> dict:
        """Analyze monthly sales for a specific branch."""
        start_month, end_month = month_range
        branch_data = self.load_all_branch_data().get(branch, pd.DataFrame())
        if branch_data.empty:
            return {"error": "Branch data not found"}
        
        branch_data['Date'] = pd.to_datetime(branch_data['Date'])
        branch_data['Month'] = branch_data['Date'].dt.to_period('M')
        filtered_data = branch_data[
            (branch_data['Month'] >= start_month) & (branch_data['Month'] <= end_month)
        ]
        monthly_sales = filtered_data.groupby('Month').agg({'QuantitySold': 'sum', 'UnitPrice': 'sum'})
        monthly_sales['TotalSales'] = monthly_sales['QuantitySold'] * monthly_sales['UnitPrice']
        return {
            "branch": branch,
            "month_range": month_range,
            "table": monthly_sales.reset_index()[['Month', 'TotalSales']],
            "graph_data": monthly_sales['TotalSales'].values,
            "labels": monthly_sales.index.astype(str)
        }

    def visualize(self, data: dict):
        """Visualize monthly sales data."""
        if "error" in data:
            print(data["error"])
            return
        plt.figure(figsize=(10, 6))
        plt.plot(data["labels"], data["graph_data"], marker='o')
        plt.title(f"Monthly Sales for {data['branch']} ({data['month_range'][0]} to {data['month_range'][1]})")
        plt.xlabel("Month")
        plt.ylabel("Total Sales (LKR)")
        plt.grid(True)
        plt.xticks(rotation=45)
        plt.show()
        print("\nMonthly Sales Table:")
        print(data["table"].to_string(index=False))