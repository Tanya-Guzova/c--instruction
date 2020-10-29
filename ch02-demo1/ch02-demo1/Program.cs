using System;

namespace ch02_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //declare some string
            string str1 = "Elvis";
            String str2 = "Presley";

            //using the var identifier
            var fullName = str1 + " " + str2;

            //var number - cannot declare like that as the system doesn't know what data type is implied until yo uassign a value
            var number = "0";
            double d1;
            double d2;

            //while lopp, prompt for input, sum then prompt continue?
            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter a decimal value: ");
                d1 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter a decimal value: ");
                d2 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Sum is: " + (d1 + d2));
                Console.Write("Continue? ");
                choice = Console.ReadLine();
                Console.WriteLine();

            }

            //do a simple if statement
            Console.WriteLine("Stoplight color: (r,y,g)");
            String lightColor = Console.ReadLine();
            if (lightColor.Equals("r"))
            {
                Console.WriteLine("Stop!!!");
            }
            else if (lightColor.Equals("y"))
            {
                Console.WriteLine("Slow down!");
            }
            else if (lightColor.Equals("g"))
            {
                Console.WriteLine("Go!");
            }
            else
            {
                Console.WriteLine("Invalid Color");
            }
            Console.WriteLine("Bye!");
        }
    }
}
