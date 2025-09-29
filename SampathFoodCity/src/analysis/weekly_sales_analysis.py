import pandas as pd
import matplotlib.pyplot as plt
from src.analysis.sales_analysis import AnalysisBase

class WeeklySalesAnalysis(AnalysisBase):
    def analyze(self, month: str) -> dict:
        """Analyze weekly sales for the entire network."""
        all_branch_data = self.load_all_branch_data()
        combined_data = pd.concat(all_branch_data.values())
        combined_data['Date'] = pd.to_datetime(combined_data['Date'])
        combined_data['Week'] = combined_data['Date'].dt.isocalendar().week
        combined_data['Month'] = combined_data['Date'].dt.to_period('M')
        filtered_data = combined_data[combined_data['Month'] == month]
        weekly_sales = filtered_data.groupby('Week').agg({'QuantitySold': 'sum', 'UnitPrice': 'sum'})
        weekly_sales['TotalSales'] = weekly_sales['QuantitySold'] * weekly_sales['UnitPrice']
        return {
            "month": month,
            "table": weekly_sales.reset_index()[['Week', 'TotalSales']],
            "graph_data": weekly_sales['TotalSales'].values,
            "labels": weekly_sales.index.astype(str)
        }

    def visualize(self, data: dict):
        """Visualize weekly sales data."""
        plt.figure(figsize=(10, 6))
        plt.plot(data["labels"], data["graph_data"], marker='o')
        plt.title(f"Weekly Sales Analysis for {data['month']}")
        plt.xlabel("Week Number")
        plt.ylabel("Total Sales (LKR)")
        plt.grid(True)
        plt.xticks(rotation=45)
        plt.show()
        print("\nWeekly Sales Table:")
        print(data["table"].to_string(index=False))