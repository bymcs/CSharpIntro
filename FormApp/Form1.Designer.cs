namespace FormApp
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
            btnAddToCart = new Button();
            listBox2 = new ListBox();
            label2 = new Label();
            btnRemoveCard = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(9, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(165, 229);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(180, 26);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(81, 29);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(267, 26);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(161, 229);
            listBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 8);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // btnRemoveCard
            // 
            btnRemoveCard.Location = new Point(434, 26);
            btnRemoveCard.Name = "btnRemoveCard";
            btnRemoveCard.Size = new Size(63, 55);
            btnRemoveCard.TabIndex = 5;
            btnRemoveCard.Text = "Remove Selected";
            btnRemoveCard.UseVisualStyleBackColor = true;
            btnRemoveCard.Click += btnRemoveCard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 264);
            Controls.Add(btnRemoveCard);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(btnAddToCart);
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
        private Button btnAddToCart;
        private ListBox listBox2;
        private Label label2;
        private Button btnRemoveCard;
    }
}