using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> Books = new Dictionary<string, string>();

        Books.Add("Harry potter", "Available");
        Books.Add("Lord of the Rings", "Available");
        Books.Add("The Hobbit", "Rented");

        Dictionary<string, Queue<string>> waitingList =
    new Dictionary<string, Queue<string>>();

        Console.WriteLine("Available Books:");

        foreach (var book in Books)
        {
            Console.WriteLine(book.Key + " - " + book.Value);
        }
        Console.WriteLine("Enter the book you want to rent:");
        string bookToRent = Console.ReadLine();

        if (Books.ContainsKey(bookToRent))
        {
            if (Books[bookToRent] == "Available")
            {
                Books[bookToRent] = "Rented";
                Console.WriteLine("Book rented successfully");
            }
            else
            {
                Console.WriteLine("Book is already rented");

                Console.WriteLine("Enter your name to join waiting list:");
                string name = Console.ReadLine();

                if (!waitingList.ContainsKey(bookToRent)) { waitingList.Add(bookToRent, new Queue<string>()); }

                waitingList[bookToRent].Enqueue(name);
                Console.WriteLine("You have been added to the waiting list.");
            }

        }
        else
        {
            Console.WriteLine("Book not Found");
        }
        Console.WriteLine("Do you want to return a book? (yes/no)");
        string returnBook = Console.ReadLine();

        if (returnBook.ToLower() == "yes")
        {
            Console.WriteLine("Enter the book you want to return:");
            string bookToReturn = Console.ReadLine();
            if (Books.ContainsKey(bookToReturn))
            {
                Books[bookToReturn] = "Available";
                Console.WriteLine("Book returned successfully");
                if (waitingList.ContainsKey(bookToReturn) && waitingList[bookToReturn].Count > 0)
                {
                    string nextPerson = waitingList[bookToReturn].Dequeue();
                    Console.WriteLine(nextPerson + ", the book is now available for you.");
                }
            }

            else
            {
                Console.WriteLine("Book not Found");
            }

        }



    }
}