namespace ListsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> students;

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string>() {
                "Ahmet Yýlmaz", "Mehmet Kaya", "Ayþe Can", "Kemal Özkan", "Fatma Çelik",
                "Osman Aydýn", "Nur Yýldýz", "Hakan Kara", "Emine Ata", "Kadir Günay",
                "Bilge Þahin", "Levent Öztürk", "Seda Yýldýrým", "Yasin Yalçýn", "Ceren Aktaþ",
                "Utku Özdemir", "Ýpek Erdoðan", "Fýrat Aksoy", "Özge Göçer", "Tolga Özbek"
            };

            foreach (string student in students)
            {
                listBox1.Items.Add(student);
            }
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length >= 2)
            {
                students.Add(textBox1.Text);
                listBox1.Items.Clear();
                foreach (string student in students)
                {
                    listBox1.Items.Add(student);
                }
            }
            else
            {
                MessageBox.Show("Öðrenci ismi en az 2 karakter olmadýlýr.");
            }
   
        }

        private void btnRemoveStudents_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                students.Remove(listBox1.SelectedItem.ToString());
                listBox1.Items.Clear();
                foreach (string student in students)
                {
                    listBox1.Items.Add(student);
                }
            }
        }
    }
}