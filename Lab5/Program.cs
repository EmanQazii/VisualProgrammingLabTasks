using System;

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
    public string CreditCardNo { get; set; }

    public RetailCustomer(string customerID, string lastName, string firstName, string creditCardNo)
        : base(customerID, lastName, firstName)
    {
        CreditCardNo = creditCardNo;
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
    public void DisplaySeatInfo()
    {
        Console.WriteLine($"Seat No: {SeatNo}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Status: {Status}");
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
            Seats[0] = seat;
            Console.WriteLine("Seat Reserved! \n");
            Console.WriteLine("\nReservation Details : \n");
            Console.WriteLine($"{customer.FirstName} reserved seat {seat.SeatNo} on flight {FlightID}");
        }
        else
        {
            Console.WriteLine($"Seat {seat.SeatNo} is already reserved.");
        }
    }

    public void FlightDisplay()
    {

        Console.WriteLine($"Flight ID : {FlightID}\nDestination : {Destination}\nDeparture Time : {DepartureTime}\nArrival Time : {ArrivalTime}\nSeating Capacity : {SeatingCapacity}\n");
    }
}

class Program
{
    static void Main()
    {
        Flight flight1 = new Flight("FL123", "New York", DateTime.Now.AddHours(3), DateTime.Now.AddHours(6), 150);
        Flight flight2 = new Flight("FL456", "London", DateTime.Now.AddHours(10), DateTime.Now.AddHours(18), 200);

        Seat seat1 = new Seat("A1", 150.00, "Available");
        Seat seat2 = new Seat("A2", 150.00, "Available");
        flight1.Seats.Add(seat1);
        flight1.Seats.Add(seat2);

        Console.WriteLine("Enter Customer Details : ");
        string id, f_name, l_name, cardType, cardNo;
        Console.Write("ID: ");
        id = Console.ReadLine();
        Console.Write("First Name: ");
        f_name = Console.ReadLine();
        Console.Write("Last Name: ");
        l_name = Console.ReadLine();
        Console.Write("Card Number: ");
        cardNo = Console.ReadLine();

        RetailCustomer customer1 = new RetailCustomer(id, l_name, f_name,cardNo);

        flight2.Seats.Add(seat1);
        flight2.Seats.Add(seat2);
        Console.WriteLine("\nAvailable Flights : \n");
        Console.WriteLine("Flight 1 : \n");
        flight1.FlightDisplay();
        Console.WriteLine("Flight 2 : \n");
        flight2.FlightDisplay();

 
        bool f1, f2;
        Console.WriteLine("Enter flight number you want to book : ");
        int f_no;
        f_no = Convert.ToInt32(Console.ReadLine());

        if(f_no == 1)
        {
            Console.WriteLine("Avaialable Seats for flight 1 : ");
            Console.WriteLine("Seat # 1 : \n");
            seat1.DisplaySeatInfo();
            Console.WriteLine("Seat # 2 : \n");
            seat2.DisplaySeatInfo();
            int seat_no;
            Console.WriteLine("Enter seat number you want to book : ");
            seat_no = Convert.ToInt32(Console.ReadLine());

            if(seat_no==1)
            {
                flight1.ReserveSeat(seat1, customer1);
            }
            else
            if(seat_no==2)
            {
                flight1.ReserveSeat(seat2, customer1);
            }
        }
        else
        if(f_no == 2)
        {
            Console.WriteLine("Avaialable Seats for flight 1 : ");
            seat1.DisplaySeatInfo();
            seat2.DisplaySeatInfo();
            int seat_no;
            Console.WriteLine("Enter seat number you want to book : ");
            seat_no = Convert.ToInt32(Console.ReadLine());
            if (seat_no == 1)
            {
                flight2.ReserveSeat(seat1, customer1);
            }
            else
            if (seat_no == 2)
            {
                flight2.ReserveSeat(seat2, customer1);
            }
        }


       

        Reservation reservation = new Reservation("R001", DateTime.Now, customer1);

        
    }
}

