namespace WinFormsTask
{
    partial class MainForm
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
            btnTask3 = new Button();
            btnTask2 = new Button();
            btnTask1 = new Button();
            SuspendLayout();
            // 
            // btnTask3
            // 
            btnTask3.Location = new Point(12, 82);
            btnTask3.Name = "btnTask3";
            btnTask3.Size = new Size(776, 29);
            btnTask3.TabIndex = 5;
            btnTask3.Text = "Task 3";
            btnTask3.UseVisualStyleBackColor = true;
            btnTask3.Click += btnTask3_Click;
            // 
            // btnTask2
            // 
            btnTask2.Location = new Point(12, 47);
            btnTask2.Name = "btnTask2";
            btnTask2.Size = new Size(776, 29);
            btnTask2.TabIndex = 4;
            btnTask2.Text = "Task 2";
            btnTask2.UseVisualStyleBackColor = true;
            btnTask2.Click += btnTask2_Click;
            // 
            // btnTask1
            // 
            btnTask1.Location = new Point(12, 12);
            btnTask1.Name = "btnTask1";
            btnTask1.Size = new Size(776, 29);
            btnTask1.TabIndex = 3;
            btnTask1.Text = "Task 1";
            btnTask1.UseVisualStyleBackColor = true;
            btnTask1.Click += btnTask1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 128);
            Controls.Add(btnTask3);
            Controls.Add(btnTask2);
            Controls.Add(btnTask1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTask3;
        private Button btnTask2;
        private Button btnTask1;
    }
}