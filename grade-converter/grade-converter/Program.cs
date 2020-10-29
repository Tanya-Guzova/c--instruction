using System;

namespace grade_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter!");
            Console.WriteLine();
            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter numerical grade:");
                int numericalGrade = Int32.Parse(Console.ReadLine());
                String letterGrade = "";
				// if/else using ranges
				// convert numericalGrade to letter
				if (numericalGrade <= 60)
				{
					letterGrade = "F";
				}

				else if (numericalGrade >= 60 && numericalGrade <= 67)
				{
					letterGrade = "D";
				}

				else if (numericalGrade >= 68 && numericalGrade <= 79)
				{
					letterGrade = "C";
				}

				else if (numericalGrade >= 80 && numericalGrade <= 87)
				{
					letterGrade = "B";
				}

				else
				{
					letterGrade = "A";
				}
				//display output
				Console.WriteLine("Letter grade: " + letterGrade);
				Console.Write("Continue? (y/n): ");
				choice = Console.ReadLine();
				//*while loop ends

			}
			//goodbye message
			Console.WriteLine("Bye!");
		}
    }
}
