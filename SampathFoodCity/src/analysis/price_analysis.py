import pandas as pd
import matplotlib.pyplot as plt
from src.analysis.sales_analysis import AnalysisBase

class PriceAnalysis(AnalysisBase):
    def analyze(self, product_id: str, month_range: tuple) -> dict:
        """Analyze price trends for a specific product."""
        start_month, end_month = month_range
        product_data = pd.read_excel(self.file_path, sheet_name='Products')
        if product_id not in product_data['ProductID'].values:
            return {"error": "Product ID not found"}
        
        all_branch_data = self.load_all_branch_data()
        combined_data = pd.concat(all_branch_data.values())
        combined_data['Date'] = pd.to_datetime(combined_data['Date'])
        combined_data['Month'] = combined_data['Date'].dt.to_period('M')
        filtered_data = combined_data[
            (combined_data['ProductID'] == product_id) & 
            (combined_data['Month'] >= start_month) & 
            (combined_data['Month'] <= end_month)
        ]
        price_trend = filtered_data.groupby('Month')['UnitPrice'].mean()
        return {
            "product_id": product_id,
            "month_range": month_range,
            "table": price_trend.reset_index(),
            "graph_data": price_trend.values,
            "labels": price_trend.index.astype(str)
        }

    def visualize(self, data: dict):
        """Visualize price trend data."""
        if "error" in data:
            print(data["error"])
            return
        plt.figure(figsize=(10, 6))
        plt.plot(data["labels"], data["graph_data"], marker='o')
        plt.title(f"Price Analysis for Product {data['product_id']} ({data['month_range'][0]} to {data['month_range'][1]})")
        plt.xlabel("Month")
        plt.ylabel("Unit Price (LKR)")
        plt.grid(True)
        plt.xticks(rotation=45)
        plt.show()
        print("\nPrice Analysis Table:")
        print(data["table"].to_string(index=False))