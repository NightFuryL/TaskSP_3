using System;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        System.Threading.Timer timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer = new System.Threading.Timer(UpdateTime, null, 0, 1000);
        }

        void UpdateTime(object state)
        {
            if (lblTime.InvokeRequired)
            {
                lblTime.Invoke(new Action(() =>
                {
                    lblTime.Text = "Current time: " + DateTime.Now.ToLongTimeString();
                }));
            }
            else
            {
                lblTime.Text = "Current time: " + DateTime.Now.ToLongTimeString();
            }
        }
    }
}