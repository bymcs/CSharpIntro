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
                "Ahmet Y�lmaz", "Mehmet Kaya", "Ay�e Can", "Kemal �zkan", "Fatma �elik",
                "Osman Ayd�n", "Nur Y�ld�z", "Hakan Kara", "Emine Ata", "Kadir G�nay",
                "Bilge �ahin", "Levent �zt�rk", "Seda Y�ld�r�m", "Yasin Yal��n", "Ceren Akta�",
                "Utku �zdemir", "�pek Erdo�an", "F�rat Aksoy", "�zge G��er", "Tolga �zbek"
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
                MessageBox.Show("��renci ismi en az 2 karakter olmad�l�r.");
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