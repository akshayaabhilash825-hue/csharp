using System;

using System.Threading;
class Program
{
    static void Main()
    {
        try
        {


            Thread thread1 = new Thread(PrintNumbers);
            Thread thread2 = new Thread(PrintLetters);
            
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error");
        }
        finally
        {
            Console.WriteLine("Execution completed."); 
        }
        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);

            }
        }
        static void PrintLetters()
        {
            for (char j = 'A'; j <= 'E'; j++)
            {
                Console.WriteLine(j);
                Thread.Sleep(1000);
            }
        }
    }
}
