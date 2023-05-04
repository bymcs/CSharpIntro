namespace ListsForm
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
            listBox1 = new ListBox();
            label1 = new Label();
            btnAddStudent = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            btnRemoveStudents = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(199, 394);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 1;
            label1.Text = "Öğrenci Listesi";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(527, 66);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(75, 23);
            btnAddStudent.TabIndex = 2;
            btnAddStudent.Text = "Ekle";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(408, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(310, 39);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 4;
            label2.Text = "Öğrenci Adı";
            // 
            // btnRemoveStudents
            // 
            btnRemoveStudents.Location = new Point(12, 437);
            btnRemoveStudents.Name = "btnRemoveStudents";
            btnRemoveStudents.Size = new Size(199, 23);
            btnRemoveStudents.TabIndex = 5;
            btnRemoveStudents.Text = "Öğrenciyi sil";
            btnRemoveStudents.UseVisualStyleBackColor = true;
            btnRemoveStudents.Click += btnRemoveStudents_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 474);
            Controls.Add(btnRemoveStudents);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(btnAddStudent);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button btnAddStudent;
        private TextBox textBox1;
        private Label label2;
        private Button btnRemoveStudents;
    }
}