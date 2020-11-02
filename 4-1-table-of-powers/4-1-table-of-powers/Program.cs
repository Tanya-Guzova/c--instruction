using System;

namespace _4_1_table_of_powers
{
    class Program
    {
        static void Main(string[] args)
        {

			Console.WriteLine("Welcome to the Square and Cube Table");
			String choice = "y";


			while (choice.Equals("y"))
			{
				Console.WriteLine("Enter an integer: ");
				int intNumber = Int32.Parse(Console.ReadLine());
				Console.WriteLine("==================");
				Console.WriteLine("Number	Squared	  Cubed");


				for (int i = 1; i <= intNumber; i++)
				{
					int squared = i * i;
					int cubed = i * i * i;
					Console.WriteLine(i + "\t" + squared + "\t " + cubed + "\n");
				}
				Console.WriteLine("Continue? (y/n): ");
				choice = Console.ReadLine();
			}

			Console.WriteLine
				("Bye!");
		}
	
