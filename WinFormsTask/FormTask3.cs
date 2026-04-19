using LibraryTask;
namespace WinFormsTask
{
    public partial class FormTask3 : Form
    {
        public FormTask3()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                string a1 = txtFraction1.Text;
                string b1 = txtFraction2.Text;

                Fraction f1 = Fraction.ToFraction(a1);
                Fraction f2 = Fraction.ToFraction(b1);

                Fraction result = f1.Add(f2);
                txtResult.AppendText($"{f1.ToString()} + {f2.ToString()} = {result.ToString()}" + Environment.NewLine);
                txtResult.AppendText(result.ToString());
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
