import logging

# Clean Code: Configure logging for consistent debugging
logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s')

# OOP: Encapsulation of configuration management
# SOLID (SRP): Solely responsible for managing configuration settings
class ConfigManager:
    """Class to manage configuration settings for the application."""
    def __init__(self):
        # Data Structure: Dictionary to store configuration key-value pairs
        self.config = {
            'data_file': 'Updated_Sample_With_Summaries.xlsx',
            'output_dir': 'analysis_outputs'
        }
        logging.info("ConfigManager initialized with default settings.")

    # Clean Code: Clear method name, type hints, and error handling
    def get_config(self, key: str) -> str:
        """Retrieve a configuration value by key."""
        if key not in self.config:
            logging.error(f"Configuration key '{key}' not found.")
            raise KeyError(f"Configuration key '{key}' not found.")
        return self.config[key]

