namespace CipherLibrary;
public class CaesarCipher
{
    public static void EncryptFile(string inputPath, string outputPath, int shift, CancellationToken token)
    {
        string text = File.ReadAllText(inputPath);
        string result = "";

        foreach (char c in text)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Operation cancelled");
                return;
            }

            result += EncryptChar(c, shift);

            Thread.Sleep(50);
        }

        File.WriteAllText(outputPath, result);
    }
    private static char EncryptChar(char c, int shift)
    {
        if (!char.IsLetter(c))
            return c;

        char offset = char.IsUpper(c) ? 'A' : 'a';
        return (char)((c - offset + shift) % 26 + offset);
    }
    public static string DecryptFile(string inputPath, int shift, CancellationToken token)
    {
        string text = File.ReadAllText(inputPath);
        string result = "";
        foreach (char c in text)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Operation cancelled");
                return result;
            }
            result += DecryptChar(c, shift);
        }
        return result;
    }
    private static char DecryptChar(char c, int shift)
    {
        return EncryptChar(c, 26 - shift);
    }
}