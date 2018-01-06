using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019_Spies_part2_final
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // no need for maintaining scroll position ... included for practice
            Page.MaintainScrollPositionOnPostBack = true;


            if (!Page.IsPostBack)
            {   // I used doubles instead of ints - allows for teams to take partial credits
                double[] electionsRigged = new double[0];
                ViewState.Add("electionsRiggedKey", electionsRigged); 

                double[] subterfugeActs = new double[0];
                ViewState.Add("subterfugeActsKey", subterfugeActs);

                // ?? I didn't need to put the code names into an array - because the data existed
            }

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //  =========  how to account for numbers not entered?  
            // ... text /string cannot be bool
            // ... figured out work around! :-)

            if (electRiggedTextBox.Text == "")
            { resultLabel.Text = "Please enter an Elections Rigged number," + 
                    "or '0' if none"; return; }
            if (subterfugeTextBox.Text == "")
            { resultLabel.Text = "Please enter a Subterfuge Acts number," +
                    "or '0' if none"; return; }
            if (assetNameTextBox.Text == "")
            { resultLabel.Text = "Please enter a code name"; return; }
            //*/


            //  =========  making sure the result label clears for each query
            resultLabel.Text = " ";


            //  =========  Requirement: Total Elections Rigged ... .Sum
            double[] electionsRigged = (double[])ViewState["electionsRiggedKey"];
            Array.Resize(ref electionsRigged, electionsRigged.Length + 1);
            int newestRigged = electionsRigged.GetUpperBound(0);
            electionsRigged[newestRigged] = double.Parse(electRiggedTextBox.Text);
            ViewState["electionsRiggedKey"] = electionsRigged;


            //  =========  Requirement: Average subterfuge acts via num.00 ... .Average
            // myArray.Average ... cast to double
            double[] subterfugeActs = (double[])ViewState["subterfugeActsKey"];
            Array.Resize(ref subterfugeActs, subterfugeActs.Length + 1);
            int newestsubterfugeActs = subterfugeActs.GetUpperBound(0);
            subterfugeActs[newestsubterfugeActs] = double.Parse(subterfugeTextBox.Text);
            ViewState["subterfugeActsKey"] = subterfugeActs;


            //  =========  Requirement: Last Asset Added ... assetNameTextBox exists at runtime
            string assetName = assetNameTextBox.Text;


            //  =========  Requirement: print out info/results to screen
            resultLabel.Text = String.Format("Total elections rigged: {0:N2}" + 
                "<br />Average acts of subterfuge across all assets: {1:N2}" + 
                "<br />(Last asset added: " + assetName + ")", 
                electionsRigged.Sum(), subterfugeActs.Average());



            //  =========  Cleanup for re-entry of asset info
            // originally had "0.0" to clear text boxes
            // ... couldn't figure out how to set it to not crash if nothing was entered 
            // ... figured out empty - but not data type restrictions :-/
            assetNameTextBox.Text = "";
            electRiggedTextBox.Text = "";
            subterfugeTextBox.Text = "";

        }
    }
}