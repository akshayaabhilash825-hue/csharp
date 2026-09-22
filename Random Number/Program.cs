using System;
class program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int score = random.Next(0, 100);
        string Performance;
        if (score > 0 && score < 39)
        {
            Performance = "fail";
        }
        else if (score > 40 && score < 59)
        {
            Performance = "Pass";

        }
        else if (score > 60 && score < 79)
        {
            Performance = "Good";
        }
        else
        {
            Performance = "Excellent";
        }
        string Output = $"Score:{score}- Performance:{Performance}";
        string filePath = "StudentPerformance.txt";

        File.WriteAllText(filePath, Output);


        string fileContents = File.ReadAllText(filePath);
        Console.WriteLine("Contents of StudentPerformance.txt:");
        Console.WriteLine(fileContents);

    }
}