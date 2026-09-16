using System;

class Program
{
    
    static void WelcomeCustomer(string name, string product, string city)
    {
        Console.WriteLine($"Welcome {name} from {city}! " +
                          $"Your order for {product} has been received.");
    }

    static string GetDiscountMessage(string name)
    {
        return $"Thanks {name}! You have received a 10% discount.";
    }

    static void Main(string[] args)
    {
       
        WelcomeCustomer(name: "Priya", product: "Laptop", city: "Chennai");
        Console.WriteLine(GetDiscountMessage("Priya"));
        Console.WriteLine();

        WelcomeCustomer(name: "Rahul", product: "Smartphone", city: "Mumbai");
        Console.WriteLine(GetDiscountMessage("Rahul"));
        Console.WriteLine();

        WelcomeCustomer(name: "Anita", product: "Headphones", city: "Delhi");
        Console.WriteLine(GetDiscountMessage("Anita"));
    }
}
