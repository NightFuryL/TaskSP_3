using OracleLibrary;

namespace OracleWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuestion.Text))
            {
                txtAnswer.Text = (new Oracle().GetAnswer()).ToString();
            }
        }
    }
}
