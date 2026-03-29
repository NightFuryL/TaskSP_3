using System;
using System.Threading;
namespace ConsoleApp;
class Program
{
    static Timer timer;

    static void Main(string[] args)
    {
        timer = new Timer(ShowTime, null, 0, 1000);

        Console.ReadLine();
    }

    static void ShowTime(object state)
    {
        Console.Clear();
        Console.WriteLine("Current time: " + DateTime.Now.ToLongTimeString());
    }
}