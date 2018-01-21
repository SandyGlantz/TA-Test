using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_35_StringManipulation_Lesson
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
//  ==========    use \ (an "escape" character) for double quotes:

 /*           outputLabel.Text =
                "<p style =\"color:#0000FF;\">\"Phun\" sounds like \"fun\"</p>" +
                "  but it's not the same";
*/


//  ==========    access specific characters and attributes:
            string inputValue = inputTextBox.Text;
            // input entered was: Senge Alexander Sterling is my cat.
            
            //strings are arrays in memory ...
            outputLabel.Text = inputValue[0].ToString();

            // StartsWith(), EndsWith(), Contains() ...
            if (inputValue.StartsWith("S"))
                outputLabel.Text += "<br />The first character is \"S\"";
            else outputLabel.Text += "<br />The first character is NOT \"S\"";

            if (inputValue.EndsWith("."))
                outputLabel.Text += "<br />The last character is \".\"";

            else outputLabel.Text += "<br />The last character is NOT \".\"";
            if (inputValue.Contains("cat"))
                outputLabel.Text += "<br />The word \"cat\" is in the sentence.";


            // IndexOf()
            int selectedTextIndex = inputValue.IndexOf("cat");
            outputLabel.Text += "<br />The word \"cat\" begins at index "
                + selectedTextIndex.ToString();

           // Insert, Remove
            outputLabel.Text += "<br />" 
                + inputValue.Insert(selectedTextIndex, "Balinese (furry Siamese) ");
                //returns: Senge Alexander Sterling is my Balinese(furry Siamese) cat.
            outputLabel.Text += "<br />"
                + inputValue.Remove(selectedTextIndex, inputValue.Length 
                - selectedTextIndex);
                //returns: Senge Alexander Sterling is my


            // Substring
            outputLabel.Text += "<br />" 
                + inputValue.Substring(selectedTextIndex, 
                inputValue.Length - selectedTextIndex - 1);
                //returns: cat   ... the -1 removes the period at the end


            // Trim(), TrimStart(), TrimEnd()
            outputLabel.Text += String.Format("<br />Length before: {0}"
                + "<br />Length after: {1}", inputValue.Length,
                inputValue.Trim().Length);
                //result: takes off spaces before or after first and last characters
                //     it does NOT take out spaces between words.


            // PadLeft(), PadRight() ... 
            //  NOTE!! a char (character data type) uses single quotes ' '
            //  MUST be a char - not a string - so only a single item
            outputLabel.Text += "<br />" + inputValue.PadLeft(50, '>');
            outputLabel.Text += "<br />" + inputValue.PadLeft(50, 'm');


            // ToUpper(), ToLower() ... this normalizes the data
            inputValue = "  senge  ";
            outputLabel.Text += "<br />" + inputValue.Trim().ToUpper();
            outputLabel.Text += "<br />" + inputValue.ToLower();
            inputValue = inputTextBox.Text; // returning to text input


            // Replace() ...will be used often to clean up data from other sources
            // these **all** work
            string template = "<br />[INSERT] He has light blue eyes.";
            outputLabel.Text += template.Replace("[INSERT]", inputTextBox.Text);
            template = "<br />{insert}  He is very smart.";
            outputLabel.Text += template.Replace("{insert}", inputTextBox.Text);
            template = "<br />INSERT  He helps me code.";
            outputLabel.Text += template.Replace("INSERT", inputTextBox.Text);


            // Split() ... used to make an array based on key characters
            inputValue = "Senge,Alexander,Sterling";
            string splitResult = "";
            string[] newInputValues = inputValue.Split(',');
            for (int i = 0; i < newInputValues.Length; i++)
            {   splitResult += newInputValues[i] + " "
                    + newInputValues[i].Length + "<br />";      }
            outputLabel.Text += "<br />" + splitResult;
                //returns: Senge 5    Alexander 9    Sterling 8 
                // numbers are number of letters in name
            inputValue = inputTextBox.Text; // returning to text input


            // StringBuilder() ... 
                // allows for better use of memory ... important.
                // watch for drop down options - use "using System.Text
                // adds line at top (using System.Text;) and a lot of code
                // !! use with more than a couple dozen changes !!
                // same code as above with changes ...

            inputValue = "Senge,Alexander,Sterling";
            //string splitResult = "";
            StringBuilder sb = new StringBuilder();
            string[] newInputValuesSB = inputValue.Split(',');
            for (int i = 0; i < newInputValuesSB.Length; i++)
            {
                //splitResult += newInputValuesSB[i] + " "
                //    + newInputValuesSB[i].Length + "<br />";

                sb.Append(newInputValuesSB[i]);
                sb.Append(" ");
                sb.Append(newInputValuesSB[i].Length);
                sb.Append("<br />");
            }
            //outputLabel.Text += "<br />" + splitResult;
            outputLabel.Text += "<br />" + sb.ToString();
 
            inputValue = inputTextBox.Text; // returning to text input


        }
    }
}