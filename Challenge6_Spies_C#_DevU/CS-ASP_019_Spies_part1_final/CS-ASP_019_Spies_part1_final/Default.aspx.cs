using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019_Spies_part1_final
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lastEndDateCal.SelectedDate = DateTime.Now;
                //".Date" REQ'd to add number of days unless done EXACTLY at midnight
                firstNewCal.SelectedDate = DateTime.Now.Date.AddDays(14);
                endNewCal.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            // clears the label if second run done
            resultLabel.Text = " ";

            if (firstNewCal.SelectedDate
                .Subtract(lastEndDateCal.SelectedDate).TotalDays < 13)
            {
                resultLabel.Text = "Invalid request: There must be at least two weeks between" 
                    + " the end of previous assignment, and the start of the new assignment.";
                firstNewCal.SelectedDate = lastEndDateCal.SelectedDate.Date.AddDays(14);
                endNewCal.SelectedDate = firstNewCal.SelectedDate.Date.AddDays(3);
            }

            else if (endNewCal.SelectedDate
                .Subtract(firstNewCal.SelectedDate).TotalDays > 21)
            {
                //double required to work with .Subtract
                double dWorked = endNewCal.SelectedDate
                    .Subtract(firstNewCal.SelectedDate).TotalDays;
                //formatting only works with int ... casting:
                int daysWorked = (int)dWorked;
                int pay = (daysWorked * 500) + 1000;

                string result = String.Format("Assignment of {0} " 
                    + "to {1} is authorized.  Budget total: {2:C}",
                    codeNameTextBox.Text, assignmentTextBox.Text, pay);

                resultLabel.Text = result;
            }

            else
            {
                double dWorked = endNewCal.SelectedDate
                    .Subtract(firstNewCal.SelectedDate).TotalDays;
                //formatting only works with int ... casting:
                int daysWorked = (int)dWorked;
                int pay = daysWorked * 500;

                string result = String.Format("Assignment of {0} "
                    + "to {1} is authorized.  Budget total: {2:C}",
                    codeNameTextBox.Text, assignmentTextBox.Text, pay);

                resultLabel.Text = result;
            }




        }
    }
}