using System;

namespace _3_1_temperature_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Welcome to the Travel Time Calculator");
			double miles;
			double milesPerHour;
			int hours;
			int minutes;
			String choice = "y";
			
			while (choice.Equals("y"))
			{
				// prompting user to enter an input
				Console.WriteLine("Enter miles: ");
				miles = Double.Parse(Console.ReadLine());
				Console.WriteLine("Enter miles per hour: ");
				milesPerHour = Double.Parse(Console.ReadLine());

				// business logic
				hours = (int)(miles / milesPerHour);
				double hoursDecimal = Math.Round(((miles % milesPerHour) / milesPerHour),2);
				minutes = (int)(hoursDecimal * 60);
				// output
				Console.WriteLine("Estimated travel time: ");
				Console.WriteLine("-------------------------");
				Console.WriteLine("Hours: " + hours);
				Console.WriteLine("Minutes: " + minutes);
				Console.WriteLine();
				Console.WriteLine("Continue? (y/n): ");
				choice = Console.ReadLine();
			}
			// goodbye message
			Console.WriteLine("Bye!");

		}

	}
}
