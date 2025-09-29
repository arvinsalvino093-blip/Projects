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
import java.util.*;

/**
 * Represents a bus in the BusEaseSystem, managing its details, seat availability,
 * /reservations, and waiting list for seat requests. Implements Serializable for
 * persistent storage in buses.dat.
 *
 * @author User
 */
public class Bus implements Serializable {
    // Serial version UID for serialization compatibility
    private static final long serialVersionUID = 1L;

    // Unique identifier for the bus (e.g., number plate like "ABC123")
    private String numberPlate;
    // Total number of seats on the bus (max 50)
    private int totalSeats;
    // Starting location of the bus route (e.g., "Colombo")
    private String startingPoint;
    // Destination of the bus route (e.g., "Kandy")
    private String endingPoint;
    // Departure time in HH:MM format (e.g., "08:00")
    private String startTime;
    // Ticket fare in LKR (e.g., 500.0)
    private double fare;
    // Friendly name of the bus (e.g., "Express1")
    private String busName;
    // Array tracking seat availability (true = booked, false = available)
    private boolean[] seats;
    // List of reservations for this bus
    private List<Reservation> reservations;
    // Queue of seat requests for unavailable seats
    private Queue<SeatRequest> waitingList;

    /**
     * Constructs a new Bus with the specified details and initializes its seat
     * management data structures.
     *
     * @param numberPlate   Unique identifier for the bus
     * @param totalSeats    Number of seats on the bus (max 50)
     * @param startingPoint Starting location of the route
     * @param endingPoint   Destination of the route
     * @param startTime     Departure time (HH:MM)
     * @param fare          Ticket fare in LKR
     * @param busName       Friendly name of the bus
     */
    public Bus(String numberPlate, int totalSeats, String startingPoint, String endingPoint, String startTime, double fare, String busName) {
        this.numberPlate = numberPlate;
        this.totalSeats = totalSeats;
        this.startingPoint = startingPoint;
        this.endingPoint = endingPoint;
        this.startTime = startTime;
        this.fare = fare;
        this.busName = busName;
        // Initialize seats array with all seats available (false)
        this.seats = new boolean[totalSeats];
        // Initialize reservations list
        this.reservations = new ArrayList<>();
        // Initialize waiting list as a LinkedList for queue operations
        this.waitingList = new LinkedList<>();
    }

    /**
     * Books a seat for a customer if available.
     *
     * @param seatNumber Seat number to book (1-based index)
     * @param mobile     Customer's mobile number
     * @return true if the seat was booked successfully, false otherwise
     */
    public boolean bookSeat(int seatNumber, String mobile) {
        // Validate seat number and availability
        if (seatNumber < 1 || seatNumber > totalSeats || seats[seatNumber - 1]) {
            return false;
        }
        // Mark seat as booked
        seats[seatNumber - 1] = true;
        // Add reservation to the list
        reservations.add(new Reservation(numberPlate, seatNumber));
        return true;
    }

    /**
     * Cancels a seat reservation and notifies adjacent seat holders.
     *
     * @param seatNumber Seat number to cancel (1-based index)
     */
    public void cancelSeat(int seatNumber) {
        // Validate seat number and ensure it is booked
        if (seatNumber < 1 || seatNumber > totalSeats || !seats[seatNumber - 1]) {
            return;
        }
        // Mark seat as available
        seats[seatNumber - 1] = false;
        // Remove the reservation from the list
        reservations.removeIf(reservation -> reservation.getSeatNumber() == seatNumber);
        // Notify adjacent seat holders (placeholder for future implementation)
        notifyAdjacentSeats(seatNumber);
    }

    /**
     * Adds a seat request to the waiting list when a seat is unavailable.
     *
     * @param request The SeatRequest containing customer mobile and desired seat
     */
    public void addSeatRequest(SeatRequest request) {
        // Add request to the waiting list queue
        waitingList.add(request);
    }

    /**
     * Processes the next seat request in the waiting list, booking it if possible.
     */
    public void processNextWaitingRequest() {
        // Continue processing while there are requests and seats are available
        while (!waitingList.isEmpty()) {
            SeatRequest request = waitingList.peek();
            // Attempt to book the requested seat
            if (bookSeat(request.getSeatNumber(), request.getMobile())) {
                // Remove the processed request from the queue
                waitingList.poll();
                // Notification handled by BusEaseSystem
            } else {
                // Stop if the seat is unavailable
                break;
            }
        }
    }

    /**
     * Notifies customers in adjacent seats when a seat is cancelled (placeholder).
     *
     * @param seatNumber The cancelled seat number
     */
    private void notifyAdjacentSeats(int seatNumber) {
        // Define adjacent seat numbers (left and right)
        int[] adjacentSeats = {seatNumber - 1, seatNumber + 1};
        // Check existing reservations for adjacent seats
        for (Reservation reservation : reservations) {
            for (int adjSeat : adjacentSeats) {
                // Ensure adjacent seat is valid and reserved
                if (reservation.getSeatNumber() == adjSeat && adjSeat > 0 && adjSeat <= totalSeats) {
                    // Notification handled by BusEaseSystem (future implementation)
                }
            }
        }
    }

    /**
     * Gets the bus's number plate.
     *
     * @return The bus number plate
     */
    public String getNumberPlate() {
        return numberPlate;
    }

    /**
     * Gets the starting point of the bus route.
     *
     * @return The starting point
     */
    public String getStartingPoint() {
        return startingPoint;
    }

    /**
     * Gets the destination of the bus route.
     *
     * @return The ending point
     */
    public String getEndingPoint() {
        return endingPoint;
    }

    /**
     * Gets the departure time of the bus.
     *
     * @return The start time (HH:MM)
     */
    public String getStartTime() {
        return startTime;
    }

    /**
     * Gets the ticket fare of the bus.
     *
     * @return The fare in LKR
     */
    public double getFare() {
        return fare;
    }

    /**
     * Gets the friendly name of the bus.
     *
     * @return The bus name
     */
    public String getBusName() {
        return busName;
    }

    /**
     * Gets the total number of seats on the bus.
     *
     * @return The total seats
     */
    public int getTotalSeats() {
        return totalSeats;
    }

    /**
     * Calculates the number of available (unbooked) seats.
     *
     * @return The number of available seats
     */
    public int getAvailableSeats() {
        int count = 0;
        // Count unbooked seats (false in seats array)
        for (boolean seat : seats) {
            if (!seat) count++;
        }
        return count;
    }

    /**
     * Gets the list of reservations for this bus.
     *
     * @return The list of reservations
     */
    public List<Reservation> getReservations() {
        return reservations;
    }

    /**
     * Gets the waiting list of seat requests for this bus.
     *
     * @return The queue of seat requests
     */
    public Queue<SeatRequest> getWaitingList() {
        return waitingList;
    }
}