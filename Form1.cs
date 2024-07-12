namespace Latih12_MDIForm
{
    public partial class Form1 : Form
    {
        public Child anakk;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TampilAnakForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anakk.Close();

            foreach (Form anak in this.MdiChildren)
            {
                anak.Close();
            }
        }

        public void TampilAnakForm()
        {
            anakk = new Child();
            anakk.MdiParent = this;
            anakk.Show();
        }
    }
}
