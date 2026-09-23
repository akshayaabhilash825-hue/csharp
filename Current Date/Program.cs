using System;
using System.IO;
class Program
{
    static void Main()
    {
        try
        {
            DateTime CurrentDate = DateTime.Now;
            DateTime FutureDate = CurrentDate.AddDays(5);
            TimeSpan Difference = FutureDate - CurrentDate;
            int DaysLeft = Difference.Days;


            string Result = $"Current Date:{CurrentDate},Future Date:{FutureDate},Days Left:{DaysLeft}";
            Console.WriteLine(Result);
            string filePath = "date_result.txt";
            File.WriteAllText(filePath, Result);

            Console.WriteLine("Calculation successful! Result saved to date_result.txt.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred:");
        }
    }
}
