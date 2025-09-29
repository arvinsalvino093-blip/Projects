import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns
from abc import ABC, abstractmethod
import os
import logging
from datetime import datetime

# Clean Code: Configure logging for consistent debugging
logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s')

# OOP: Abstraction via abstract base class
# SOLID (ISP): Minimal interface with only necessary methods
# Design Pattern: Strategy pattern for interchangeable analysis algorithms
class AnalysisStrategy(ABC):
    """Abstract base class for analysis strategies."""
    @abstractmethod
    def analyze(self, data, **kwargs):
        pass

    @abstractmethod
    def visualize(self, output_dir):
        pass

    # Clean Code: Small, reusable method for month validation
    def validate_month_range(self, start_month, end_month, year):
        """Validate and normalize month range input."""
        # Data Structure: List of months for validation
        months = ['january', 'february', 'march', 'april', 'may', 'june',
                  'july', 'august', 'september', 'october', 'november', 'december']
        # Data Structure: Dictionary for mapping month abbreviations
        month_map = {
            'jan': 'january', 'feb': 'february', 'mar': 'march', 'apr': 'april',
            'may': 'may', 'jun': 'june', 'jul': 'july', 'aug': 'august',
            'sep': 'september', 'oct': 'october', 'nov': 'november', 'dec': 'december'
        }
        try:
            start = month_map.get(start_month.lower(), start_month.lower())
            end = month_map.get(end_month.lower(), end_month.lower())
            if start not in months or end not in months:
                raise ValueError("Invalid month name. Use full month names or abbreviations (e.g., Jan, May).")
            start_idx = months.index(start)
            end_idx = months.index(end)
            if start_idx > end_idx:
                raise ValueError("Start month must be before or equal to end month.")
            # Data Structure: List comprehension for YYYY-MM format
            return [f"{year}-{str(months.index(m) + 1).zfill(2)}" for m in months[start_idx:end_idx + 1]]
        except Exception as e:
            # Clean Code: Robust error handling with logging
            logging.error(f"Month range validation error: {e}")
            raise

    # Clean Code: Focused method for branch validation
    def validate_branch(self, branch, data):
        """Validate branch name."""
        # Data Structure: Set-like unique values from DataFrame
        branches = data['Transactions']['Branch'].unique()
        if branch not in branches:
            raise ValueError(f"Invalid branch name. Available branches: {', '.join(branches)}")
        return branch

    # Clean Code: Focused method for product validation
    def validate_product(self, product_name, data):
        """Validate product name."""
        products = data['Products']
        if product_name not in products['Product_Name'].values:
            raise ValueError(f"Invalid product name. Available products: {', '.join(products['Product_Name'])}")
        return product_name

# OOP: Inheritance from AnalysisStrategy
# SOLID (SRP): Handles only monthly sales analysis
# SOLID (LSP): Can be substituted for AnalysisStrategy
class MonthlySalesAnalysis(AnalysisStrategy):
    """Class for monthly sales analysis per branch."""
    def __init__(self):
        self.results = None
        self.branch = None
        self.month_range = None

    # SOLID (LSP): Implements analyze method as per AnalysisStrategy
    def analyze(self, data, **kwargs):
        """Analyze monthly sales for a given branch and month range."""
        try:
            self.branch = self.validate_branch(kwargs['branch'], data)
            self.month_range = self.validate_month_range(kwargs['start_month'], kwargs['end_month'], kwargs['year'])
            # Data Structure: DataFrame for data manipulation
            transactions = data['Transactions'].copy()
            if not pd.api.types.is_datetime64_any_dtype(transactions['Date']):
                try:
                    transactions['Date'] = pd.to_datetime(transactions['Date'], format='%Y-%m-%d', errors='coerce')
                except ValueError:
                    transactions['Date'] = pd.to_datetime(transactions['Date'], unit='D', origin='1899-12-30', errors='coerce')
            if transactions['Date'].isna().any():
                raise ValueError("Some dates could not be parsed. Check the Date column format.")
            transactions['Month'] = transactions['Date'].dt.strftime('%Y-%m')
            filtered_data = transactions[
                (transactions['Branch'] == self.branch) &
                (transactions['Month'].isin(self.month_range))
            ]
            self.results = filtered_data.groupby(['Branch', 'Month'])['Total_Amount'].sum().reset_index()
            self.results.columns = ['Branch', 'Month', 'Total Sale']
            # Clean Code: Logging for traceability
            logging.info(f"Monthly sales analysis completed for {self.branch} from {kwargs['start_month']} to {kwargs['end_month']} in {kwargs['year']}.")
            return self.results
        except KeyError as e:
            logging.error(f"Error in monthly sales analysis: {e}")
            raise
        except Exception as e:
            logging.error(f"Error in monthly sales analysis: {e}")
            raise

    def visualize(self, output_dir):
        """Visualize monthly sales for the branch."""
        if self.results is None:
            logging.error("No results to visualize. Run analyze first.")
            return
        plt.figure(figsize=(10, 6))
        self.results['Month_Name'] = self.results['Month'].apply(lambda x: datetime.strptime(x, '%Y-%m').strftime('%B'))
        sns.lineplot(data=self.results, x='Month_Name', y='Total Sale', marker='o')
        plt.title(f"{self.branch} Branch - {self.month_range[0][-2:]} to {self.month_range[-1][-2:]} {self.month_range[0][:4]}")
        plt.xlabel('Month')
        plt.ylabel('Total Sale (LKR)')
        plt.xticks(rotation=45)
        output_path = os.path.join(output_dir, f"monthly_sales_{self.branch.lower()}_{self.month_range[0][:4]}.png")
        plt.savefig(output_path)
        plt.show()
        plt.close()
        logging.info(f"Monthly sales visualization saved to {output_path}")

