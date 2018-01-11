using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_034_PostageCalc_final


{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {  resultLabel.Text = "";  }


        // setting the variables 
        // I didn't use these as params because of the textbox auto update condondrum
        double width = 0.0;
        double height = 0.0;
        double length = 0.0;



        // updates info when a button is selected or text is changed
        protected void checkForInputChange(object sender, EventArgs e)
        { calculatePostage(); }



        private void specialButterflyLength()
        {
            // length ... the special butterfly ... 
            //    not required for input calculation, but value included if input
            if (lengthTextBox.Text.Trim().Length == 0)
                length = 1.0;
            else if (!Double.TryParse(lengthTextBox.Text, out length))
                return;
        }



        private void calculatePackageSize()
        {   
            // assure that width and height have values
            if (widthTextBox.Text.Trim().Length == 0)
                return;
            if (heightTextBox.Text.Trim().Length == 0)
                return;

            //collect req'd width and height values
            if (!Double.TryParse(widthTextBox.Text, out width))
                return;
            if (!Double.TryParse(heightTextBox.Text, out height))
                return;           
        }




        private void calculatePostage()
        {
            //input
            specialButterflyLength();
            calculatePackageSize();
            double totalPackageSize = width * height * length;
            double postage = 0.0;

            // calculate the postage ...
            if (groundRadioButton.Checked) postage = totalPackageSize * 0.15;
            else if (airRadioButton.Checked) postage = totalPackageSize * 0.25;
            else if (nextDayRadioButton.Checked) postage = totalPackageSize * 0.45;


            // output
            resultLabel.Text = String.Format("The postage for this package is $"
                            + "{0:N2}", postage);
        }
    }
}