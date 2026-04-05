using System.Text;

namespace LibraryTask;

public class FileEncryptor
{
    //StringBuilder для оптимізації:) та зручності, хочу звикнути до нього
    public string Encrypt(string text)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in text)
        {
            sb.Append((char)(c + 1));
        }

        return sb.ToString();
    }
}