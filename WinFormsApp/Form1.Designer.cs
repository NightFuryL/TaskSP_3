namespace WinFormsApp
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
            lblTime = new Label();
            btnStart = new Button();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTime.Location = new Point(12, 9);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(318, 62);
            lblTime.TabIndex = 0;
            lblTime.Text = "Current time:";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 74);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(776, 80);
            btnStart.TabIndex = 1;
            btnStart.Text = "button1";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 167);
            Controls.Add(btnStart);
            Controls.Add(lblTime);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Button btnStart;
    }
}
