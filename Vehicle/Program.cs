using System;
class Vehicle
{
    public string Brand { get; set; }
    public Vehicle()
    {
        Brand = "Unknown";

    }
public virtual string GetDetails ()
    {
        return $"Brand:{Brand}";
    }
}
class Car : Vehicle
{
    public string Model { get; set; }
    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }
    public  override string GetDetails()
    {
        return $"Brand:{Brand}, Model:{Model}";
    } }
class Truck : Vehicle
{
    public int LoadCapacity { get; set; }
    public Truck(string brand, int loadCapacity)
    {
        Brand = brand;
        LoadCapacity = loadCapacity;
    }
    public override string GetDetails()
    {
        return $"Brand:{Brand}, Load Capacity:{LoadCapacity} tons";
    }
}
class Program
{
    static void Main()
    {
        Car car = new Car("Toyota", "Camry");
        Truck truck = new Truck("Ford", 5);
        Console.WriteLine("Car Details: " + car.GetDetails());
        Console.WriteLine("Truck Details: " + truck.GetDetails());

    }
}



