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

/**
 * Represents a seat request for a specific seat on a bus in the BusEaseSystem,
 * used when a requested seat is unavailable and added to a waiting list.
 * Implements Serializable for persistent storage in buses.dat.
 *
 * @author User
 */
public class SeatRequest implements Serializable {
    // Serial version UID for serialization compatibility
    private static final long serialVersionUID = 1L;

    // The mobile number of the customer making the seat request
    private String mobile;
    // The desired seat number (1-based index)
    private int seatNumber;

    /**
     * Constructs a new SeatRequest with the specified customer mobile number and seat number.
     *
     * @param mobile     The customer's mobile number
     * @param seatNumber The desired seat number
     */
    public SeatRequest(String mobile, int seatNumber) {
        this.mobile = mobile;
        this.seatNumber = seatNumber;
    }

    /**
     * Gets the mobile number of the customer making the seat request.
     *
     * @return The customer's mobile number
     */
    public String getMobile() {
        return mobile;
    }

    /**
     * Gets the desired seat number for the request.
     *
     * @return The seat number
     */
    public int getSeatNumber() {
        return seatNumber;
    }
}