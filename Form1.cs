namespace Massage_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Kamu Puasa Full ?", "Attention", MessageBoxButtons.YesN0, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Selamat kamu anak sholeh");
            }else if (result == DialogResult.No)
            {
                MessageBox.Show("Udah gede ga puasa!");
            }
        }
    }
}
