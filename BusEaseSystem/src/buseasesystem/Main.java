/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package buseasesystem;

/**
 *
 * @author User
 */
import java.util.Scanner;

/**
 * The main entry point for the BusEaseSystem, providing a console-based interface
 * for customers and admins to interact with the system. Manages user input and
 * delegates tasks to the BusEaseSystem class.
 *
 * @author User
 */
public class Main {
    /**
     * The main method that starts the BusEaseSystem, initializes the system,
     * and provides a menu-driven interface for customer and admin operations.
     *
     * @param args Command-line arguments (not used)
     */
    public static void main(String[] args) {
        // Initialize the BusEaseSystem and load persisted data
        BusEaseSystem system = new BusEaseSystem();
        system.loadData();
        // Create Scanner for user input
        Scanner scanner = new Scanner(System.in);

        // Main loop for the system menu
        while (true) {
            // Display main menu options
            System.out.println("\n=== BusEase System ===");
            System.out.println("1. Customer");
            System.out.println("2. Bus Admin");
            System.out.println("3. Exit");
            System.out.print("Select an option: ");
            int choice = scanner.nextInt();
            scanner.nextLine(); // Consume newline

            // Handle user selection
            if (choice == 1) {
                handleCustomerMenu(system, scanner);
            } else if (choice == 2) {
                handleAdminMenu(system, scanner);
            } else if (choice == 3) {
                // Save data and exit the program
                system.saveData();
                System.out.println("Exiting BusEase System. Goodbye!");
                break;
            } else {
                System.out.println("Invalid option. Try again.");
            }
        }
        // Close the scanner to prevent resource leaks
        scanner.close();
    }

    /**
     * Handles the customer menu, allowing users to sign up or log in.
     *
     * @param system  The BusEaseSystem instance for managing operations
     * @param scanner The Scanner for reading user input
     */
    private static void handleCustomerMenu(BusEaseSystem system, Scanner scanner) {
        // Display customer menu options
        System.out.println("\n=== Customer Menu ===");
        System.out.println("1. Signup");
        System.out.println("2. Login");
        System.out.print("Select an option: ");
        int choice = scanner.nextInt();
        scanner.nextLine(); // Consume newline

        // Handle customer menu selection
        if (choice == 1) {
            // Collect customer signup details
            System.out.print("Enter full name: ");
            String name = scanner.nextLine();
            System.out.print("Enter mobile number: ");
            String mobile = scanner.nextLine();
            System.out.print("Enter email address: ");
            String email = scanner.nextLine();
            System.out.print("Enter city: ");
            String city = scanner.nextLine();
            System.out.print("Enter age: ");
            int age = scanner.nextInt();
            scanner.nextLine(); // Consume newline
            System.out.print("Enter password: ");
            String password = scanner.nextLine();
            // Call signup method
            system.customerSignup(name, mobile, email, city, age, password);
        } else if (choice == 2) {
            // Collect login credentials
            System.out.print("Enter mobile number: ");
            String mobile = scanner.nextLine();
            System.out.print("Enter password: ");
            String password = scanner.nextLine();
            // Attempt login and proceed to customer actions if successful
            if (system.customerLogin(mobile, password)) {
                handleCustomerActions(system, scanner, mobile);
            }
        } else {
            System.out.println("Invalid option.");
        }
    }

