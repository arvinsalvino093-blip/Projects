import pandas as pdpdpd
from datetime import datetime

# Sample data for branches (same structure for all 12 branches)
branch_data = {
    'Date': ['2024-01-01', '2024-01-02', '2024-02-01', '2024-02-02', '2025-01-01'],
    'ProductID': ['P001', 'P002', 'P001', 'P002', 'P003'],
    'ProductName': ['Rice', 'Dhal', 'Rice', 'Dhal', 'Sugar'],
    'UnitPrice': [150.00, 200.00, 150.00, 200.00, 120.00],
    'QuantitySold': [100, 50, 80, 60, 70]
}

# Sample data for Products sheet
product_data = {
    'ProductID': ['P001', 'P002', 'P003'],
    'ProductName': ['Rice', 'Dhal', 'Sugar'],
    'Category': ['Grain', 'Pulses', 'Sweetener'],
    'UnitPrice': [150.00, 200.00, 120.00]
}

# Sample data for Distribution sheet
distribution_data = {
    'Branch': ['Jaffna', 'Jaffna', 'Colombo', 'Colombo', 'Kandy'],
    'Date': ['2024-01-01', '2024-01-02', '2024-01-01', '2024-02-01', '2024-01-01'],
    'ProductID': ['P001', 'P002', 'P001', 'P002', 'P003'],
    'ProductName': ['Rice', 'Dhal', 'Rice', 'Dhal', 'Sugar'],
    'DistributedQuantity': [200, 100, 150, 120, 100],
    'SoldQuantity': [100, 50, 80, 60, 70]
}

# List of 12 branches
branches = [
    'Jaffna', 'Colombo', 'Kandy', 'Galle', 'Matara', 'Negombo',
    'Kurunegala', 'Anuradhapura', 'Polonnaruwa', 'Batticaloa', 'Trincomalee', 'Ratnapura'
]

# Create Excel file
with pd.ExcelWriter('data/sampath_food_city.xlsx', engine='openpyxl') as writer:
    # Write branch data for each branch
    for branch in branches:
        pd.DataFrame(branch_data).to_excel(writer, sheet_name=branch, index=False)
    # Write Products sheet
    pd.DataFrame(product_data).to_excel(writer, sheet_name='Products', index=False)
    # Write Distribution sheet
    pd.DataFrame(distribution_data).to_excel(writer, sheet_name='Distribution', index=False)

print("Excel file 'sampath_food_city.xlsx' created successfully in the 'data/' directory.")