namespace WinFormsTask
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
            btnStart = new Button();
            txtBoxLog = new TextBox();
            txtPath = new TextBox();
            label1 = new Label();
            txtStat = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 45);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(776, 53);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtBoxLog
            // 
            txtBoxLog.Location = new Point(12, 124);
            txtBoxLog.Multiline = true;
            txtBoxLog.Name = "txtBoxLog";
            txtBoxLog.ReadOnly = true;
            txtBoxLog.ScrollBars = ScrollBars.Vertical;
            txtBoxLog.Size = new Size(776, 193);
            txtBoxLog.TabIndex = 1;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(58, 12);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(730, 27);
            txtPath.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 101);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 3;
            label1.Text = "Log:";
            // 
            // txtStat
            // 
            txtStat.Location = new Point(12, 343);
            txtStat.Multiline = true;
            txtStat.Name = "txtStat";
            txtStat.ReadOnly = true;
            txtStat.ScrollBars = ScrollBars.Vertical;
            txtStat.Size = new Size(776, 120);
            txtStat.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 320);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "Statistics";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 19);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 6;
            label3.Text = "Path:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtStat);
            Controls.Add(label1);
            Controls.Add(txtPath);
            Controls.Add(txtBoxLog);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private TextBox txtBoxLog;
        private TextBox txtPath;
        private Label label1;
        private TextBox txtStat;
        private Label label2;
        private Label label3;
    }
}
