using System;
using System.ComponentModel.Design;
namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Username:");
            string Username = Console.ReadLine();
            Console.WriteLine("Enter the Password:");
            string Password = Console.ReadLine();
            if (Password.Length < 8)
            {
                Console.WriteLine("Error:Password must be at least 8 characters long");
            }
            else if (Password.ToLower().Contains(Username.ToLower()))
            {
                Console.WriteLine("Error:Password  should not contain the username");
            }
            else
            {
                Console.WriteLine("Login Succesful!");
            }
        }
    }
}

