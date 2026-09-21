using System;
class Employee
{
    private double salary;
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary
    {
        get { return salary; }
        set
        {
            if (value>0)
            {
                salary = value;
            }
            else
            {
                Console.WriteLine("Invalid Salary");
            }
        }
            
            }
        }

class program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.Name = "John Doe";
        emp.Id = 1;
        emp.Salary = -16000;
        
        Console.WriteLine($"Employee Name:{emp.Name}");
        Console.WriteLine($"Employee Id:{emp.Id}");
        Console.WriteLine($"Employee Salary:{emp.Salary}");
    } }


    