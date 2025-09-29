from analysis_strategies import (
    MonthlySalesAnalysis,
    ProductPriceAnalysis,
    WeeklySalesAnalysis,
    ProductPreferenceAnalysis,
    DistributionVsSalesAnalysis
)

# OOP: Encapsulation of strategy creation logic
# Design Pattern: Factory pattern for creating analysis strategy instances
# SOLID (OCP): Open for extension by adding new strategies to the dictionary
class AnalysisFactory:
    """Factory class to create analysis strategy instances."""
    @staticmethod
    # Clean Code: Clear method name and error handling
    def get_analysis_strategy(analysis_type):
        """Return the appropriate analysis strategy based on type."""
        # Data Structure: Dictionary for mapping analysis types to strategy classes
        strategies = {
            'monthly_sales': MonthlySalesAnalysis,
            'product_price': ProductPriceAnalysis,
            'weekly_sales': WeeklySalesAnalysis,
            'product_preference': ProductPreferenceAnalysis,
            'distribution_vs_sales': DistributionVsSalesAnalysis
        }
        strategy = strategies.get(analysis_type)
        if not strategy:
            # Clean Code: Proper error handling with descriptive message
            raise ValueError(f"Unknown analysis type: {analysis_type}")
        return strategy()

