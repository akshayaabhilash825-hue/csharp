using System;

class CourseRegistrationChecker
{
    static void Main(string[]args)
      
    {
        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();

        Console.Write("Enter the course : ");
        string courseName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Have you completed the prerequisites? (yes/no): ");
        string prerequisites = Console.ReadLine();

        
        Console.WriteLine($"\nHello {fullName.ToUpper()}, welcome to the registration portal!");

        
        if (courseName.IndexOf("C#", StringComparison.OrdinalIgnoreCase) >= 0)
        {
            Console.WriteLine("The course you selected includes C#.");
        }
        else
        {
            Console.WriteLine(" The course you selected does not include C#.");
        }

       
        if (age >= 18 && prerequisites.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine(" Registration successful! You meet all the requirements.");
        }
        else
        {
            Console.WriteLine(" Registration failed.");
            if (age < 18)
            {
                Console.WriteLine("- You must be at least 18 years old.");
            }
            if (!prerequisites.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("- You must complete the prerequisites before registering.");
            }
        }
    }
}

