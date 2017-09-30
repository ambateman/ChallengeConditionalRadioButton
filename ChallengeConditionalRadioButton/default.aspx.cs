using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (radBtnPen.Checked)
            {
                lblResult.Text = "You like to use pens.";
                imgDevice.ImageUrl = "pen.png";
            }
            else if (radBtnPencil.Checked) {
                lblResult.Text = "You like to use pencils.";
                imgDevice.ImageUrl = "pencil.png";

            }
            else if (radBtnPhone.Checked) {
                lblResult.Text = "You like to use phones.";
                imgDevice.ImageUrl = "phone.png";
            }
            else if (radBtnTablet.Checked){
                lblResult.Text = "You like to use tablets.";
                imgDevice.ImageUrl = "tablet.png";
            }
            else {
                lblResult.Text = "Please select your favorite tool for taking notes.";
            }


        }   
           



        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}