# OOP: Inheritance from AnalysisStrategy
# SOLID (SRP): Handles only product price trend analysis
# SOLID (LSP): Can be substituted for AnalysisStrategy
class ProductPriceAnalysis(AnalysisStrategy):
    """Class for product price trend analysis."""
    def __init__(self):
        self.results = None
        self.product_name = None
        self.month_range = None

    # SOLID (LSP): Implements analyze method as per AnalysisStrategy
    def analyze(self, data, **kwargs):
        """Analyze price trends for a given product and month range."""
        try:
            self.product_name = self.validate_product(kwargs['product_name'], data)
            self.month_range = self.validate_month_range(kwargs['start_month'], kwargs['end_month'], kwargs['year'])
            # Data Structure: DataFrame for data manipulation
            transactions = data['Transactions'].copy()
            if not pd.api.types.is_datetime64_any_dtype(transactions['Date']):
                try:
                    transactions['Date'] = pd.to_datetime(transactions['Date'], format='%Y-%m-%d', errors='coerce')
                except ValueError:
                    transactions['Date'] = pd.to_datetime(transactions['Date'], unit='D', origin='1899-12-30', errors='coerce')
            if transactions['Date'].isna().any():
                raise ValueError("Some dates could not be parsed. Check the Date column format.")
            transactions['Month'] = transactions['Date'].dt.strftime('%Y-%m')
            products = data['Products']
            product_id = products[products['Product_Name'] == self.product_name]['Product_ID'].iloc[0]
            filtered_data = transactions[
                (transactions['Product_ID'] == product_id) &
                (transactions['Month'].isin(self.month_range))
            ]
            self.results = filtered_data.groupby('Month')['Unit_Price'].mean().reset_index()
            self.results.columns = ['Month', 'Unit Price']
            # Clean Code: Logging for traceability
            logging.info(f"Price analysis completed for {self.product_name} from {kwargs['start_month']} to {kwargs['end_month']} in {kwargs['year']}.")
            return self.results
        except KeyError as e:
            logging.error(f"Error in product price analysis: {e}")
            raise
        except Exception as e:
            logging.error(f"Error in product price analysis: {e}")
            raise

    def visualize(self, output_dir):
        """Visualize price trend for the product."""
        if self.results is None:
            logging.error("No results to visualize. Run analyze first.")
            return
        plt.figure(figsize=(10, 6))
        self.results['Month_Name'] = self.results['Month'].apply(lambda x: datetime.strptime(x, '%Y-%m').strftime('%B'))
        sns.lineplot(data=self.results, x='Month_Name', y='Unit Price', marker='o', color='green')
        plt.title(f"Price Trend for {self.product_name} - {self.month_range[0][-2:]} to {self.month_range[-1][-2:]} {self.month_range[0][:4]}")
        plt.xlabel('Month')
        plt.ylabel('Price (LKR)')
        plt.xticks(rotation=45)
        output_path = os.path.join(output_dir, f"price_trend_{self.product_name.lower().replace(' ', '_')}_{self.month_range[0][:4]}.png")
        plt.savefig(output_path)
        plt.show()
        plt.close()
        logging.info(f"Price trend visualization saved to {output_path}")

