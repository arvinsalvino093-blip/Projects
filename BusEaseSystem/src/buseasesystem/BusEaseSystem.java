/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
/*
 * Main class for the BusEase System
 * Manages customers, buses, reservations, and admin operations.
 */
package buseasesystem;

import java.io.*;
import java.util.*;

public class BusEaseSystem implements Serializable {
    private static final long serialVersionUID = 1L;

    // Stores customer data with mobile number as key
    private HashMap<String, Customer> customers;

    // Stores list of buses
    private List<Bus> buses;

    // Stores admin alert messages
    private List<String> adminAlerts;

    // Constructor initializes data structures
    public BusEaseSystem() {
        customers = new HashMap<>();
        buses = new ArrayList<>();
        adminAlerts = new ArrayList<>();
    }

    // Method to sign up a new customer
    public void customerSignup(String name, String mobile, String email, String city, int age, String password) {
        if (customers.containsKey(mobile)) {
            System.out.println("Mobile number already registered.");
            return;
        }
        Customer customer = new Customer(name, mobile, email, city, age, password);
        customers.put(mobile, customer);
        sendNotification(mobile, "Welcome to BusEase, " + name + "!");
        saveData();
        System.out.println("Customer registered successfully.");
    }

    // Method to log in an existing customer
    public boolean customerLogin(String mobile, String password) {
        Customer customer = customers.get(mobile);
        if (customer != null && customer.getPassword().equals(password)) {
            System.out.println("Welcome back, " + customer.getName() + "!");
            return true;
        }
        System.out.println("Invalid mobile number or password.");
        return false;
    }

    // Method to search buses by start and destination locations
    public void searchBuses(String start, String destination) {
        boolean found = false;
        for (Bus bus : buses) {
            if (bus.getStartingPoint().equalsIgnoreCase(start) && bus.getEndingPoint().equalsIgnoreCase(destination)) {
                found = true;
                System.out.println("Bus: " + bus.getBusName() + ", Number Plate: " + bus.getNumberPlate() +
                        ", Available Seats: " + bus.getAvailableSeats() + ", Start Time: " + bus.getStartTime() +
                        ", Fare: LKR " + bus.getFare());
            }
        }
        if (!found) {
            System.out.println("No buses found for the specified route.");
        }
    }

    // Method to reserve a seat for a customer
    public void reserveSeat(String busName, String mobile, int seatNumber) {
        Bus bus = findBusByName(busName);
        Customer customer = customers.get(mobile);
        if (bus == null || customer == null) {
            System.out.println("Invalid bus name or customer mobile.");
            return;
        }

        Scanner scanner = new Scanner(System.in);
        if (bus.bookSeat(seatNumber, mobile)) {
            System.out.print("Confirm payment (yes/no): ");
            String payment = scanner.nextLine();
            if (payment.equalsIgnoreCase("yes")) {
                Reservation reservation = new Reservation(bus.getNumberPlate(), seatNumber);
                customer.addReservation(reservation);
                sendNotification(mobile, "Seat " + seatNumber + " reserved on bus " + busName + ".");
                saveData();
                System.out.println("Reservation successful.");
            } else {
                bus.cancelSeat(seatNumber);
                sendNotification(mobile, "Reservation cancelled due to payment failure.");
                System.out.println("Reservation cancelled.");
            }
        } else {
            bus.addSeatRequest(new SeatRequest(mobile, seatNumber));
            sendNotification(mobile, "No seats available. Added to waiting list for seat " + seatNumber + ".");
            saveData();
            System.out.println("Added to waiting list.");
        }
    }

