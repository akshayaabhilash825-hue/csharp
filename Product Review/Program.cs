using System;
using System.IO;

namespace ProductReviewsApp
{
    
    enum RatingCategory
    {
        Poor = 1,
        Average = 2,
        Good = 3,
        VeryGood = 4,
        Excellent = 5
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            string[] products = { "Phone", "Laptop", "Tablet", "Headphones", "Smartwatch" };

            
            Random random = new Random();

            
            string filePath = "ProductReviews.txt";

            
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string product in products)
                {
                    int ratingNumber = random.Next(1, 6); 
                    RatingCategory category = (RatingCategory)ratingNumber;

                    string review = $"Product: {product}, Rating: {ratingNumber}, Category: {category}";
                    writer.WriteLine(review);
                }
            }

            
            Console.WriteLine("Contents of ProductReviews.txt:");
            string[] fileContents = File.ReadAllLines(filePath);
            foreach (string line in fileContents)
            {
                Console.WriteLine(line);
            }
        }
    }
}
