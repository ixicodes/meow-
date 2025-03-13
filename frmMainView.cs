namespace BusyBeezApplication
{
    public partial class frmMainView : Form
    {
        public frmMainView()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProfiling frm = new frmProfiling  ();
            frm.Show();
            this.Hide();

        }
    }
}