# OOP: Inheritance from AnalysisStrategy
# SOLID (SRP): Handles only weekly sales analysis
# SOLID (LSP): Can be substituted for AnalysisStrategy
class WeeklySalesAnalysis(AnalysisStrategy):
    """Class for weekly sales analysis of entire network."""
    def __init__(self):
        self.results = None
        self.month = None

    # SOLID (LSP): Implements analyze method as per AnalysisStrategy
    def analyze(self, data, **kwargs):
        """Analyze weekly sales for a given month across all branches."""
        try:
            self.month = self.validate_month_range(kwargs['month'], kwargs['month'], kwargs['year'])[0]
            # Data Structure: DataFrame for data manipulation
            transactions = data['Transactions'].copy()
            if not pd.api.types.is_datetime64_any_dtype(transactions['Date']):
                try:
                    transactions['Date'] = pd.to_datetime(transactions['Date'], format='%Y-%m-%d', errors='coerce')
                except ValueError:
                    transactions['Date'] = pd.to_datetime(transactions['Date'], unit='D', origin='1899-12-30', errors='coerce')
            if transactions['Date'].isna().any():
                raise ValueError("Some dates could not be parsed. Check the Date column format.")
            transactions['Month'] = transactions['Date'].dt.strftime('%Y-%m')
            transactions['Week'] = transactions['Date'].dt.isocalendar().week
            filtered_data = transactions[transactions['Month'] == self.month]
            self.results = filtered_data.groupby('Week')['Total_Amount'].sum().reset_index()
            self.results.columns = ['Week Number', 'Total Sales']
            # Clean Code: Logging for traceability
            logging.info(f"Weekly sales analysis completed for {self.month}.")
            return self.results
        except KeyError as e:
            logging.error(f"Error in weekly sales analysis: {e}")
            raise
        except Exception as e:
            logging.error(f"Error in weekly sales analysis: {e}")
            raise

    def visualize(self, output_dir):
        """Visualize weekly sales for the month."""
        if self.results is None:
            logging.error("No results to visualize. Run analyze first.")
            return
        plt.figure(figsize=(10, 6))
        sns.lineplot(data=self.results, x='Week Number', y='Total Sales', marker='o', color='purple')
        month_name = datetime.strptime(self.month, '%Y-%m').strftime('%B %Y')
        plt.title(f"Weekly Sales for {month_name} - Entire Network")
        plt.xlabel('Week')
        plt.ylabel('Total Sales (LKR)')
        output_path = os.path.join(output_dir, f"weekly_sales_{month_name.lower().replace(' ', '_')}.png")
        plt.savefig(output_path)
        plt.show()
        plt.close()
        logging.info(f"Weekly sales visualization saved to {output_path}")

# OOP: Inheritance from AnalysisStrategy
# SOLID (SRP): Handles only product preference analysis
# SOLID (LSP): Can be substituted for AnalysisStrategy
class ProductPreferenceAnalysis(AnalysisStrategy):
    """Class for product preference analysis per branch."""
    def __init__(self):
        self.results = None
        self.branch = None
        self.month_range = None

    # SOLID (LSP): Implements analyze method as per AnalysisStrategy
    def analyze(self, data, **kwargs):
        """Analyze product preferences for a given branch and month range."""
        try:
            self.branch = self.validate_branch(kwargs['branch'], data)
            self.month_range = self.validate_month_range(kwargs['start_month'], kwargs['end_month'], kwargs['year'])
            # Data Structure: DataFrame for data manipulation
            transactions = data['Transactions'].copy()
            if not pd.api.types.is_datetime64_any_dtype(transactions['Date']):
                try:
                    transactions['Date'] = pd.to_datetime(transactions['Date'], format='%Y-%m-%d', errors='coerce')
                except ValueError:
                    transactions['Date'] = pd.to_datetime(transactions['Date'], unit='D', origin='1899-12-30', errors='coerce')
            if transactions['Date'].isna().any():
                raise ValueError("Some dates could not be parsed. Check the Date column format.")
            transactions['Month'] = transactions['Date'].dt.strftime('%Y-%m')
            filtered_data = transactions[
                (transactions['Branch'] == self.branch) &
                (transactions['Month'].isin(self.month_range))
            ]
            filtered_data = filtered_data.merge(data['Products'][['Product_ID', 'Product_Name']], on='Product_ID')
            self.results = filtered_data.groupby('Product_Name')['Quantity'].sum().reset_index()
            self.results.columns = ['Product Name', 'Total Count']
            self.results = self.results.sort_values('Total Count', ascending=False).head(10)
            # Clean Code: Logging for traceability
            logging.info(f"Product preference analysis completed for {self.branch} from {kwargs['start_month']} to {kwargs['end_month']} in {kwargs['year']}.")
            return self.results
        except KeyError as e:
            logging.error(f"Error in product preference analysis: {e}")
            raise
        except Exception as e:
            logging.error(f"Error in product preference analysis: {e}")
            raise

    def visualize(self, output_dir):
        """Visualize product preferences for the branch."""
        if self.results is None:
            logging.error("No results to visualize. Run analyze first.")
            return
        plt.figure(figsize=(12, 6))
        sns.barplot(data=self.results, x='Product Name', y='Total Count', palette='viridis')
        plt.title(f"Product Preference - {self.branch} - {self.month_range[0][-2:]} to {self.month_range[-1][-2:]} {self.month_range[0][:4]}")
        plt.xlabel('Product')
        plt.ylabel('Count')
        plt.xticks(rotation=45, ha='right')
        output_path = os.path.join(output_dir, f"product_preference_{self.branch.lower()}_{self.month_range[0][:4]}.png")
        plt.savefig(output_path)
        plt.show()
        plt.close()
        logging.info(f"Product preference visualization saved to {output_path}")

