using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_011
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = ""; //This sets the default to empty

            // ================EXAMPLE 1--comparison;If/Else================
            // note: MISSING catchall for bad data in this example
            /*
            if (firstTextBox.Text == secondTextBox.Text)
            {  resultLabel.Text = "Yes!  They're equal!";  }
            else
            {  resultLabel.Text = "No! They're not equal!";  }
            */


            // ================EXAMPLE 2--Checkbox================
            /*
            if (coolCheckBox.Checked) // same as: if (coolCheckBox.Checked == true)
            {  resultLabel.Text = "Yes, you are definitely cool.";  }
            else
            {  resultLabel.Text = "Don't be so hard on yourself.";  }
            */


            // ================EXAMPLE 3--RadioButtons--GroupProperties================
            /*
            if (pizzaRadioButton.Checked) // same as: if (pizzaRadioButton.Checked == true)
            {  resultLabel.Text = "You must be from Chicago!";  }
            else if (saladRadioButton.Checked)
            {  resultLabel.Text = "You are very smart, wise, and healthy!";  }
            else if (pbjRadioButton.Checked)
            {  resultLabel.Text = "You must be a fun loving person!";  }
            else
            {  resultLabel.Text = "Please select one of the options.";  }
            */


            // ================EXAMPLE 4--Ternary: 2-choice options================
            /* mini Example 4:
            resultLabel.Text = (firstTextBox.Text == secondTextBox.Text) ? "Yes" : "nope";
            */

            /* second Example 4/Ternary:
            resultLabel.Text = (oldCheckBox.Checked)
                ? "You are wise and experienced!"
                : "Please mow my lawn!";
            */

            // third Example 4/Ternary... useful for scoring:
            int result = (firstTextBox.Text == secondTextBox.Text) ? 100 : 0;
            resultLabel.Text = result.ToString();



        }
    }
}