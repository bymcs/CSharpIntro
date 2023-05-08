namespace ThreadingDemo1
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
            btnProcess = new Button();
            btnProcess2 = new Button();
            SuspendLayout();
            // 
            // btnProcess
            // 
            btnProcess.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProcess.Location = new Point(72, 61);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(139, 61);
            btnProcess.TabIndex = 0;
            btnProcess.Text = "İşlem 1";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // btnProcess2
            // 
            btnProcess2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProcess2.Location = new Point(230, 61);
            btnProcess2.Name = "btnProcess2";
            btnProcess2.Size = new Size(139, 61);
            btnProcess2.TabIndex = 1;
            btnProcess2.Text = "İşlem 2";
            btnProcess2.UseVisualStyleBackColor = true;
            btnProcess2.Click += btnProcess2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 226);
            Controls.Add(btnProcess2);
            Controls.Add(btnProcess);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProcess;
        private Button btnProcess2;
    }
}