namespace WinFormsTask
{
    partial class FormTask2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExecute = new Button();
            label1 = new Label();
            txtNum = new TextBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(12, 45);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(776, 29);
            btnExecute.TabIndex = 0;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "Number";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(81, 12);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(707, 27);
            txtNum.TabIndex = 3;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 80);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(776, 358);
            txtResult.TabIndex = 4;
            // 
            // FormTask2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Controls.Add(btnExecute);
            Name = "FormTask2";
            Text = "FormTask2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExecute;
        private Label label1;
        private TextBox txtNum;
        private TextBox txtResult;
    }
}