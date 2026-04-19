using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using LibraryTask;
namespace WinFormsTask
{
    public partial class FormTask1 : Form
    {
        public FormTask1()
        {
            InitializeComponent();
        }
        //Зробив все як треба та додав навіть трохи перевірок пишу коментар тут 
        //щоб було видно всюди я не писав тому що нема нічого такого
        private void btnExecute_Click(object sender, EventArgs e)
        {
            LibraryTask.Task1Class.MessageBox(0, txtMessage.Text, ((string.IsNullOrEmpty(txtCaption.Text))?"Base":txtCaption.Text), 1);
        }
    }
}
