using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> Items = new List<string>();
        Console.WriteLine("Enter the Grocery Items (type 'done' to finish):");
        while (true)
        {
            string GroceryItem = Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(GroceryItem))
            {
                continue;
            }
            if (GroceryItem.ToLower() == "done")
            {
                break;
            }
            Items.Add(GroceryItem);
        }
        Console.WriteLine("Enter the item to be Removed");
        string RemovedGroceryItem = Console.ReadLine().Trim();
        if (Items.Contains(RemovedGroceryItem))
        {
            Items.Remove(RemovedGroceryItem);

            Console.WriteLine("Item Removed Sucessfully");
        }

        else
        {
            Console.WriteLine("Item Not Found");
        }
        Console.WriteLine("Grocery Items are:");
        foreach (string GroceryItems in Items)
        {
            Console.WriteLine(" " + GroceryItems);
        }
    }
}


        


        
        
            

