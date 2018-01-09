using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void clickButton_Click(object sender, EventArgs e)
        {
            string firstWord = wordOneTextBox.Text;
            string secondWord = wordTwoTextBox.Text;

            string result = "Learning C# is " + firstWord + ", and I am a " + secondWord + " student!";
            madLibLabel.Text = result;
        }
    }
}