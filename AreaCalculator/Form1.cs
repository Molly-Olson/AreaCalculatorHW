using System.CodeDom.Compiler;

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
           
            //if (!Validators.IsMinimumLength(txtWidth.Text, 1) ||
            //    !Validators.IsMinimumLength(txtHeight.Text, 1)
            //    )
            //{
            //   var result = MessageBox.Show(
            //       "Your values are not valid. Please try again.", 
            //       "Error.", 
            //       MessageBoxButtons.OKCancel
            //       );

            //    if (result == DialogResult.OK)
            //    {
            //        MessageBox.Show("I am pleased you are ok with it.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Cancelling...");
            //    }
            //        return;
            //}
            if (ValidateFeild(txtWidth.Text, "The Width Feild is too short.")
            ////    ValidateFeild(txtHeight.Text, "The Height Field is too short.")
                )
            {
                return;
            }
            // this is splitting the command however we can use DeMorgan's Law instead
            if (ValidateFeild(txtHeight.Text, "The Height Field is too short."))
            {
                return;
            }
            //calculate the width x the height and change the total lable to match.
            int total = (int.Parse(txtWidth.Text)) * (int.Parse(txtHeight.Text));

            //change total label to match.
            lblTotal.Text = "Total: " + total.ToString();
            

        }
        private bool ValidateFeild(string feild, string errorMessage)
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
