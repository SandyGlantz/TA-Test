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


        // creates the update of the info when a button is selected
        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        { calculatePostage(); }
        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        { calculatePostage(); }
        protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
        { calculatePostage(); }

        // creates the update of the info when a text box is changed
        protected void widthTextBox_CheckedChanged(object sender, EventArgs e)
        { calculatePostage(); }
        protected void heightTextBox_CheckedChanged(object sender, EventArgs e)
        { calculatePostage(); }
        protected void lengthTextBox_CheckedChanged(object sender, EventArgs e)
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
            specialButterflyLength();
            calculatePackageSize();
            double totalPackageSize = width * height * length;
            double postage = 0.0;

            // calculate the postage ...
            if (groundRadioButton.Checked) postage = totalPackageSize * 0.15;
            else if (airRadioButton.Checked) postage = totalPackageSize * 0.25;
            else if (nextDayRadioButton.Checked) postage = totalPackageSize * 0.45;
            // note: if I included the multiplier into the radio as a param - using DRY ...
            //     then the text box doesn't auto recalc 
            //     because it didn't have a param to use            
            // in a perfect world - this would have worked ...
            //postage = (width * height * length) * multiplier;


            resultLabel.Text = String.Format("The postage for this package is $"
                            + "{0:N2}", postage);
        }
    }
}