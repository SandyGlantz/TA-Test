using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_028
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

   

        //  this is the event handler with the Helper Method (calculateCups)
        //   ... causes calculations when clicked
        //   
        protected void cupsRadio_CheckedChanged(object sender, EventArgs e)
        {  calculateCups(1.0, "cup(s)");  }
        /*  calculateCups() replaces all this: ... previously:
         {  if (quantityTextBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(quantityTextBox.Text, out quantity))
                return;

            resultLabel.Text = "The number of cups: " + quantity.ToString();  }  */

        protected void fromPintsRadio_CheckedChanged(object sender, EventArgs e)
        {  calculateCups(2.0, "pints");  }

        protected void fromQuartsRadio_CheckedChanged(object sender, EventArgs e)
        {  calculateCups(4.0, "quarts");  }

        protected void fromGallonsRadio_CheckedChanged(object sender, EventArgs e)
        {  calculateCups(16.0, "gallons");  }


        protected void quantityTextBox_TextChanged(object sender, EventArgs e)
        // This went away when calculateCups() added input params (double measureToCupRatio)
        // { calculateCups();  }
        { }



        // this is a Helper Method ... 
        //  private = hidden, encapsulated, under the hood
        //  void = no return value by itself ... returns value when called/invoked

        private void calculateCups(double measureToCupRation, string measureName)
        {       //  .Trim removes all spaces from text

            if (quantityTextBox.Text.Trim().Length == 0)
                // adding this line broke the program :-/ ??
                // tried adding (at top) resultLabel.Text = ""
                // tried putting it after return ...
                // resultLabel.Text = "Please enter a quantity";
                return;


            double quantity = 0.0;
            // ========  MAGIC  ======== 
            //   (wondered where this was/ how to do in previous lessons)
            //   this code keeps user input from breaking program.
            //   also ensures the value is int (double, etc)
            //   "out" returns second value ... first is bool/T-F (TryParse), 
            //      second value is amount/quantity
            if (!Double.TryParse(quantityTextBox.Text, out quantity))
                return;


            /*   ========  This sectopn replaced w/ input parameter(s) added to calculateCups()
            //   calculateCups() became calculateCups(double measureToCupRatio, string measureName)
            //     
            double cups = 0.0;
            // does the math depending on which radio checked
            //   fromCupsRadio is the group name
            if (fromCupsRadio.Checked) cups = quantity;
            else if (fromPintsRadio.Checked) cups = quantity * 2;
            else if (fromQuartsRadio.Checked) cups = quantity * 4;
            else if (fromGallonsRadio.Checked) cups = quantity * 16;
            */
            //  this part edited due to new inout params
            double cups = quantity * measureToCupRation;

            resultLabel.Text = String.Format("{0:N2} {1} converts to {2:N2} cups. ",
                quantity, measureName, cups);

        }
    }
}