using System;

namespace chapter03_demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Class and Random #s");
            Random rand = new Random();
            for (int i=0; i<10; i++)
            {
                int r1 = rand.Next(6);
                Console.WriteLine("r1 = " + r1);
            }
            //random between min amd max
            for (int i = 0; i < 10; i++)
            {
                int r1 = rand.Next(10,20);
                Console.WriteLine("r1 = " + r1);
            }
            //rounding
            double d1 = 85.578888;
            Console.WriteLine("d1 = " + d1);
            Console.WriteLine("d1 = " + Math.Round(d1));
            Console.WriteLine("d1 = " + Math.Round(d1,2));

            //currency formatting
            double d2 = 199.99;
            Console.WriteLine(d2.ToString("C"));
        }
    }
}