    // Method to cancel a reservation by mobile and seat number
    public void cancelReservation(String mobile, int seatNumber) {
        Customer customer = customers.get(mobile);
        if (customer == null) {
            System.out.println("Customer not found.");
            return;
        }
        boolean cancelled = false;

        // Cancel all reservations if seatNumber is -1
        if (seatNumber == -1) {
            for (Reservation reservation : new ArrayList<>(customer.getReservations())) {
                Bus bus = findBusByNumberPlate(reservation.getBusNumberPlate());
                if (bus != null) {
                    bus.cancelSeat(reservation.getSeatNumber());
                    sendNotification(mobile, "Reservation for seat " + reservation.getSeatNumber() + " on bus " + bus.getBusName() + " cancelled.");
                    customer.getReservations().remove(reservation);
                    cancelled = true;
                }
            }
        } else {
            // Cancel only the specific seat
            for (Reservation reservation : new ArrayList<>(customer.getReservations())) {
                if (reservation.getSeatNumber() == seatNumber) {
                    Bus bus = findBusByNumberPlate(reservation.getBusNumberPlate());
                    if (bus != null) {
                        bus.cancelSeat(seatNumber);
                        sendNotification(mobile, "Reservation for seat " + seatNumber + " on bus " + bus.getBusName() + " cancelled.");
                        customer.getReservations().remove(reservation);
                        cancelled = true;
                        break;
                    }
                }
            }
        }
        if (cancelled) {
            saveData();
            System.out.println("Reservation(s) cancelled successfully.");
        } else {
            System.out.println("No matching reservation found.");
        }
    }

    // Method to request a seat change
    public void requestNewSeat(String mobile, int currentSeat, int newSeat) {
        Customer customer = customers.get(mobile);
        if (customer == null) {
            System.out.println("Customer not found.");
            return;
        }

        for (Reservation reservation : customer.getReservations()) {
            if (reservation.getSeatNumber() == currentSeat) {
                Bus bus = findBusByNumberPlate(reservation.getBusNumberPlate());
                if (bus != null) {
                    bus.addSeatRequest(new SeatRequest(mobile, newSeat));
                    sendNotification(mobile, "Request for new seat " + newSeat + " on bus " + bus.getBusName() + " added to queue.");
                    saveData();
                    System.out.println("Seat change request added.");
                    return;
                }
            }
        }
        System.out.println("Current reservation not found.");
    }

    // Method to view a customer's reservations
    public void viewPersonalReservations(String mobile) {
        Customer customer = customers.get(mobile);
        if (customer == null) {
            System.out.println("Customer not found.");
            return;
        }
        customer.viewDetails();
        System.out.println("Reservations:");
        if (customer.getReservations().isEmpty()) {
            System.out.println("No reservations found.");
        } else {
            for (Reservation reservation : customer.getReservations()) {
                System.out.println("Bus: " + reservation.getBusNumberPlate() + ", Seat: " + reservation.getSeatNumber());
            }
        }
        customer.showNotifications();
    }

    // Method to display all reservations made
    public void displayReservations() {
        boolean found = false;
        for (Customer customer : customers.values()) {
            for (Reservation reservation : customer.getReservations()) {
                found = true;
                System.out.println("Customer: " + customer.getMobile() + ", Bus: " + reservation.getBusNumberPlate() + ", Seat: " + reservation.getSeatNumber());
            }
        }
        if (!found) {
            System.out.println("No reservations found.");
        }
    }

    // Admin method to view all data
    public void adminView() {
        System.out.println("\n=== Customers ===");
        if (customers.isEmpty()) {
            System.out.println("No customers registered.");
        } else {
            for (Customer customer : customers.values()) {
                System.out.println("Mobile: " + customer.getMobile() + ", Email: " + customer.getEmail());
            }
        }

        System.out.println("\n=== Buses ===");
        if (buses.isEmpty()) {
            System.out.println("No buses registered.");
        } else {
            for (Bus bus : buses) {
                System.out.println("Bus: " + bus.getBusName() + ", Number Plate: " + bus.getNumberPlate() +
                        ", Total Seats: " + bus.getTotalSeats() + ", Available Seats: " + bus.getAvailableSeats() +
                        ", Route: " + bus.getStartingPoint() + " to " + bus.getEndingPoint() +
                        ", Start Time: " + bus.getStartTime() + ", Fare: LKR " + bus.getFare() +
                        ", Reservations: " + bus.getReservations().size() + ", Waiting List: " + bus.getWaitingList().size());
            }
        }

        System.out.println("\n=== Admin Alerts ===");
        if (adminAlerts.isEmpty()) {
            System.out.println("No alerts.");
        } else {
            for (String alert : adminAlerts) {
                System.out.println(alert);
            }
        }
    }

    // Admin method to register a new bus
    public void registerBus(String numberPlate, int totalSeats, String start, String destination, String startTime, double fare, String busName) {
        if (totalSeats > 50) {
            System.out.println("Maximum 50 seats allowed.");
            return;
        }
        for (Bus bus : buses) {
            if (bus.getNumberPlate().equals(numberPlate)) {
                System.out.println("Bus number plate already exists.");
                return;
            }
        }
        Bus bus = new Bus(numberPlate, totalSeats, start, destination, startTime, fare, busName);
        buses.add(bus);
        sendAdminAlert("New bus registered: " + busName + " (" + numberPlate + ")");
        saveData();
        System.out.println("Bus registered successfully.");
    }

