using LibraryTask;
using System.Diagnostics;

class Program
{
    private static int totalFiles = 0;
    private static int processedFiles = 0;

    static async Task Main(string[] args)
    {
        Console.WriteLine("Write path to the folder:");
        string input = Console.ReadLine();
        string path = string.IsNullOrWhiteSpace(input) ? @"..\..\..\..\TestFolder" : input;

        var files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);

        totalFiles = files.Length;

        Stopwatch sw = new Stopwatch();
        sw.Start();

        foreach (var file in files)
        {
            //Також як в проєкті з WinForms
            ThreadPool.QueueUserWorkItem(async _ =>
            {
                await ProcessFile(file);
            });
        }

        while (processedFiles < totalFiles)
        {
            await Task.Delay(100);
        }

        sw.Stop();

        Console.WriteLine($"Files: {totalFiles}");
        Console.WriteLine($"Time: {sw.ElapsedMilliseconds} ms");
    }

    static async Task ProcessFile(string file)
    {
        Console.WriteLine($"Start: {file}");

        string text = File.ReadAllText(file);

        FileEncryptor enc = new FileEncryptor();
        string result = enc.Encrypt(text);

        string newFile = file + ".enc.txt";

        await File.WriteAllTextAsync(newFile, result);

        Console.WriteLine($"Done: {file}");

        processedFiles++;
    }
}