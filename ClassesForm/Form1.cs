namespace ClassesForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerManager customerManager = new CustomerManager();

        private void Form1_Load(object sender, EventArgs e)
        {

            

            dgrwCustomers.DataSource = customerManager.GetAll();
            dgrwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer();
            customer.Id = Convert.ToInt32(tbxId.Text);
            customer.FirstName = tbxFirstName.Text;
            customer.LastName = tbxLastName.Text;
            customer.Email = tbxEmail.Text;
            customer.City = tbxCity.Text;

            customerManager.Add(customer);

            dgrwCustomers.DataSource = null;
            dgrwCustomers.DataSource = customerManager.GetAll();
        }
    }
}