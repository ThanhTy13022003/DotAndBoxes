namespace GameDotsandBoxes
{
    public partial class frmDotAndBox : Form
    {
        public frmDotAndBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRule rule = new frmRule();
            rule.ShowDialog();
            rule = null;
            this.Show();
        }
    }
}