    // Admin method to remove a customer by mobile number
    public void adminRemoveCustomer(String mobile) {
        if (customers.remove(mobile) != null) {
            saveData();
            System.out.println("Customer removed successfully.");
        } else {
            System.out.println("Customer not found.");
        }
    }

    // Admin method to remove a bus by number plate
    public void adminRemoveBus(String numberPlate) {
        Bus bus = findBusByNumberPlate(numberPlate);
        if (bus != null) {
            buses.remove(bus);
            saveData();
            System.out.println("Bus removed successfully.");
        } else {
            System.out.println("Bus not found.");
        }
    }

    // Checks for buses with low seat availability and alerts admin
    public void checkLowAvailability() {
        boolean found = false;
        for (Bus bus : buses) {
            if (bus.getAvailableSeats() < 5) {
                sendAdminAlert("Low availability on bus " + bus.getBusName() + " (" + bus.getNumberPlate() + "): " + bus.getAvailableSeats() + " seats left.");
                found = true;
            }
        }
        if (!found) {
            System.out.println("No buses with low availability.");
        } else {
            System.out.println("Alerts checked.");
        }
    }

    // Processes seat change requests from waiting lists
    public void processSeatChange() {
        for (Bus bus : buses) {
            bus.processNextWaitingRequest();
        }
        saveData();
        System.out.println("Waiting list processed.");
    }

    // Sends notification to a customer
    public void sendNotification(String mobile, String message) {
        Customer customer = customers.get(mobile);
        if (customer != null) {
            customer.addNotification(message);
        }
    }

    // Adds an alert message to the admin list
    public void sendAdminAlert(String message) {
        adminAlerts.add(message);
    }

    // Finds a bus by name
    private Bus findBusByName(String busName) {
        for (Bus bus : buses) {
            if (bus.getBusName().equalsIgnoreCase(busName)) {
                return bus;
            }
        }
        return null;
    }

    // Finds a bus by number plate
    private Bus findBusByNumberPlate(String numberPlate) {
        for (Bus bus : buses) {
            if (bus.getNumberPlate().equals(numberPlate)) {
                return bus;
            }
        }
        return null;
    }

    // Saves customer, bus, and alert data to files
    public void saveData() {
        try (ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream("customers.dat"))) {
            oos.writeObject(customers);
        } catch (IOException e) {
            System.out.println("Error saving customer data: " + e.getMessage());
        }

        try (ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream("buses.dat"))) {
            oos.writeObject(buses);
        } catch (IOException e) {
            System.out.println("Error saving bus data: " + e.getMessage());
        }

        try (ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream("alerts.dat"))) {
            oos.writeObject(adminAlerts);
        } catch (IOException e) {
            System.out.println("Error saving alerts: " + e.getMessage());
        }
    }

    // Loads customer, bus, and alert data from files
    @SuppressWarnings("unchecked")
    public void loadData() {
        try (ObjectInputStream ois = new ObjectInputStream(new FileInputStream("customers.dat"))) {
            customers = (HashMap<String, Customer>) ois.readObject();
        } catch (FileNotFoundException e) {
            customers = new HashMap<>();
        } catch (IOException | ClassNotFoundException e) {
            System.out.println("Error loading customer data: " + e.getMessage());
        }

        try (ObjectInputStream ois = new ObjectInputStream(new FileInputStream("buses.dat"))) {
            buses = (List<Bus>) ois.readObject();
        } catch (FileNotFoundException e) {
            buses = new ArrayList<>();
        } catch (IOException | ClassNotFoundException e) {
            System.out.println("Error loading bus data: " + e.getMessage());
        }

        try (ObjectInputStream ois = new ObjectInputStream(new FileInputStream("alerts.dat"))) {
            adminAlerts = (List<String>) ois.readObject();
        } catch (FileNotFoundException e) {
            adminAlerts = new ArrayList<>();
        } catch (IOException | ClassNotFoundException e) {
            System.out.println("Error loading alerts: " + e.getMessage());
        }
    }
}
