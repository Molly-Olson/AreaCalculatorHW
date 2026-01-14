namespace AreaCalculator
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            //load event, fires when form loads
            //change the text on the txtWidth to 314
            txtWidth.Text = "314";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
