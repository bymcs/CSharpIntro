namespace FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = "�r�nler";
            label2.Text = "Sepet";
            btnAddToCart.Text = "Sepete Ekle";
            btnRemoveCard.Text = "Sepetten ��kar";

            btnRemoveCard.Enabled = false;



            string[] products = new string[] {
                "Laptop", "Masa�st� PC", "Klavye", "Mouse", "Ekran", "Taray�c�", "Yaz�c�", "Hoparl�r",
                "Kulakl�k", "Kamera", "Telefon", "Tablet", "Ak�ll� saat", "Oyun konsolu", "Televizyon",
                "Projekt�r", "DVD oynat�c�", "Blu-ray oynat�c�", "Dijital foto�raf makinesi",
                "Videokamera", "MP3 �alar", "Hoparl�r seti", "Mikrofon", "DJ ekipman�", "Gitar",
                "Bateri", "Piyano", "Synthesizer", "Miksaj masas�", "Dinamik mikrofon", "Kondenser mikrofon"
            };

            Array.Sort(products);

            for (var i = 0; i < products.Length; i++)
            {
                listBox1.Items.Add(products[i]);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                btnRemoveCard.Enabled = true;
            }
            else
            {
                MessageBox.Show("�ncelikle bir �r�n se�melisin !");
            }
        }

        private void btnRemoveCard_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
                listBox1.Sorted = true;
                
            }
            else
            {
                MessageBox.Show("�ncelikle bir �r�n se�melisin !");
            }

            if (listBox2.Items.Count == 0)
            {
                btnRemoveCard.Enabled = false;
            }


        }
    }
}