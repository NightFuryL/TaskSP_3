using LibraryTask;
namespace WinFormsTask
{
    public partial class FormTask2 : Form
    {
        public FormTask2()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNum.Text);
            string fact;
            try
            {
                fact = MyMath.Factorial(n).ToString();
            }
            catch(Exception ex) {
                fact = "Error";
                MessageBox.Show("Error calculating factorial: " + ex.Message);
                return;
            }
            bool prime = MyMath.IsPrime(n);
            bool even = MyMath.IsEven(n);
            bool odd = MyMath.IsOdd(n);

            txtResult.Text =
                "Factorial: " + fact + Environment.NewLine +
                "Prime: " + prime + Environment.NewLine +
                "Even: " + even + Environment.NewLine +
                "Odd: " + odd + Environment.NewLine;
        }
    }
}
