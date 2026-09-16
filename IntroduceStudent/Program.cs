using System;
class Program
{
    static void IntroduceStudent(string StudentName, string Course, string City)
    {
        Console.WriteLine($"Student Name {StudentName}, Course {Course},City {City}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!!");
        IntroduceStudent(StudentName: "Alice", Course: "Science", City: " NewYork");
        IntroduceStudent(StudentName: "Bob", Course: "Math", City: " LosAngeles");
    }
}