using LibraryTask;
using System.Diagnostics;

namespace WinFormsTask;

public partial class Form1 : Form
{
    private int totalFiles = 0;
    private int processedFiles = 0;

    public Form1()
    {
        InitializeComponent();
    }

    private async void btnStart_Click(object sender, EventArgs e)
    {
        txtBoxLog.Clear();

        string path = string.IsNullOrEmpty(txtPath.Text) ? @"..\..\..\..\TestFolder" : txtPath.Text;

        var files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);

        totalFiles = files.Length;

        Stopwatch sw = new Stopwatch();
        sw.Start();

        foreach (var file in files)
        {
            //Зробив асинхронну обробку файлів за допомогою ThreadPool, щоб не блокувати UI потік, трохи подивився також в інтернеті
            //Тому що я не знав як передати в параметри асинхронну функцію, в тасках просто () а тут чогось _
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

        LogToStat($"Files: {totalFiles}");
        LogToStat($"Time: {sw.ElapsedMilliseconds} ms");
    }

    private async Task ProcessFile(string file)
    {
        LogTo($"Start: {file}");

        string text = File.ReadAllText(file);

        FileEncryptor enc = new FileEncryptor();
        string result = enc.Encrypt(text);

        string newFile = file + ".enc.txt";

        await File.WriteAllTextAsync(newFile, result);

        LogTo($"Done: {file}");

        processedFiles++;
    }
    //Я писав що цей лог я подивився в інтернеті, а Environment.NewLine це просто символ нового рядка для окремої операційної системи або проєкту одразу
    private void LogTo(string text)
    {
        if (InvokeRequired)
        {
            Invoke(new Action<string>(LogTo), text);
        }
        else
        {
            txtBoxLog.AppendText(text + Environment.NewLine);
        }
    }
    private void LogToStat(string text)
    {
        if (InvokeRequired)
        {
            Invoke(new Action<string>(LogToStat), text);
        }
        else
        {
            txtStat.AppendText(text + Environment.NewLine);
        }
    }
}