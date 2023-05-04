namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Student ogrenci1 = new Student();
            ogrenci1.FirstName = "Test";
            ogrenci1.Age = 34;
            ogrenci1.Mail = "test@mail.com";


            Student ogrenci2 = new Student();
            ogrenci2.FirstName = "Mehmet Can";
            ogrenci2.Age = 16;
            ogrenci2.Mail = "mcs@mail.com";

            Student ogrenci3 = new Student();
            ogrenci3.FirstName = "Can Mehmet";
            ogrenci3.Age = 22;
            ogrenci3.Mail = "cancan@mail.com";

            List<Student> students = new List<Student>() { ogrenci1, ogrenci2, ogrenci3 };

            foreach (var student in students)
            {
                lbxStudents.Items.Add(student.FirstName);
            }

            dgrwStudents.DataSource = students;


        }
    }
}