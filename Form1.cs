namespace Cmsc_437_Homework1_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About_You about_You =   new About_You();
            about_You.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About_Me about_Me = new About_Me();
            about_Me.ShowDialog();
        }
    }
}