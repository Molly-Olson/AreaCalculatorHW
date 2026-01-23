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
            if (ValidateField(txtWidth.Text, "The Width Feild is too short."))
            {
                return;
            }

            if (ValidateField(txtWidth.Text, "The Height Field is too short."))
            {
                return;
            }

            if (!Validators.ContainsInteger(txtWidth.Text, out int width))
            {
                MessageBox.Show("Width does not contain a number fool! Try again my dude.");
            }

            try
            {
                throw new Exception("This is a toast error...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //calculate the width x the height
            int total = width * Height;

            //change the toatal label to match
            lblTotal.Text = "Total: " + total.ToString();
        }

        private bool ValidateField(string feild, string errorMessage)
        { 
            var result = !Validators.IsMinimumLength(feild, 1);

            if (result)
            {
                var dialogResult = MessageBox.Show(
                    errorMessage,
                    "Error."
                    );
            }

                return result;
        }
    }
}
