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
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
            if (!Validators.IsMinimumLength(txtWidth.Text, 1) ||
                !Validators.IsMinimumLength(txtHeight.Text, 1)
                )
            {               
                return;
            }
            //calculate the width x the height and change the total lable to match.
            int total = (int.Parse(txtWidth.Text)) * (int.Parse(txtHeight.Text));

            //change total label to match.
            lblTotal.Text = "Total: " + total.ToString();
            

        }
    }
}
