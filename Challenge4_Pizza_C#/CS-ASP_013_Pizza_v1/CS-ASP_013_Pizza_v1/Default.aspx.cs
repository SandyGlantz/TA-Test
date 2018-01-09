using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_013_Pizza_v1
{
    public partial class Default : System.Web.UI.Page
    {
        private int size;
        private int crust;
        private int costTotal;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderButton_Click(object sender, EventArgs e)
        {

            resultLabel.Text = "";


            double size = 0;
            if (sm10RadioButton.Checked)
                { size = 10.00; }
            else if (med13RadioButton.Checked)
                { size = 13.00; }
            else if (lg16RadioButton.Checked)
                { size = 16.00; }
            

            double crust = 0;
            if (regCrust0RadioButton.Checked)
                { crust = 0.00; }
            else if (xtraCrust2RadioButton.Checked)
                { crust = 2.00; }


            /*
             * ===== Original toppings =====
             * 
            double toppings = 0;
            if (pepper15CheckBox.Checked)
                { toppings = toppings + 1.50; }
            if (onion075CheckBox.Checked)
                { toppings = toppings + 0.75; }
            if (grnPep050CheckBox.Checked)
                { toppings = toppings + .50; }
            if (redPep075CheckBox.Checked)
                { toppings = toppings + .75; }
            if (anch2CheckBox.Checked)
                { toppings = toppings + 2; }
            */

            /*
             * ===== Toppings; refactored v1 =====
             * 
            double toppings = 0;
            if (pepper15CheckBox.Checked)
                { toppings += 1.50; }
            if (onion075CheckBox.Checked)
                { toppings += 0.75; }
            if (grnPep050CheckBox.Checked)
                { toppings += .50; }
            if (redPep075CheckBox.Checked)
                { toppings += .75; }
            if (anch2CheckBox.Checked)
                { toppings += 2; }
            */


            /*
             * ===== Toppings; refactored v2 =====
             */
            double toppings = 0;
            if (pepper15CheckBox.Checked) toppings += 1.50;
            if (onion075CheckBox.Checked) toppings += 0.75;
            if (grnPep050CheckBox.Checked) toppings += .50; 
            if (redPep075CheckBox.Checked) toppings += .75; 
            if (anch2CheckBox.Checked) toppings += 2; 


            /*
            * ===== toppings; different approach, v3 =====
            * 
           double toppings = 0;
           toppings = (pepper15CheckBox.Checked) ? toppings + 1.5 : toppings;
           toppings = (onion075CheckBox.Checked) ? toppings + .75 : toppings;
           toppings = (grnPep050CheckBox.Checked) ? toppings + .5 : toppings;
           toppings = (redPep075CheckBox.Checked) ? toppings + .75 : toppings;
           toppings = (anch2CheckBox.Checked) ? toppings + 2 : toppings;
           */


            double specials = 0;
            if (pepper15CheckBox.Checked 
                && grnPep050CheckBox.Checked
                && anch2CheckBox.Checked)
                    { specials = -2; }
            else if (pepper15CheckBox.Checked
                && redPep075CheckBox.Checked
                && onion075CheckBox.Checked)
                    { specials = -2; }
            else
                { specials = 0; }



            double cost;
            cost = size + crust + toppings + specials;


            resultLabel.Text = cost.ToString();





            // ========= Instructor solution notes  ========= 
            /*
            1. refactored my code in toppings ... a couple times

            2. Instructor used one variable, "total" 
                and added to it all the way down

            3. Combined above in various versions
            */









        }
    }
}
