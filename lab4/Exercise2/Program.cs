using System;
using System.Collections.Generic;

public class Customer
{
    public string CustomerID { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public Customer() { }

    public Customer(string customerID, string lastName, string firstName)
    {
        CustomerID = customerID;
        LastName = lastName;
        FirstName = firstName;
    }
}

public class RetailCustomer : Customer
{
    public string CreditCardType { get; set; }
    public string CreditCardNo { get; set; }

    public RetailCustomer(string customerID, string lastName, string firstName, string creditCardType, string creditCardNo)
        : base(customerID, lastName, firstName)
    {
        CreditCardType = creditCardType;
        CreditCardNo = creditCardNo;
    }
}

public class CorporateCustomer : Customer
{
    public string CompanyName { get; set; }
    public string FrequentFlyerPts { get; set; }
    public string BillingAccountNo { get; set; }

    public CorporateCustomer(string customerID, string lastName, string firstName, string companyName, string frequentFlyerPts, string billingAccountNo)
        : base(customerID, lastName, firstName)
    {
        CompanyName = companyName;
        FrequentFlyerPts = frequentFlyerPts;
        BillingAccountNo = billingAccountNo;
    }
}

public class Reservation
{
    public string ReservationNo { get; set; }
    public DateTime Date { get; set; }
    public Customer Customer { get; set; }

    public Reservation(string reservationNo, DateTime date, Customer customer)
    {
        ReservationNo = reservationNo;
        Date = date;
        Customer = customer;
    }
}

public class Seat
{
    public string SeatNo { get; set; }
    public double Price { get; set; }
    public string Status { get; set; }

    public Seat(string seatNo, double price, string status)
    {
        SeatNo = seatNo;
        Price = price;
        Status = status;
    }
}

public class Flight
{
    public string FlightID { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public int SeatingCapacity { get; set; }
    public List<Seat> Seats { get; set; }

    public Flight(string flightID, string destination, DateTime departureTime, DateTime arrivalTime, int seatingCapacity)
    {
        FlightID = flightID;
        Destination = destination;
        DepartureTime = departureTime;
        ArrivalTime = arrivalTime;
        SeatingCapacity = seatingCapacity;
        Seats = new List<Seat>();
    }

    public void ReserveSeat(Seat seat, Customer customer)
    {
        if (seat.Status == "Available")
        {
            seat.Status = "Reserved";
            Console.WriteLine($"{customer.FirstName} reserved seat {seat.SeatNo} on flight {FlightID}");
        }
        else
        {
            Console.WriteLine($"Seat {seat.SeatNo} is already reserved.");
        }
    }
}

class Program
{
    static void Main()
    {
        Flight flight = new Flight("FL123", "New York", DateTime.Now.AddHours(3), DateTime.Now.AddHours(6), 150);

        Seat seat1 = new Seat("A1", 150.00, "Available");
        Seat seat2 = new Seat("A2", 150.00, "Available");
        flight.Seats.Add(seat1);
        flight.Seats.Add(seat2);

        RetailCustomer customer1 = new RetailCustomer("C001", "Qazi", "Eman", "Visa", "1234-5678-9012");

        Reservation reservation = new Reservation("R001", DateTime.Now, customer1);

        flight.ReserveSeat(seat1, customer1);
    }
}
