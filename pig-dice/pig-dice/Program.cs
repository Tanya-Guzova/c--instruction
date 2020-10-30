using System;

namespace pig_dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Dice App!");
            string choice = "y";
            Random rand = new Random();
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter the # of games: ");
                int numberOfGames = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Here we go... ");
                int highestScore = 0;
                int count = 0;
                while (count < numberOfGames)
                {
                    int score = 0;
                    Boolean notEqualOne = true;
                    while (notEqualOne)
                    {
                        int randNbr = rand.Next(1, 6);
                        if (randNbr != 1)
                        {
                            Console.WriteLine("# " + randNbr);
                            score += randNbr;
                        }
                        else
                        {
                            score += randNbr;
                            notEqualOne = false;
                            Console.WriteLine("# " + randNbr);
                            Console.WriteLine("Current round score is " + score);
                            Console.WriteLine("**************************");
                        }
                    }
                    if (score > highestScore)
                    {
                        highestScore = score;
                    }
                    count++;
                }
                Console.WriteLine("Played " + numberOfGames + "  games");
                Console.WriteLine("Highest Score is " + highestScore);
                Console.WriteLine("Again? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye!");
        }
    }
}