    /**
     * Handles customer actions after successful login, such as searching buses,
     * reserving seats, and managing reservations.
     *
     * @param system  The BusEaseSystem instance for managing operations
     * @param scanner The Scanner for reading user input
     * @param mobile  The customer's mobile number for identification
     */
    private static void handleCustomerActions(BusEaseSystem system, Scanner scanner, String mobile) {
        // Customer actions loop
        while (true) {
            // Display customer actions menu
            System.out.println("\n=== Customer Actions ===");
            System.out.println("1. Search Buses");
            System.out.println("2. Reserve Seat");
            System.out.println("3. Cancel Reservation");
            System.out.println("4. Request New Seat");
            System.out.println("5. View Personal Details and Reservations");
            System.out.println("6. Display All Reservations");
            System.out.println("7. Logout");
            System.out.print("Select an option: ");
            int choice = scanner.nextInt();
            scanner.nextLine(); // Consume newline

            // Handle customer action selection
            if (choice == 1) {
                // Collect search criteria
                System.out.print("Enter starting location: ");
                String start = scanner.nextLine();
                System.out.print("Enter destination: ");
                String destination = scanner.nextLine();
                // Search for buses
                system.searchBuses(start, destination);
            } else if (choice == 2) {
                // Collect reservation details
                System.out.print("Enter bus name: ");
                String busName = scanner.nextLine();
                System.out.print("Enter seat number: ");
                int seatNumber = scanner.nextInt();
                scanner.nextLine(); // Consume newline
                // Reserve a seat
                system.reserveSeat(busName, mobile, seatNumber);
            } else if (choice == 3) {
                // Collect cancellation details
                System.out.print("Enter seat number (-1 to cancel all): ");
                int seatNumber = scanner.nextInt();
                scanner.nextLine(); // Consume newline
                // Cancel reservation(s)
                system.cancelReservation(mobile, seatNumber);
            } else if (choice == 4) {
                // Collect seat change request details
                System.out.print("Enter current seat number: ");
                int currentSeat = scanner.nextInt();
                System.out.print("Enter desired new seat number: ");
                int newSeat = scanner.nextInt();
                scanner.nextLine(); // Consume newline
                // Request a new seat
                system.requestNewSeat(mobile, currentSeat, newSeat);
            } else if (choice == 5) {
                // View customer details and reservations
                system.viewPersonalReservations(mobile);
            } else if (choice == 6) {
                // Display all system reservations
                system.displayReservations();
            } else if (choice == 7) {
                // Logout and exit customer actions
                System.out.println("Logged out.");
                break;
            } else {
                System.out.println("Invalid option.");
            }
        }
    }

    /**
     * Handles the admin menu, requiring a password and allowing bus management,
     * customer removal, and system monitoring.
     *
     * @param system  The BusEaseSystem instance for managing operations
     * @param scanner The Scanner for reading user input
     */
    private static void handleAdminMenu(BusEaseSystem system, Scanner scanner) {
        // Prompt for admin password
        System.out.print("Enter admin password: ");
        String password = scanner.nextLine();
        // Validate password (hardcoded for simplicity)
        if (!password.equals("admin123")) {
            System.out.println("Invalid password.");
            return;
        }

        // Admin actions loop
        while (true) {
            // Display admin menu options
            System.out.println("\n=== Admin Menu ===");
            System.out.println("1. View All Data");
            System.out.println("2. Add New Bus");
            System.out.println("3. Remove Customer");
            System.out.println("4. Remove Bus");
            System.out.println("5. View Alerts");
            System.out.println("6. Process Waiting List");
            System.out.println("7. Logout");
            System.out.print("Select an option: ");
            int choice = scanner.nextInt();
            scanner.nextLine(); // Consume newline

            // Handle admin menu selection
            if (choice == 1) {
                // View all system data
                system.adminView();
            } else if (choice == 2) {
                // Collect new bus details
                System.out.print("Enter bus number plate: ");
                String numberPlate = scanner.nextLine();
                System.out.print("Enter total seats (max 50): ");
                int totalSeats = scanner.nextInt();
                scanner.nextLine(); // Consume newline
                System.out.print("Enter starting location: ");
                String start = scanner.nextLine();
                System.out.print("Enter destination: ");
                String destination = scanner.nextLine();
                System.out.print("Enter start time (HH:MM): ");
                String startTime = scanner.nextLine();
                System.out.print("Enter fare in LKR: ");
                double fare = scanner.nextDouble();
                scanner.nextLine(); // Consume newline
                System.out.print("Enter bus name: ");
                String busName = scanner.nextLine();
                // Register a new bus
                system.registerBus(numberPlate, totalSeats, start, destination, startTime, fare, busName);
            } else if (choice == 3) {
                // Collect customer mobile for removal
                System.out.print("Enter customer mobile number: ");
                String mobile = scanner.nextLine();
                // Remove customer
                system.adminRemoveCustomer(mobile);
            } else if (choice == 4) {
                // Collect bus number plate for removal
                System.out.print("Enter bus number plate: ");
                String numberPlate = scanner.nextLine();
                // Remove bus
                system.adminRemoveBus(numberPlate);
            } else if (choice == 5) {
                // Check and display low availability alerts
                system.checkLowAvailability();
            } else if (choice == 6) {
                // Process seat change requests in the waiting list
                system.processSeatChange();
            } else if (choice == 7) {
                // Save data and logout
                system.saveData();
                System.out.println("Logged out.");
                break;
            } else {
                System.out.println("Invalid option.");
            }
        }
    }
}