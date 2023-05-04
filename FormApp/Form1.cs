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

            label1.Text = "Ürünler";
            label2.Text = "Sepet";
            btnAddToCart.Text = "Sepete Ekle";
            btnRemoveCard.Text = "Sepetten Çýkar";

            btnRemoveCard.Enabled = false;



            string[] products = new string[] {
                "Laptop", "Masaüstü PC", "Klavye", "Mouse", "Ekran", "Tarayýcý", "Yazýcý", "Hoparlör",
                "Kulaklýk", "Kamera", "Telefon", "Tablet", "Akýllý saat", "Oyun konsolu", "Televizyon",
                "Projektör", "DVD oynatýcý", "Blu-ray oynatýcý", "Dijital fotoðraf makinesi",
                "Videokamera", "MP3 çalar", "Hoparlör seti", "Mikrofon", "DJ ekipmaný", "Gitar",
                "Bateri", "Piyano", "Synthesizer", "Miksaj masasý", "Dinamik mikrofon", "Kondenser mikrofon"
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
                MessageBox.Show("Öncelikle bir ürün seçmelisin !");
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
                MessageBox.Show("Öncelikle bir ürün seçmelisin !");
            }

            if (listBox2.Items.Count == 0)
            {
                btnRemoveCard.Enabled = false;
            }


        }
    }
}