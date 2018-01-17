using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValuesTest
{

// ========== NOTE:  Works as all doubles ... OR ... all ints



    public partial class Default : System.Web.UI.Page
    {

        double startBalance, totalCalc, newBalance;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double startBalance = 0;
                //startingTotalLabel.Text = startBalance.ToString();
                double newBalance = 0;
                newTotalLabel.Text = newBalance.ToString();
            }
        }

        // this works as public or private
        private void calcs()
        {
            // pulling starting balance
            double startBalance = double.Parse(newTotalLabel.Text);

            // pulling numbers to add
            double num1 = double.Parse(num1TextBox.Text);
            double num2 = double.Parse(num1TextBox.Text);

            // getting the current calc
            double totalCalc = num1 + num2;
            thisCalcTotalLabel.Text = totalCalc.ToString();

            // getting the new total
            double newBalance = startBalance + totalCalc;
            newTotalLabel.Text = newBalance.ToString();      }



        protected void okButton_Click(object sender, EventArgs e)
        {
            calcs();
        }
    }
}