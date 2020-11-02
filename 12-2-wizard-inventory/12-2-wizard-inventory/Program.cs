using System;
using System.Collections.Generic;

namespace _12_2_wizard_inventory
{
    class Program
    {
        private static List<string> items = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Wizard Inventory App!");
			initializeItems();

			String command = "";
			while (!command.Equals("exit"))
			{
				displayMenu();
				command = GetRequiredString("Command:  ");
				switch (command)
				{
					case "show":
						// show / list all items
						for (int i = 0; i < items.Count; i++)
						{
                            Console.WriteLine(i + 1 + ". " + items[i]);
						}
                        Console.WriteLine();
						break;
					case "grab":
						// grab / add item, but max of 4
						if (items.Count >= 4)
						{
                            Console.WriteLine("You can't carry anymore items.  Please drop one first.");
						}
						else
						{
							String name = GetRequiredString("Name: ");
							items.Add(name);
                            Console.WriteLine(name + " was added.");
						}
						break;
					case "edit":
						// edit - prompt for item # (not the index!!!)
						String item = findItem();
						int idx = items.IndexOf(item);
						String newName = GetRequiredString("Updated name: ");
						items[idx]= newName;
                        Console.WriteLine("Item #" + (idx + 1) + " was updated.");
						break;
					case "drop":
						// drop
						int itemNbr = GetIntWithinRange("Number: ", 1, items.Count);
						String itemRemoved = items[itemNbr - 1];
						items.Remove(itemRemoved);
                        Console.WriteLine(itemRemoved + " was removed.");
						break;
					case "exit":
						// exit
						break;
				}

			}

            Console.WriteLine("Bye");

		}

		private static void initializeItems()
		{
			items.Add("wooden staff");
			items.Add("wizard hat");
			items.Add("cloth shoes");
		}

		private static void displayMenu()
		{
			String menu = "COMMAND MENU:\n" + "show - Show all items\n" + "grab - Grab (add) an item\n"
					+ "edit - Edit an item\n" + "drop - Drop an item\n" + "exit - Exit app\n";
            Console.WriteLine(menu);
		}

		private static String findItem()
		{
			int itemNbr = GetIntWithinRange("Number: ", 1, items.Count);
			String item = items[itemNbr - 1];
			return item;
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
	}
}
