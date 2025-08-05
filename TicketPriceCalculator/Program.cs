using System;

namespace TicketPriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your age (or type 'exit' to finish): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Thank you for using the Ticket Price Calculator!");
                    break;
                }

                try
                {
                    int age = int.Parse(input);

                    if (age < 0)
                    {
                        Console.WriteLine("Age cannot be negative. Please try again.");
                    }
                    else
                    {
                        int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;
                        Console.WriteLine($"Ticket Price: GHC{ticketPrice}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or type 'exit' to finish.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

                Console.WriteLine();
            }
        }
    }
}
