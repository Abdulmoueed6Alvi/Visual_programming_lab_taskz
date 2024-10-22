using System;
using System.Collections.Generic;

namespace _233536_LAB_5_TASK_2
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
    }

    public class RetailCustomer : Customer
    {
        public string CreditCardType { get; set; }
        public string CreditCardNo { get; set; }
    }

    public class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; }
        public int FrequentFlyerPts { get; set; }
        public string BillingAccountNo { get; set; }
    }

    public class Reservation
    {
        public int ReservationNo { get; set; }
        public DateTime Date { get; set; }

        public Customer Customer { get; set; }
        public List<Seat> Seats { get; set; } = new List<Seat>();
    }

    public class Flight
    {
        public int FlightId { get; set; }
        public DateTime Date { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int SeatingCapacity { get; set; }

        public List<Seat> Seats { get; set; } = new List<Seat>();
    }

    public class Seat
    {
        public int RowNo { get; set; }
        public int SeatNo { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }

        public Flight Flight { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RetailCustomer retailCustomer = new RetailCustomer
            {
                CustomerId = 1,
                FirstName = "John",
                LastName = "Doe",
                CreditCardType = "Visa",
                CreditCardNo = "1234-5678-9012-3456"
            };

            CorporateCustomer corporateCustomer = new CorporateCustomer
            {
                CustomerId = 2,
                FirstName = "Jane",
                LastName = "Smith",
                CompanyName = "Tech Solutions",
                FrequentFlyerPts = 1500,
                BillingAccountNo = "ABC123"
            };

            Flight flight = new Flight
            {
                FlightId = 1001,
                Date = DateTime.Now,
                Origin = "New York",
                Destination = "Los Angeles",
                DepartureTime = DateTime.Now.AddHours(2),
                ArrivalTime = DateTime.Now.AddHours(5),
                SeatingCapacity = 150
            };

            Reservation reservation = new Reservation
            {
                ReservationNo = 3001,
                Date = DateTime.Now,
                Customer = retailCustomer
            };

            reservation.Seats.Add(new Seat { RowNo = 1, SeatNo = 1, Price = 200m, Status = "Reserved", Flight = flight });
            reservation.Seats.Add(new Seat { RowNo = 1, SeatNo = 2, Price = 200m, Status = "Reserved", Flight = flight });

            retailCustomer.Reservations.Add(reservation);

            Console.WriteLine($"Customer: {retailCustomer.FirstName} {retailCustomer.LastName}");
            Console.WriteLine($"Credit Card: {retailCustomer.CreditCardType} {retailCustomer.CreditCardNo}");
            Console.WriteLine($"Reservation No: {reservation.ReservationNo} on {reservation.Date}");
            Console.WriteLine($"Flight from {flight.Origin} to {flight.Destination} at {flight.DepartureTime}");
            Console.WriteLine("Reserved Seats:");
            foreach (var seat in reservation.Seats)
            {
                Console.WriteLine($"Row: {seat.RowNo}, Seat: {seat.SeatNo}, Price: {seat.Price}, Status: {seat.Status}");
            }

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
