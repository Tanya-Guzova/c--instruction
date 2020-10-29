using System;

namespace _2_3_rectangle_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "y";
            while (choice.Equals("y")){
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            Console.WriteLine("Enter length: ");
            double length = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            double width = Double.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (length * width));
            Console.WriteLine("Perimeter:: " + ((length * 2) + (width * 2)));
            Console.WriteLine("Continue: (y/n)");
            choice = Console.ReadLine();
            }
            Console.WriteLine("Bye!");
        }
    }
}
