using System;
using System.Collections.Generic;
using System.Text;

namespace product_manager.Utility
{
    class MyConsole
    {
		// get an integer from user
		// use exception handling to check input
		public static int GetInt(String prompt)
		{
			int nbr = 0;
			while (true)
			{
				try
				{
					Console.WriteLine(prompt);
					nbr = int.Parse(Console.ReadLine());
					break;
				}
				catch (Exception)
				{
					Console.WriteLine("Error!  Invalid integer.  Try again.\n");
					Console.ReadLine();
					continue;
				}
			}
			return nbr;
		}

		public static int GetIntWithinRange(String prompt, int min, int max)
		{
			int nbr = 0;
			Boolean isValid = false;

			while (!isValid)
			{
				nbr = GetInt(prompt);
				if (nbr < min)
				{
					Console.WriteLine("Error!  Number must be >= " + min + ".");
				}
				else if (nbr > max)
				{
					Console.WriteLine("Error!  Number must be <= " + max + ".");
				}
				else
				{
					isValid = true;

				}
			}

			return nbr;

		}
		// get a required string which is only one of 2 valid choices (s1, s2)
		public static String GetChoiceString(String prompt,
											  String s1, String s2)
		{
			String str = "";
			Boolean isValid = false;
			while (!isValid)
			{
				str = GetRequiredString(prompt);
				if (!str.Equals(s1) && !str.Equals(s2))
				{
					// entry is invalid
					Console.WriteLine("Invalid Entry:  Expected values are '"
							 			+ s1 + "' or '" + s2 + "'.");
				}
				else
				{
					isValid = true;
				}
			}

			return str;
		}

		public static String GetRequiredString(String prompt)
		{
			String str = "";
			Boolean isValid = false;
			while (!isValid)
			{
				Console.WriteLine(prompt);
				str = Console.ReadLine();
				if (str.Equals(""))
				{
					Console.WriteLine("Invalid Entry.. this field is required!");
				}
				else
				{
					isValid = true;
				}
			}

			return str;
		}
		//get double
		public static double GetDouble(String prompt)
		{
			double d = 0;
			Boolean isValid = false;
			while (!isValid)
			{
				Console.Write(prompt);
				try 
				{
					d = Double.Parse(Console.ReadLine());
					isValid = true;
				}
				catch(Exception)
				{
					Console.WriteLine("Error! Invalid number. Try again.");
				}
			}
			return d;
		}
	}
}
