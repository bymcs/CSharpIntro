using System.Threading;

namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MessageBox.Show($"thread : {Thread.CurrentThread.ManagedThreadId}");
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep( 5000 );
            MessageBox.Show($"thread : {Thread.CurrentThread.ManagedThreadId}");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"thread : {Thread.CurrentThread.ManagedThreadId}");



        }
    }
}