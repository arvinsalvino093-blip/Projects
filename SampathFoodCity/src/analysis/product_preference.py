import pandas as pd
import matplotlib.pyplot as plt
from src.analysis.sales_analysis import AnalysisBase

class ProductPreferenceAnalysis(AnalysisBase):
    def analyze(self, branch: str, month_range: tuple) -> dict:
        """Analyze product preferences for a specific branch."""
        start_month, end_month = month_range
        branch_data = self.load_all_branch_data().get(branch, pd.DataFrame())
        if branch_data.empty:
            return {"error": "Branch data not found"}
        
        branch_data['Date'] = pd.to_datetime(branch_data['Date'])
        branch_data['Month'] = branch_data['Date'].dt.to_period('M')
        filtered_data = branch_data[
            (branch_data['Month'] >= start_month) & (branch_data['Month'] <= end_month)
        ]
        product_counts = filtered_data.groupby('ProductName')['QuantitySold'].sum()
        return {
            "branch": branch,
            "month_range": month_range,
            "table": product_counts.reset_index()[['ProductName', 'QuantitySold']],
            "graph_data": product_counts.values,
            "labels": product_counts.index
        }

    def visualize(self, data: dict):
        """Visualize product preference data."""
        if "error" in data:
            print(data["error"])
            return
        plt.figure(figsize=(10, 6))
        plt.bar(data["labels"], data["graph_data"])
        plt.title(f"Product Preference for {data['branch']} ({data['month_range'][0]} to {data['month_range'][1]})")
        plt.xlabel("Product Name")
        plt.ylabel("Total Quantity Sold")
        plt.grid(True)
        plt.xticks(rotation=45)
        plt.show()
        print("\nProduct Preference Table:")
        print(data["table"].to_string(index=False))