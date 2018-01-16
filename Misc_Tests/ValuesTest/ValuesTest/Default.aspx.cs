using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValuesTest
{
    public partial class Default : System.Web.UI.Page
    {

        int startBalance, totalCalc, newBalance;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int startBalance = 0;
                //startingTotalLabel.Text = startBalance.ToString();
                int newBalance = 0;
                newTotalLabel.Text = newBalance.ToString();
            }
        }

        // this works as public or private
        private void calcs()
        {
            // pulling starting balance
            int startBalance = int.Parse(newTotalLabel.Text);

            // pulling numbers to add
            int num1 = int.Parse(num1TextBox.Text);
            int num2 = int.Parse(num1TextBox.Text);

            // getting the current calc
            int totalCalc = num1 + num2;
            thisCalcTotalLabel.Text = totalCalc.ToString();

            // getting the new total
            int newBalance = startBalance + totalCalc;
            newTotalLabel.Text = newBalance.ToString();      }



        protected void okButton_Click(object sender, EventArgs e)
        {
            calcs();
        }
    }
}