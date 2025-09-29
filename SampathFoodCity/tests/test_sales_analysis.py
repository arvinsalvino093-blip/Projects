import pytest
import pandas as pd
from src.analysis.sales_analysis import MonthlySalesAnalysis
from src.analysis.price_analysis import PriceAnalysis
from src.analysis.weekly_sales_analysis import WeeklySalesAnalysis
from src.analysis.product_preference import ProductPreferenceAnalysis
from src.analysis.distribution_analysis import DistributionAnalysis

@pytest.fixture
def setup_data(tmp_path):
    """Set up temporary Excel file for testing."""
    file_path = tmp_path / "test_data.xlsx"
    data = {
        'Jaffna': pd.DataFrame({
            'Date': ['2024-01-01', '2024-01-15', '2024-02-01'],
            'ProductID': ['P001', 'P002', 'P001'],
            'ProductName': ['Rice', 'Dhal', 'Rice'],
            'UnitPrice': [150.00, 200.00, 150.00],
            'QuantitySold': [100, 50, 80]
        }),
        'Products': pd.DataFrame({
            'ProductID': ['P001', 'P002'],
            'ProductName': ['Rice', 'Dhal'],
            'Category': ['Grain', 'Pulses'],
            'UnitPrice': [150.00, 200.00]
        }),
        'Distribution': pd.DataFrame({
            'Branch': ['Jaffna', 'Jaffna'],
            'Date': ['2024-01-01', '2024-02-01'],
            'ProductID': ['P001', 'P002'],
            'ProductName': ['Rice', 'Dhal'],
            'DistributedQuantity': [200, 100],
            'SoldQuantity': [100, 50]
        })
    }
    with pd.ExcelWriter(file_path) as writer:
        for sheet, df in data.items():
            df.to_excel(writer, sheet_name=sheet, index=False)
    return file_path

def test_monthly_sales_analysis(setup_data):
    """Test monthly sales analysis."""
    analysis = MonthlySalesAnalysis(setup_data)
    result = analysis.analyze(branch="Jaffna", month_range=("2024-01", "2024-02"))
    assert not result["table"].empty
    assert "TotalSales" in result["table"].columns
    assert len(result["labels"]) > 0

def test_price_analysis(setup_data):
    """Test price analysis."""
    analysis = PriceAnalysis(setup_data)
    result = analysis.analyze(product_id="P001", month_range=("2024-01", "2024-02"))
    assert not result["table"].empty
    assert "UnitPrice" in result["table"].columns
    assert len(result["labels"]) > 0

def test_weekly_sales_analysis(setup_data):
    """Test weekly sales analysis."""
    analysis = WeeklySalesAnalysis(setup_data)
    result = analysis.analyze(month="2024-01")
    assert not result["table"].empty
    assert "TotalSales" in result["table"].columns
    assert len(result["labels"]) > 0

def test_product_preference_analysis(setup_data):
    """Test product preference analysis."""
    analysis = ProductPreferenceAnalysis(setup_data)
    result = analysis.analyze(branch="Jaffna", month_range=("2024-01", "2024-02"))
    assert not result["table"].empty
    assert "QuantitySold" in result["table"].columns
    assert len(result["labels"]) > 0

def test_distribution_analysis(setup_data):
    """Test distribution analysis."""
    analysis = DistributionAnalysis(setup_data)
    result = analysis.analyze(branch="Jaffna", month_range=("2024-01", "2024-02"))
    assert not result["table"].empty
    assert "DistributionPercentage" in result["table"].columns
    assert len(result["labels"]) > 0