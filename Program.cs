using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            double Radius;
            string UserEnteredRadiusValue;
            char RetryAgain;
            int NoOfCircleObjects = 0;
            Console.WriteLine("Welcome to the Circle Tester");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Enter radius: ");
                UserEnteredRadiusValue = Console.ReadLine();

                if (double.TryParse(UserEnteredRadiusValue, out Radius))
                {
                    Circle circle = new Circle(Radius);
                    NoOfCircleObjects++;
                    Console.WriteLine("Circumference: " + circle.CalculateFormattedCircumference() + " Area: " + circle.CalculateFormattedArea());

                    Console.Write("Continue? (y/n): ");
                    RetryAgain = Console.ReadKey(false).KeyChar;
                    if ((RetryAgain == 'y') || (RetryAgain == 'Y'))
                    {
                        continue;
                    }
                    else if ((RetryAgain == 'n') || (RetryAgain == 'N'))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Goodbye. You created " + NoOfCircleObjects + " Circle object(s).");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again");
                    continue;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program has exited. Press ENTER to close.");
            Console.ReadLine();
        }
    }
}
