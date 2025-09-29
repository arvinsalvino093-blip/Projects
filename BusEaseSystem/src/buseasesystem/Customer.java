/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package buseasesystem;

/**
 *
 * @author User
 */
import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

/**
 * Represents a customer in the BusEaseSystem, storing their personal details,
 * reservations, and notifications. Implements Serializable for persistent
 * storage in customers.dat.
 *
 * @author User
 */
public class Customer implements Serializable {
    // Serial version UID for serialization compatibility
    private static final long serialVersionUID = 1L;

    // Customer's full name
    private String name;
    // Unique mobile number used as the key in the system's customer HashMap
    private String mobile;
    // Customer's email address
    private String email;
    // Customer's city of residence
    private String city;
    // Customer's age
    private int age;
    // Customer's password (stored in plain text for simplicity)
    private String password;
    // List of reservations made by the customer
    private List<Reservation> reservations;
    // List of notifications for the customer (e.g., booking confirmations)
    private List<String> notifications;

    /**
     * Constructs a new Customer with the specified details and initializes
     * their reservations and notifications lists.
     *
     * @param name     Customer's full name
     * @param mobile   Customer's mobile number (unique identifier)
     * @param email    Customer's email address
     * @param city     Customer's city
     * @param age      Customer's age
     * @param password Customer's password
     */
    public Customer(String name, String mobile, String email, String city, int age, String password) {
        this.name = name;
        this.mobile = mobile;
        this.email = email;
        this.city = city;
        this.age = age;
        this.password = password;
        // Initialize reservations list
        this.reservations = new ArrayList<>();
        // Initialize notifications list
        this.notifications = new ArrayList<>();
    }

    /**
     * Adds a reservation to the customer's list.
     *
     * @param reservation The reservation to add
     */
    public void addReservation(Reservation reservation) {
        // Add the reservation to the customer's reservations list
        reservations.add(reservation);
    }

    /**
     * Adds a notification message to the customer's notifications list.
     *
     * @param message The notification message to add
     */
    public void addNotification(String message) {
        // Add the message to the notifications list
        notifications.add(message);
    }

    /**
     * Displays all notifications for the customer and clears the list afterward.
     */
    public void showNotifications() {
        // Print header with customer's name
        System.out.println("Notifications for " + name + ":");
        if (notifications.isEmpty()) {
            // Inform user if no notifications exist
            System.out.println("No notifications.");
        } else {
            // Print each notification
            for (String notification : notifications) {
                System.out.println(notification);
            }
            // Clear notifications after displaying
            notifications.clear();
        }
    }

    /**
     * Displays the customer's personal details.
     */
    public void viewDetails() {
        // Print customer details
        System.out.println("Customer Details:");
        System.out.println("Name: " + name);
        System.out.println("Mobile: " + mobile);
        System.out.println("Email: " + email);
        System.out.println("City: " + city);
        System.out.println("Age: " + age);
    }

    /**
     * Gets the customer's name.
     *
     * @return The customer's name
     */
    public String getName() {
        return name;
    }

    /**
     * Gets the customer's mobile number.
     *
     * @return The customer's mobile number
     */
    public String getMobile() {
        return mobile;
    }

    /**
     * Gets the customer's email address.
     *
     * @return The customer's email
     */
    public String getEmail() {
        return email;
    }

    /**
     * Gets the customer's password.
     *
     * @return The customer's password
     */
    public String getPassword() {
        return password;
    }

    /**
     * Gets the list of reservations made by the customer.
     *
     * @return The list of reservations
     */
    public List<Reservation> getReservations() {
        return reservations;
    }
}