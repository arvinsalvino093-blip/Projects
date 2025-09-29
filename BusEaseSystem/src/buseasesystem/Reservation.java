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
 * Represents a reservation for a specific seat on a bus in the BusEaseSystem.
 * Implements Serializable for persistent storage in customers.dat and buses.dat.
 *
 * @author User
 */
public class Reservation implements Serializable {
    // Serial version UID for serialization compatibility
    private static final long serialVersionUID = 1L;

    // The number plate of the bus associated with this reservation
    private String busNumberPlate;
    // The seat number reserved (1-based index)
    private int seatNumber;

    /**
     * Constructs a new Reservation with the specified bus number plate and seat number.
     *
     * @param busNumberPlate The unique identifier of the bus
     * @param seatNumber     The seat number reserved
     */
    public Reservation(String busNumberPlate, int seatNumber) {
        this.busNumberPlate = busNumberPlate;
        this.seatNumber = seatNumber;
    }

    /**
     * Gets the bus number plate associated with this reservation.
     *
     * @return The bus number plate
     */
    public String getBusNumberPlate() {
        return busNumberPlate;
    }

    /**
     * Gets the seat number associated with this reservation.
     *
     * @return The seat number
     */
    public int getSeatNumber() {
        return seatNumber;
    }
}