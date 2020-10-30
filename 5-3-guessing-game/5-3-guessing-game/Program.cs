using System;

namespace _5_3_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Welcome to the guessing game!!!");
			Console.WriteLine("+++++++++++++++++++++++++++++++");
			Console.WriteLine();
			String choice = "y";
			Random rand = new Random();

			while (choice.Equals("y"))
			{	//*while loop starts
				// Start a game - generate random number (theNumber)
				int theNumber = rand.Next(1, 101);
				Console.WriteLine(theNumber);//keep this for testing purposes

				Console.WriteLine("I'm thinking of a number from 1 to 100."
						+ "\nTry to guess it.");
				int count = 0;
				int guess = 0;
				while (guess != theNumber)
				{
					//* 'win' loop starts 'guess == theNumber'???
					guess = getIntWithinRange("Enter Number: ", 1, 100);
					count++;

					// biz logic 
					// - compare guess vs theNumber
					int diff = theNumber - guess;
					// - display the appropriate message: win, tl, th, wtl, wth
					String message = "";
					if (diff > 10)
					{
						message += "Way too low!  Guess again.";
					}
					else if (diff < -10)
					{
						message += "Way too high!  Guess again.";
					}
					else if (diff > 0)
					{
						message += "Too low!  Guess again.";
					}
					else if (diff < 0)
					{
						message += "Too high!  Guess again.";
					}
					else
					{
						// win
						message += "You got it in " + count + " tries!\n";
						if (count <= 3)
						{
							message += "Great work! You're a mathematical wizard!!\n";
						}
						else if (count <= 7)
						{
							message += "Not bad.  You've got some potential.\n";
						}
						else
						{
							message += "What took you so long?  Maybe you should take some lessons.\n";
						}
					}
					Console.WriteLine(message + "\n");
					// - display the 'win' message: in requirements doc
					//* 'win' loop ends
				}
				//* continue loop ends
				Console.ReadLine();
				choice = getChoiceString("Try again? ", "y", "n");
			}
			Console.WriteLine("Bye!");

		}
		// get an integer from user
		// use exception handling to check input
		private static int getInt(String prompt)
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

		private static int getIntWithinRange(String prompt, int min, int max)
		{
			int nbr = 0;
			Boolean isValid = false;

			while (!isValid)
			{
				nbr = getInt(prompt);
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
		private static String getChoiceString(String prompt,
											  String s1, String s2)
		{
			String str = "";
			Boolean isValid = false;
			while (!isValid)
			{
				str = getRequiredString(prompt);
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

		private static String getRequiredString(String prompt)
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
	}
}
