namespace WinFormsTask
{
    partial class FormTask1
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
            txtMessage = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCaption = new TextBox();
            SuspendLayout();
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(12, 78);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(776, 29);
            btnExecute.TabIndex = 0;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(85, 12);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(703, 27);
            txtMessage.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Message";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "Caption";
            // 
            // txtCaption
            // 
            txtCaption.Location = new Point(85, 45);
            txtCaption.Name = "txtCaption";
            txtCaption.Size = new Size(703, 27);
            txtCaption.TabIndex = 4;
            // 
            // FormTask1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 113);
            Controls.Add(txtCaption);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMessage);
            Controls.Add(btnExecute);
            Name = "FormTask1";
            Text = "FormTask1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExecute;
        private TextBox txtMessage;
        private Label label1;
        private Label label2;
        private TextBox txtCaption;
    }
}