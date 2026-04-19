namespace OracleWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtQuestion = new TextBox();
            txtAnswer = new TextBox();
            label1 = new Label();
            btnAsk = new Button();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(86, 12);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(702, 27);
            txtQuestion.TabIndex = 0;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(12, 45);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.ReadOnly = true;
            txtAnswer.ScrollBars = ScrollBars.Vertical;
            txtAnswer.Size = new Size(776, 78);
            txtAnswer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 2;
            label1.Text = "Question";
            // 
            // btnAsk
            // 
            btnAsk.Location = new Point(12, 129);
            btnAsk.Name = "btnAsk";
            btnAsk.Size = new Size(776, 29);
            btnAsk.TabIndex = 3;
            btnAsk.Text = "Ask";
            btnAsk.UseVisualStyleBackColor = true;
            btnAsk.Click += btnAsk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 170);
            Controls.Add(btnAsk);
            Controls.Add(label1);
            Controls.Add(txtAnswer);
            Controls.Add(txtQuestion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuestion;
        private TextBox txtAnswer;
        private Label label1;
        private Button btnAsk;
    }
}
