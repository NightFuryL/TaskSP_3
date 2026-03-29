using CipherLibrary;

namespace WinFormsCipherApp;

public partial class Form1 : Form
{
    Thread thread;
    CancellationTokenSource cts;
    public Form1()
    {
        InitializeComponent();
    }

    private void btnExecute_Click(object sender, EventArgs e)
    {
        CheckControls();
        if (rbEncrypt.Checked)
        {
            Encrypt();
        }
        else if(rbDecrypt.Checked)
        {
            Decrypt();
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        cts?.Cancel();
        lblStatus.Text = "Cancelled!";
    }
    private void Encrypt()
    {
        try
        {
            txtOutputText.Text = "Encryption selected. Please wait...";
            string input = txtPath.Text;
            string output = txtOutputFile.Text ?? @"..\..\..\..\encrypted.txt";
            string key = txtKey.Text;
            cts = new CancellationTokenSource();

            thread = new Thread(() =>
            {
                CaesarCipher.EncryptFile(input, output, int.Parse(key), cts.Token);

                this.Invoke(new Action(() =>
                {
                    lblStatus.Text = "Finished!";
                    txtOutputText.Text = "Encrypted text to file: \n\n\n" + output;
                }));
            });

            thread.Start();
            lblStatus.Text = "Working...";
        }
        catch (Exception ex)
        {
            txtOutputText.Text = "An error occurred: " + ex.Message;
        }

    }
    private void Decrypt()
    {
        try
        {
            txtOutputText.Text = "Decryption selected. Please wait...";
            string input = txtPath.Text;
            string output = txtOutputFile.Text ?? @"..\..\..\..\encrypted.txt";
            string key = txtKey.Text;
            string text = string.Empty;
            cts = new CancellationTokenSource();
            thread = new Thread(() =>
            {
                text = CaesarCipher.DecryptFile(input, int.Parse(key), cts.Token);
                this.Invoke(new Action(() =>
                {
                    lblStatus.Text = "Finished!";
                    txtOutputText.Text = "Decrypted text: \n\n\n" + text;
                }));
            });
            thread.Start();
            lblStatus.Text = "Working...";
        }
        catch(Exception ex)
        {
            txtOutputText.Text = "An error occurred: " + ex.Message;
        }
    }   
    private void CheckControls()
    {
        if (string.IsNullOrEmpty(txtPath.Text) || string.IsNullOrEmpty(txtKey.Text))
        {
            txtOutputText.Text = "Please fill in all fields!";
            return;
        }
    }
}
