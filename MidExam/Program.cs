using System;
abstract class User
{
    protected int userId { get; set; }
    public string username { get; set; }
    protected uint phoneNo { get; set; }

    public User() { }
    public User( string user, uint phone)
    {
        this.username = user;
        this.phoneNo = phone;
    }

    abstract public void register();

    public void login()
    {
        Console.WriteLine("Enter your username : ");
        string us=Console.ReadLine();
        Console.WriteLine("Enter your phoneNo : ");
        int phone=int.Parse(Console.ReadLine());

        if(us==username && phone==phoneNo)
        {
            Console.WriteLine("Invalid username or phone no !!Exiting...");
            return;
        }
    }
    public void displayProfile()
    {
        Console.WriteLine("*** Your Profile ***");
        Console.WriteLine($"Your username : {username} ");
        Console.WriteLine($"Your phone no : {phoneNo}  ");
    }
}

class Rider : User 
{

    string location;
    string destiination;
    public List<Trip> RideHistory= new List<Trip>();

    public Rider() { }
    public Rider(string user,uint phone) : base(user, phone) { }
    public override void register()
    {
        Console.WriteLine("Enter your username : ");
        username = Console.ReadLine();
        do
        {
            Console.WriteLine("Enter a 11_digit phone number : ");
            phoneNo = uint.Parse(Console.ReadLine());
        } while (phoneNo.ToString().Length > 11);
        Console.WriteLine($"User {username} registered successfully as a Rider!");
    }

    public void AddTripToRideHistory(Trip trip)
    {
        RideHistory.Add(trip);
    }
    public void DisplayRideHistory()
    {
        foreach(var ride in RideHistory)
        {
            Console.WriteLine($"- Start point : {ride.startLocation} , Destination : {ride.destination}, Fare : {ride.fare}");
        }
    }
    public void requestRide()
    {

    }

}

class Driver : User
{
    string driverId;
    string vehicleDetails;
    public List<Trip> TripHistory = new List<Trip>();

    public Driver() { }
    public Driver(string user, uint phone, string v_details) : base(user, phone) {
    
        vehicleDetails = v_details;
    }
    
    public void AddtoTripHistory(Trip ride)
    {
        TripHistory.Add(ride);
    }
    public void DisplayTripHistory()
    {
        foreach (var ride in TripHistory)
        {
            Console.WriteLine($"- Start point : {ride.startLocation} , Destination : {ride.destination},Rider : {ride.name}, Fare : {ride.fare}");
        }
    }
    public override void register()
    {
        Console.WriteLine("Enter your username : ");
        username = Console.ReadLine();
        do
        {
            Console.WriteLine("Enter a 11_digit phone number : ");
            phoneNo = uint.Parse(Console.ReadLine());
        } while (phoneNo.ToString().Length > 11);
        Console.WriteLine("Enter your vehicle model : ");
        vehicleDetails = Console.ReadLine();
        Console.WriteLine($"User {username} registered successfully as a Driver!");
    }

}


class Trip
{
    string tripId;
    public string name;
    public Rider rider;
    public Driver driver;
    public string startLocation;
    public string destination;
    public int fare;
    public bool status;

    public Trip() { }
    public Trip( string username,string startLocation, string destination,int fare, bool statustart)
    {
        this.name = username;
        this.startLocation = startLocation;
        this.destination = destination;
        this.fare = fare;
        this.status = status;
    }
}

class RideSharingSystem
{
    public List<Trip> availableTrips = new List<Trip>();
    public List<Rider> registeredRiders = new List<Rider>();
    public List<Driver> registeredDrivers = new List<Driver>();
    public List<Trip> allTrips = new List<Trip>();

    public void AddRider(Rider rider)
    {
        registeredRiders.Add(rider);
    }

    public void AddDriver(Driver driver)
    {
        registeredDrivers.Add(driver);
    }

    public void addAvailableTrip(Trip trip)
    {
        availableTrips.Add(trip);
    }

    public void displayAvaialableRides()
    {
        foreach(var trip in availableTrips)
        {
            Console.WriteLine($"- Start point : {trip.startLocation} , End point : {trip.destination} ,Rider : {trip.name}, Fare : {trip.fare}");
        }
    }

    public void addtoAllTrips(Trip trip)
    {
        allTrips.Add(trip);
    }

    public void displayAllTrips()
    {
        foreach (var trip in allTrips)
        {
            Console.WriteLine($"- Start point : {trip.startLocation} , End point : {trip.destination} , Fare : {trip.fare}");
        }
    }

}





