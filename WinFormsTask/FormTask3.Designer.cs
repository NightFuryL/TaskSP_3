namespace WinFormsTask
{
    partial class FormTask3
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
            label1 = new Label();
            label2 = new Label();
            txtResult = new TextBox();
            txtFraction1 = new TextBox();
            txtFraction2 = new TextBox();
            btnExecute = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Fraction 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Fraction 2";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 113);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(776, 325);
            txtResult.TabIndex = 2;
            // 
            // txtFraction1
            // 
            txtFraction1.Location = new Point(127, 12);
            txtFraction1.Name = "txtFraction1";
            txtFraction1.PlaceholderText = "a/b";
            txtFraction1.Size = new Size(661, 27);
            txtFraction1.TabIndex = 3;
            // 
            // txtFraction2
            // 
            txtFraction2.Location = new Point(127, 45);
            txtFraction2.Name = "txtFraction2";
            txtFraction2.PlaceholderText = "a/b";
            txtFraction2.Size = new Size(661, 27);
            txtFraction2.TabIndex = 4;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(12, 78);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(776, 29);
            btnExecute.TabIndex = 5;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // FormTask3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExecute);
            Controls.Add(txtFraction2);
            Controls.Add(txtFraction1);
            Controls.Add(txtResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTask3";
            Text = "FormTask3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtResult;
        private TextBox txtFraction1;
        private TextBox txtFraction2;
        private Button btnExecute;
    }
}