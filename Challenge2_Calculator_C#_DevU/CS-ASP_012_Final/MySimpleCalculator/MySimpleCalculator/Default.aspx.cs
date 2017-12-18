using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string nText1 = firstNumTextBox.Text;
            double num1 = double.Parse(nText1);
            string nText2 = secondNumTextBox.Text;
            double num2 = double.Parse(nText2);

            double r = num1 - num2;
            resultLabel.Text = r.ToString();
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            string nText1 = firstNumTextBox.Text;
            double num1 = double.Parse(nText1);
            string nText2 = secondNumTextBox.Text;
            double num2 = double.Parse(nText2);

            double r = num1 + num2;
            resultLabel.Text = r.ToString();
        }

        protected void multiButton_Click(object sender, EventArgs e)
        {
            string nText1 = firstNumTextBox.Text;
            double num1 = double.Parse(nText1);
            string nText2 = secondNumTextBox.Text;
            double num2 = double.Parse(nText2);

            double r = num1 * num2;
            resultLabel.Text = r.ToString();
        }

        protected void diviButton_Click(object sender, EventArgs e)
        {
            /*    string nText1 = firstNumTextBox.Text;
                double num1 = double.Parse(nText1);
                string nText2 = secondNumTextBox.Text;
                double num2 = double.Parse(nText2);

                double r = num1 / num2;
                resultLabel.Text = r.ToString();  */

      // Instructor version:
      // Consolidated actions = fewer lines code, fewer variables
            double num1 = double.Parse(firstNumTextBox.Text);
            double num2 = double.Parse(secondNumTextBox.Text);
            double r = num1 / num2;
            resultLabel.Text = r.ToString();
        }     
         
    }
}