# OOP: Inheritance from AnalysisStrategy
# SOLID (SRP): Handles only distribution vs sales analysis
# SOLID (LSP): Can be substituted for AnalysisStrategy
class DistributionVsSalesAnalysis(AnalysisStrategy):
    """Class for distribution vs sales analysis."""
    def __init__(self):
        self.results = None
        self.branch = None
        self.month_range = None

    # SOLID (LSP): Implements analyze method as per AnalysisStrategy
    def analyze(self, data, **kwargs):
        """Analyze distribution vs sales for a given branch and month range."""
        try:
            self.branch = self.validate_branch(kwargs['branch'], data)
            self.month_range = self.validate_month_range(kwargs['start_month'], kwargs['end_month'], kwargs['year'])
            if 'Distribution' not in data:
                raise ValueError("Distribution sheet not found in the provided data.")
            # Data Structure: DataFrame for data manipulation
            transactions = data['Transactions'].copy()
            distribution = data['Distribution']
            if not pd.api.types.is_datetime64_any_dtype(transactions['Date']):
                try:
                    transactions['Date'] = pd.to_datetime(transactions['Date'], format='%Y-%m-%d', errors='coerce')
                except ValueError:
                    transactions['Date'] = pd.to_datetime(transactions['Date'], unit='D', origin='1899-12-30', errors='coerce')
            if transactions['Date'].isna().any():
                raise ValueError("Some dates could not be parsed. Check the Date column format.")
            transactions['Month'] = transactions['Date'].dt.strftime('%Y-%m')
            sales_data = transactions[
                (transactions['Branch'] == self.branch) &
                (transactions['Month'].isin(self.month_range))
            ]
            sales_data = sales_data.merge(data['Products'][['Product_ID', 'Product_Name']], on='Product_ID')
            sales_summary = sales_data.groupby(['Product_Name', 'Month'])['Quantity'].sum().reset_index()
            distribution = distribution[
                (distribution['Branch'] == self.branch) &
                (distribution['Month'].isin(self.month_range))
            ]
            distribution = distribution.merge(data['Products'][['Product_ID', 'Product_Name']], on='Product_ID')
            distribution_summary = distribution.groupby(['Product_Name', 'Month'])['Distributed_Amount'].sum().reset_index()
            self.results = sales_summary.merge(distribution_summary, on=['Product_Name', 'Month'], how='outer').fillna(0)
            self.results['% Sold'] = (self.results['Quantity'] / self.results['Distributed_Amount'] * 100).round(2)
            self.results = self.results.groupby('Product_Name').agg({
                'Distributed_Amount': 'sum',
                'Quantity': 'sum',
                '% Sold': 'mean'
            }).reset_index()
            self.results.columns = ['Product', 'Total Distributed', 'Total Sold', '% Sold']
            # Clean Code: Logging for traceability
            logging.info(f"Distribution vs sales analysis completed for {self.branch} from {kwargs['start_month']} to {kwargs['end_month']} in {kwargs['year']}.")
            return self.results
        except KeyError as e:
            logging.error(f"Error in distribution vs sales analysis: {e}")
            raise
        except Exception as e:
            logging.error(f"Error in distribution vs sales analysis: {e}")
            raise

    def visualize(self, output_dir):
        """Visualize distribution vs sales for the branch."""
        if self.results is None:
            logging.error("No results to visualize. Run analyze first.")
            return
        plt.figure(figsize=(12, 6))
        sns.barplot(data=self.results, x='Product', y='% Sold', palette='magma')
        plt.title(f"Distribution vs Sales - {self.branch} - {self.month_range[0][-2:]} to {self.month_range[-1][-2:]} {self.month_range[0][:4]}")
        plt.xlabel('Product')
        plt.ylabel('Distribution %')
        plt.xticks(rotation=45, ha='right')
        output_path = os.path.join(output_dir, f"distribution_vs_sales_{self.branch.lower()}_{self.month_range[0][:4]}.png")
        plt.savefig(output_path)
        plt.show()
        plt.close()
        logging.info(f"Distribution vs sales visualization saved to {output_path}")

