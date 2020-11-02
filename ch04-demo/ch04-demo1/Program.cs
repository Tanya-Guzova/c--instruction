using System;
using System.Net.Http.Headers;

namespace ch04_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("More control statements!");
            Console.Write("Enter a dwarf #: ");
            int nbr = Int32.Parse(Console.ReadLine());
            switch (nbr)
            {
                case 1:
                    Console.WriteLine("Sleepy");
                    break;
                case 2:
                    Console.WriteLine("Dopey");
                    break;
                case 3:
                    Console.WriteLine("Bashful");
                    break;
                case 4:
                    Console.WriteLine("Grumpy");
                    break;
                case 5:
                    Console.WriteLine("Happy");
                    break;
                case 6:
                    Console.WriteLine("Doc");
                    break;
                case 7:
                    Console.WriteLine("Sneezy");
                    break;

                default:
                    Console.WriteLine("Invalid #");
                    break;
            }

        }
    }
}
