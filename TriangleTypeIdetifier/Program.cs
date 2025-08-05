using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeIdetifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter three triangle sides or type 'exit' to quit.");

                Console.Write("Enter side 1: ");
                string input1 = Console.ReadLine();
                if (input1.ToLower() == "exit") break;

                Console.Write("Enter side 2: ");
                string input2 = Console.ReadLine();
                if (input2.ToLower() == "exit") break;

                Console.Write("Enter side 3: ");
                string input3 = Console.ReadLine();
                if (input3.ToLower() == "exit") break;

                bool valid1 = int.TryParse(input1, out int side1);
                bool valid2 = int.TryParse(input2, out int side2);
                bool valid3 = int.TryParse(input3, out int side3);

                if (valid1 && valid2 && valid3 && side1 > 0 && side2 > 0 && side3 > 0)
                {
                    if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
                    {
                        if (side1 == side2 && side2 == side3)
                            Console.WriteLine("Triangle Type: Equilateral");
                        else if (side1 == side2 || side2 == side3 || side1 == side3)
                            Console.WriteLine("Triangle Type: Isosceles");
                        else
                            Console.WriteLine("Triangle Type: Scalene");
                    }
                    else
                    {
                        Console.WriteLine("The values entered cannot form a triangle.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter positive numbers.");
                }

                Console.WriteLine(); 
            }

        }
    }
}
