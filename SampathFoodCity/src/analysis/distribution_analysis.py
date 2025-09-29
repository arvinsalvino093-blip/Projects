import pandas as pd
import matplotlib.pyplot as plt
from src.analysis.sales_analysis import AnalysisBase

class DistributionAnalysis(AnalysisBase):
    def analyze(self, branch: str, month_range: tuple) -> dict:
        """Analyze distribution vs sales for a specific branch."""
        start_month, end_month = month_range
        dist_data = pd.read_excel(self.file_path, sheet_name='Distribution')
        dist_data['Date'] = pd.to_datetime(dist_data['Date'])
        dist_data['Month'] = dist_data['Date'].dt.to_period('M')
        filtered_data = dist_data[
            (dist_data['Branch'] == branch) &
            (dist_data['Month'] >= start_month) & 
            (dist_data['Month'] <= end_month)
        ]
        dist_summary = filtered_data.groupby('ProductName').agg({
            'DistributedQuantity': 'sum',
            'SoldQuantity': 'sum'
        })
        dist_summary['DistributionPercentage'] = (dist_summary['SoldQuantity'] / dist_summary['DistributedQuantity'] * 100).round(2)
        return {
            "branch": branch,
            "month_range": month_range,
            "table": dist_summary.reset_index()[['ProductName', 'DistributedQuantity', 'SoldQuantity', 'DistributionPercentage']],
            "graph_data": dist_summary['DistributionPercentage'].values,
            "labels": dist_summary.index
        }

    def visualize(self, data: dict):
        """Visualize distribution analysis data."""
        if "error" in data:
            print(data["error"])
            return
        plt.figure(figsize=(10, 6))
        plt.bar(data["labels"], data["graph_data"])
        plt.title(f"Distribution Analysis for {data['branch']} ({data['month_range'][0]} to {data['month_range'][1]})")
        plt.xlabel("Product Name")
        plt.ylabel("Distribution Percentage (%)")
        plt.grid(True)
        plt.xticks(rotation=45)
        plt.show()
        print("\nDistribution Analysis Table:")
        print(data["table"].to_string(index=False))