class Program
{
    public static void Main()
    {
        RideSharingSystem rideSystem=new RideSharingSystem();
        Trip ride = new Trip();
        Rider rider = new Rider();
        Driver driver = new Driver();


            Console.WriteLine("Welcome to Ride-Sharing System");
            Console.WriteLine("1.Register as Rider");
            Console.WriteLine("2.Register as Driver");
            Console.WriteLine("3.Request a Ride (Rider)");
            Console.WriteLine("4.Accept a Ride (Driver)");
            Console.WriteLine("5.Complete a Trip");
            Console.WriteLine("6.View Ride History (View Ride History)");
            Console.WriteLine("7.View Trip History (Driver)");
            Console.WriteLine("8.Display All Trips");
            Console.WriteLine("9.Exit");
           
        while (true)
        {
            Console.WriteLine("\nPlease choose an option");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter your username : ");
                        string username = Console.ReadLine();
                        uint phone = 0;
                        do
                        {
                            Console.WriteLine("Enter a 10_digit phone number : ");
                            phone = Convert.ToUInt32(Console.ReadLine());
                        } while (phone.ToString().Length != 10);

                        rideSystem.AddRider(new Rider(username, phone));

                        Console.WriteLine($"User {username} registered successfully as a Rider!");

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter your username : ");
                        string username = Console.ReadLine();
                        uint phone = 0;
                        do
                        {
                            Console.WriteLine("Enter a 10_digit phone number : ");
                            phone = uint.Parse(Console.ReadLine().Trim());
                        } while (phone.ToString().Length != 10);
                        Console.WriteLine("Enter your vehicle model : ");
                        string vehicleDetails = Console.ReadLine();

                        rideSystem.AddDriver(new Driver(username, phone, vehicleDetails));

                        Console.WriteLine($"User {username} registered successfully as a Driver!");

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter your rider username : ");
                        string user=Console.ReadLine();
                        rider = rideSystem.registeredRiders.Find(s => s.username ==user);
                        if (rider != null)
                        {
                            string user1 = rider.username;
                            Console.WriteLine("Enter your current location");
                            string start = Console.ReadLine();

                            Console.WriteLine("Enter your destination point : ");
                            string end = Console.ReadLine();

                            Console.WriteLine("Enter requested fare :");
                            int fare = int.Parse(Console.ReadLine());

                            bool status = true;

                            rideSystem.addAvailableTrip(new Trip(user1,start, end, fare, status));

                            Console.WriteLine($"Ride to {end} is requested successfully !");
                        }
                        else
                        {
                            Console.WriteLine($"User : {user} is not registered as rider!");
                        }

                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter your driver username : ");
                        string user = Console.ReadLine();
                        driver = rideSystem.registeredDrivers.Find(s => s.username == user);
                        if (driver != null)
                        {
                            Console.WriteLine("\nFollowing are the available rides : ");
                            rideSystem.displayAvaialableRides();
                            Console.WriteLine("Enter the destination point of the trip you want to select :");

                            string selectedTrip = Console.ReadLine();
                            ride = rideSystem.availableTrips.Find(s => s.destination == selectedTrip);

                            if (ride != null)
                            {
                                Console.WriteLine("Ride is accepted! Please arrive to the starting location");
                                ride.status = false;
                                rider.AddTripToRideHistory(ride);
                                driver.AddtoTripHistory(ride);
                                rideSystem.addtoAllTrips(ride);

                            }
                            else
                            {
                                Console.WriteLine("Ride not found!");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"User : {user} is not registered as driver!");
                        }

                        break;
                    }
                case 5:
                    {
                        if (ride.status == false)
                        {
                            Console.WriteLine($"Ride to {ride.destination} is completed with fare Rs {ride.fare}");

                        }
                        else
                        {
                            Console.WriteLine("Unfortunately ride could not be completed!");
                        }

                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Enter your rider username : ");
                        string user = Console.ReadLine();
                        rider = rideSystem.registeredRiders.Find(s => s.username == user);
                        if (rider != null)
                        {
                            Console.WriteLine("\n Ride History is as follows : ");
                            rider.DisplayRideHistory();
                        }
                        else
                        {
                            Console.WriteLine($"User {user} is not registered as rider !");
                        }
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Enter your driver username : ");
                        string user = Console.ReadLine();
                        driver = rideSystem.registeredDrivers.Find(s => s.username == user);
                        if (driver != null)
                        {
                            Console.WriteLine("\n Trip History is as follows : ");
                            driver.DisplayTripHistory();
                        }
                        else
                        {
                            Console.WriteLine($"User : {user} is not registered as driver!");
                        }
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("\n List of all trips is as follows : ");
                        rideSystem.displayAllTrips();

                        break;
                    }
                case 9:
                    {
                        return;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice entered!");
                        break;
                    }
            }
    }   }
}

