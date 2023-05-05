namespace ClassesForm
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
            dgrwCustomers = new DataGridView();
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            lbxCity = new Label();
            lbxEmail = new Label();
            lbxId = new Label();
            lbxLastName = new Label();
            lbxFirstName = new Label();
            tbxCity = new TextBox();
            tbxEmail = new TextBox();
            tbxLastName = new TextBox();
            tbxFirstName = new TextBox();
            tbxId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgrwCustomers
            // 
            dgrwCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwCustomers.Dock = DockStyle.Top;
            dgrwCustomers.Location = new Point(0, 0);
            dgrwCustomers.Name = "dgrwCustomers";
            dgrwCustomers.RowTemplate.Height = 25;
            dgrwCustomers.Size = new Size(463, 325);
            dgrwCustomers.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(lbxCity);
            groupBox1.Controls.Add(lbxEmail);
            groupBox1.Controls.Add(lbxId);
            groupBox1.Controls.Add(lbxLastName);
            groupBox1.Controls.Add(lbxFirstName);
            groupBox1.Controls.Add(tbxCity);
            groupBox1.Controls.Add(tbxEmail);
            groupBox1.Controls.Add(tbxLastName);
            groupBox1.Controls.Add(tbxFirstName);
            groupBox1.Controls.Add(tbxId);
            groupBox1.Location = new Point(12, 343);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 263);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(175, 211);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 31);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbxCity
            // 
            lbxCity.AutoSize = true;
            lbxCity.Location = new Point(50, 184);
            lbxCity.Name = "lbxCity";
            lbxCity.Size = new Size(28, 15);
            lbxCity.TabIndex = 21;
            lbxCity.Text = "City";
            // 
            // lbxEmail
            // 
            lbxEmail.AutoSize = true;
            lbxEmail.Location = new Point(42, 149);
            lbxEmail.Name = "lbxEmail";
            lbxEmail.Size = new Size(36, 15);
            lbxEmail.TabIndex = 20;
            lbxEmail.Text = "Email";
            // 
            // lbxId
            // 
            lbxId.AutoSize = true;
            lbxId.Location = new Point(61, 44);
            lbxId.Name = "lbxId";
            lbxId.Size = new Size(18, 15);
            lbxId.TabIndex = 19;
            lbxId.Text = "ID";
            // 
            // lbxLastName
            // 
            lbxLastName.AutoSize = true;
            lbxLastName.Location = new Point(15, 114);
            lbxLastName.Name = "lbxLastName";
            lbxLastName.Size = new Size(63, 15);
            lbxLastName.TabIndex = 18;
            lbxLastName.Text = "Last Name";
            // 
            // lbxFirstName
            // 
            lbxFirstName.AutoSize = true;
            lbxFirstName.Location = new Point(15, 79);
            lbxFirstName.Name = "lbxFirstName";
            lbxFirstName.Size = new Size(64, 15);
            lbxFirstName.TabIndex = 17;
            lbxFirstName.Text = "First Name";
            // 
            // tbxCity
            // 
            tbxCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxCity.Location = new Point(85, 176);
            tbxCity.Name = "tbxCity";
            tbxCity.Size = new Size(165, 29);
            tbxCity.TabIndex = 16;
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEmail.Location = new Point(85, 141);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(165, 29);
            tbxEmail.TabIndex = 15;
            // 
            // tbxLastName
            // 
            tbxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxLastName.Location = new Point(85, 106);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(165, 29);
            tbxLastName.TabIndex = 14;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxFirstName.Location = new Point(85, 71);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(165, 29);
            tbxFirstName.TabIndex = 13;
            // 
            // tbxId
            // 
            tbxId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxId.Location = new Point(85, 36);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(165, 29);
            tbxId.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 649);
            Controls.Add(groupBox1);
            Controls.Add(dgrwCustomers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgrwCustomers;
        private GroupBox groupBox1;
        private Button btnAdd;
        private Label lbxCity;
        private Label lbxEmail;
        private Label lbxId;
        private Label lbxLastName;
        private Label lbxFirstName;
        private TextBox tbxCity;
        private TextBox tbxEmail;
        private TextBox tbxLastName;
        private TextBox tbxFirstName;
        private TextBox tbxId;
    }
}