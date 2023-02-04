using ExeptionReservation.Entities;
using ExeptionReservation3.Entities.Exceptions;
using System;

internal class Program {
    private static void Main(string[] args) {
        try {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Check-in date(dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date(dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;


            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation: ");

            Console.Write("Check-in date(dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date(dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDates(checkIn, checkOut);

            Console.WriteLine("Reservation: " + reservation);
        }
        catch (DomainException error) {
            Console.WriteLine("Error in reservation: " + error.Message);
        }
        catch (FormatException error) {
            Console.WriteLine("Format error: " + error.Message);
        }
        catch(Exception error) {
            Console.WriteLine("Unexpected error: " + error.Message);
        }
    }

}

