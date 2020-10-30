using System;

namespace ch05_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 5 demos!");
        
            int nbr = ParseInt("Enter a whole number: ");
            Console.WriteLine("You entered " + nbr);

            //to use the method, using a different order of params, use their variable names
            PrintOrderDetails(productName: "Light Up Pumpkin", sellerName: "Target", orderNum: 33);

            PrintFavSong("Accidents Will Happen");
        }

        private static int ParseInt(String prompt)
        {
            int n = 0;
            Console.WriteLine(prompt);
            while (true) 
            { 
                try
                {
                    n = int.Parse(Console.ReadLine());
                        break;
                }
                catch (Exception)
                {
                        Console.WriteLine("Enter a valid number");
                }
            }
            return n;
        }
        //demonstrate optional/namedparameters
        private static void PrintOrderDetails(String sellerName, int orderNum, String productName)
        {
            Console.WriteLine("OrderDetails: " + productName + ", on order #  " + orderNum + ", purchased at "
                + sellerName + ".");

        }
        private static void PrintCandyStats(String candyName, int quantity = 0)
        {
            Console.WriteLine("* " + quantity + " pieces of " + candyName);
        }
        //interpolation
        private static void PrintFavSong (String name)
        {
            // Console.WriteLine("My favorite song is " + name + ".");
            Console.WriteLine($"My favorite song is {name}.");
        }

    }
}
     

