using System;
using System.Threading;
using CipherLibrary;
namespace ConsoleCipherApp;
class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Encrypt a file");
            Console.WriteLine("2. Decrypt a file(to console)");

            switch(Console.ReadLine())
            {
                case "0":
                    return;
                case "1":
                    Encrypt();
                    break;
                case "2":
                    Decrypt();
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
    private static void Encrypt()
    {
        Console.Write("Enter file path: ");
        string input = Console.ReadLine();

        Console.Write("Enter output file path (or press Enter for default): ");
        string output = Console.ReadLine() ?? @"..\..\..\..\encrypted.txt";

        Console.Write("Write key: ");
        int key = int.Parse(Console.ReadLine() ?? "3");

        CancellationTokenSource cts = new CancellationTokenSource();

        Thread thread = new Thread(() =>
        {
            CaesarCipher.EncryptFile(input, output, key, cts.Token);
            Console.WriteLine("Encryption finished!");
        });

        thread.Start();

        Console.WriteLine("Press C to cancel...");

        while (thread.IsAlive)
        {
            if (Console.KeyAvailable)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.C)
                {
                    cts.Cancel();
                    break;
                }
            }
        }

        thread.Join();
    }
    private static void Decrypt()
    {
        Console.Write("Enter file path: ");
        string input = Console.ReadLine();
        Console.Write("Enter key: ");
        int key = int.Parse(Console.ReadLine() ?? "3");
        CancellationTokenSource cts = new CancellationTokenSource();
        Thread thread = new Thread(() =>
        {
            string result = CaesarCipher.DecryptFile(input, key, cts.Token);
            Console.WriteLine("Decryption finished! Result:");
            Console.WriteLine(result);
        }); 
        thread.Start();

        Console.WriteLine("Press C to cancel...");

        while (thread.IsAlive)
        {
            if (Console.KeyAvailable)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.C)
                {
                    cts.Cancel();
                    break;
                }
            }
        }

        thread.Join();
    }
}