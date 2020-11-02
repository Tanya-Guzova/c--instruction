using System;

namespace _3_1_temperature_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Welcome to the Temperature Converter");
                Console.WriteLine("Enter degrees in Fahrenheit: ");

                double fahrenheite = Double.Parse(Console.ReadLine());
                double celcius = (fahrenheite - 32) * 5 / 9;
                Console.WriteLine("Degrees in Celsius: " + Math.Round(celcius, 2));
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye!");
        }
    }
}
