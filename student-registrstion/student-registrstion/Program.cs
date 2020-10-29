using System;

namespace student_registrstion
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Student Registration Form");
			Console.WriteLine();

			String firstName;
			String lastName;
			int yearOfBirth;

			Console.WriteLine("Enter first name: ");
			firstName = Console.ReadLine();
			Console.WriteLine();

			Console.WriteLine("Enter last name: ");
			lastName = Console.ReadLine();
			Console.WriteLine();

			Console.WriteLine("Enter year of birth: ");
			yearOfBirth = Int32.Parse(Console.ReadLine());
			Console.WriteLine();

			Console.WriteLine("Welcome " + firstName + " " + lastName + "!");
			Console.WriteLine("Your Registration is complete");
			Console.WriteLine("Your temporary password is : " + firstName + "*" + yearOfBirth);

		}

	}
}
