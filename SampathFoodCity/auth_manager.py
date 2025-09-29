import logging

# Clean Code: Configure logging for consistent debugging
logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s')

# OOP: Encapsulation of authentication logic
# SOLID (SRP): Solely responsible for user authentication
class AuthManager:
    """Class to manage user authentication."""
    def __init__(self):
        # Data Structure: Dictionary to store username-password pairs
        self.users = {'admin': 'admin123'}
        logging.info("AuthManager initialized with default admin user.")

    # Clean Code: Clear method name, type hints, and error handling
    def login(self, username: str, password: str) -> bool:
        """Authenticate a user."""
        if username in self.users and self.users[username] == password:
            logging.info(f"Successful login for user: {username}")
            return True
        logging.warning(f"Failed login attempt for user: {username}")
        return False

    # Clean Code: Focused method with descriptive logging
    def add_user(self, username: str, password: str) -> bool:
        """Add a new user to the system."""
        if username in self.users:
            logging.warning(f"User {username} already exists.")
            return False
        self.users[username] = password
        logging.info(f"User {username} added successfully.")
        return True


