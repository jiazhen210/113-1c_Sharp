namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true;
            ptxfront.Visible = false;
        }

        private void btnfront_Click(object sender, EventArgs e)
        {
            ptxback.Visible = false;
            ptxfront.Visible = true;
        }
    }
}
