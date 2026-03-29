namespace WinFormsCipherApp
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
            groupBox1 = new GroupBox();
            rbDecrypt = new RadioButton();
            rbEncrypt = new RadioButton();
            btnExecute = new Button();
            txtPath = new TextBox();
            txtOutputText = new TextBox();
            txtOutputFile = new TextBox();
            btnCancel = new Button();
            txtKey = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblStatus = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDecrypt);
            groupBox1.Controls.Add(rbEncrypt);
            groupBox1.Location = new Point(12, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(95, 85);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rbDecrypt
            // 
            rbDecrypt.AutoSize = true;
            rbDecrypt.Location = new Point(6, 56);
            rbDecrypt.Name = "rbDecrypt";
            rbDecrypt.Size = new Size(82, 24);
            rbDecrypt.TabIndex = 1;
            rbDecrypt.TabStop = true;
            rbDecrypt.Text = "Decrypt";
            rbDecrypt.UseVisualStyleBackColor = true;
            // 
            // rbEncrypt
            // 
            rbEncrypt.AutoSize = true;
            rbEncrypt.Location = new Point(6, 26);
            rbEncrypt.Name = "rbEncrypt";
            rbEncrypt.Size = new Size(79, 24);
            rbEncrypt.TabIndex = 0;
            rbEncrypt.TabStop = true;
            rbEncrypt.Text = "Encrypt";
            rbEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(12, 197);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(776, 29);
            btnExecute.TabIndex = 2;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(101, 12);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(687, 27);
            txtPath.TabIndex = 4;
            // 
            // txtOutputText
            // 
            txtOutputText.Location = new Point(12, 287);
            txtOutputText.Multiline = true;
            txtOutputText.Name = "txtOutputText";
            txtOutputText.ReadOnly = true;
            txtOutputText.ScrollBars = ScrollBars.Vertical;
            txtOutputText.Size = new Size(776, 261);
            txtOutputText.TabIndex = 5;
            // 
            // txtOutputFile
            // 
            txtOutputFile.Location = new Point(101, 45);
            txtOutputFile.Name = "txtOutputFile";
            txtOutputFile.Size = new Size(687, 27);
            txtOutputFile.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 232);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(776, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(101, 78);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(687, 27);
            txtKey.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 9;
            label1.Text = "Output file:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 10;
            label2.Text = "Path to file:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 11;
            label3.Text = "Key:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(376, 264);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(lblStatus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKey);
            Controls.Add(btnCancel);
            Controls.Add(txtOutputFile);
            Controls.Add(txtOutputText);
            Controls.Add(txtPath);
            Controls.Add(btnExecute);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbDecrypt;
        private RadioButton rbEncrypt;
        private Button btnExecute;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtPath;
        private TextBox txtOutputText;
        private TextBox txtOutputFile;
        private Button btnCancel;
        private TextBox txtKey;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblStatus;
    }
}
