import unittest

# Mock system classes & methods (replace with real ones)
class AuthManager:
    users = {"admin": "admin123"}

    @staticmethod
    def login(username, password):
        return AuthManager.users.get(username) == password

    @staticmethod
    def add_user(username, password):
        if username in AuthManager.users:
            return False
        AuthManager.users[username] = password
        return True

class DataLoader:
    @staticmethod
    def load_data(file_path):
        # Simulate loading Excel file
        if file_path == "nonexistent.xlsx":
            # Simulate error log
            print("Error loading data")
            return None
        # Simulate successful load with sheets
        return {
            "Transactions": [],
            "Products": [],
            "Distribution": []
        }

class MonthlySalesAnalysis:
    @staticmethod
    def analyze(branch, start_month, end_month, year):
        # Dummy data simulating sales per month
        return {"January": 1000, "February": 1100, "March": 1200}

    @staticmethod
    def visualize(data):
        # Pretend saving a bar chart file
        return "output/bar_chart.png"

class ProductPriceAnalysis:
    @staticmethod
    def analyze(product, start_month, end_month, year):
        return {"January": 50, "February": 52, "March": 55}

    @staticmethod
    def visualize(data):
        return "output/line_chart.png"

class WeeklySalesAnalysis:
    @staticmethod
    def analyze(month, year):
        return {"Week1": 250, "Week2": 300, "Week3": 280, "Week4": 320}

    @staticmethod
    def visualize(data):
        return "output/bar_chart.png"

class ProductPreferenceAnalysis:
    @staticmethod
    def analyze(branch, start_month, end_month, year):
        return {"ProductA": 100, "ProductB": 150, "ProductC": 130}

    @staticmethod
    def visualize(data):
        return "output/Bar_chart.png"

class DistributionVsSalesAnalysis:
    @staticmethod
    def analyze(branch, start_month, end_month, year):
        return {"Distribution": 5000, "Sales": 4800}

    @staticmethod
    def visualize(data):
        return "output/Bar_chart.png"

class SalesAnalysisSystem:
    @staticmethod
    def validate_month_range(start_month, end_month):
        months_order = ["January", "February", "March", "April", "May", "June",
                        "July", "August", "September", "October", "November", "December"]
        try:
            start_idx = months_order.index(start_month)
            end_idx = months_order.index(end_month)
            return start_idx <= end_idx
        except ValueError:
            return False


# Keyword functions
def keyword_login(params):
    return AuthManager.login(params['username'], params['password'])

def keyword_add_user(params):
    return AuthManager.add_user(params['username'], params['password'])

def keyword_load_data(params):
    data = DataLoader.load_data(params['file_path'])
    return data is not None

def keyword_monthly_sales_analysis(params):
    data = MonthlySalesAnalysis.analyze(params['branch'], params['start_month'], params['end_month'], params['year'])
    image = MonthlySalesAnalysis.visualize(data)
    return bool(data) and image.endswith('.png')

def keyword_product_price_analysis(params):
    data = ProductPriceAnalysis.analyze(params['product'], params['start_month'], params['end_month'], params['year'])
    image = ProductPriceAnalysis.visualize(data)
    return bool(data) and image.endswith('.png')

def keyword_weekly_sales_analysis(params):
    data = WeeklySalesAnalysis.analyze(params['month'], params['year'])
    image = WeeklySalesAnalysis.visualize(data)
    return bool(data) and image.endswith('.png')

def keyword_product_preference_analysis(params):
    data = ProductPreferenceAnalysis.analyze(params['branch'], params['start_month'], params['end_month'], params['year'])
    image = ProductPreferenceAnalysis.visualize(data)
    return bool(data) and image.endswith('.png')

def keyword_distribution_vs_sales_analysis(params):
    data = DistributionVsSalesAnalysis.analyze(params['branch'], params['start_month'], params['end_month'], params['year'])
    image = DistributionVsSalesAnalysis.visualize(data)
    return bool(data) and image.endswith('.png')

def keyword_validate_month_range(params):
    return SalesAnalysisSystem.validate_month_range(params['start_month'], params['end_month'])


# Map keywords to functions
keyword_functions = {
    "LOGIN": keyword_login,
    "ADD_USER": keyword_add_user,
    "LOAD_DATA": keyword_load_data,
    "MONTHLY_SALES_ANALYSIS": keyword_monthly_sales_analysis,
    "PRODUCT_PRICE_ANALYSIS": keyword_product_price_analysis,
    "WEEKLY_SALES_ANALYSIS": keyword_weekly_sales_analysis,
    "PRODUCT_PREFERENCE_ANALYSIS": keyword_product_preference_analysis,
    "DISTRIBUTION_VS_SALES_ANALYSIS": keyword_distribution_vs_sales_analysis,
    "VALIDATE_MONTH_RANGE": keyword_validate_month_range,
}

# Test cases based on your test plan
test_cases = [
    (1, "LOGIN", {"username": "admin", "password": "admin123"}, True),
    (2, "LOGIN", {"username": "user", "password": "wrongpass"}, False),
    (3, "ADD_USER", {"username": "newuser", "password": "newpass"}, True),
    (4, "ADD_USER", {"username": "admin", "password": "newpass"}, False),
    (5, "LOAD_DATA", {"file_path": "Updated_Sample_With_Summaries.xlsx"}, True),
    (6, "LOAD_DATA", {"file_path": "nonexistent.xlsx"}, False),
    (7, "MONTHLY_SALES_ANALYSIS", {"branch": "Branch1", "start_month": "January", "end_month": "March", "year": 2023}, True),
    (8, "PRODUCT_PRICE_ANALYSIS", {"product": "ProductA", "start_month": "January", "end_month": "March", "year": 2023}, True),
    (9, "WEEKLY_SALES_ANALYSIS", {"month": "January", "year": 2023}, True),
    (10, "PRODUCT_PREFERENCE_ANALYSIS", {"branch": "Branch1", "start_month": "January", "end_month": "March", "year": 2023}, True),
    (11, "DISTRIBUTION_VS_SALES_ANALYSIS", {"branch": "Branch1", "start_month": "January", "end_month": "March", "year": 2023}, True),
    (12, "VALIDATE_MONTH_RANGE", {"start_month": "March", "end_month": "January"}, False),
]


class SampathFoodCityTest(unittest.TestCase):
    def test_keyword_driven(self):
        for test_no, keyword, params, expected in test_cases:
            func = keyword_functions.get(keyword)
            self.assertIsNotNone(func, f"Keyword '{keyword}' not implemented.")
            try:
                result = func(params)
                self.assertEqual(result, expected)
                print(f"Test Case {test_no}: {keyword} - PASS")
            except AssertionError:
                print(f"Test Case {test_no}: {keyword} - FAIL")
                raise  # re-raise to let unittest handle failure reporting


if __name__ == "__main__":
    unittest.main()
