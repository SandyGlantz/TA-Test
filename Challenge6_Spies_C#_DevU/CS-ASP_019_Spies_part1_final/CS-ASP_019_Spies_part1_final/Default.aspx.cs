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
            // clears the label if additional runs done
            resultLabel.Text = " ";


            // ======== EXCEPTION ERROR MESSAGE ========

            // requirement: Must have two weeks between end of last mission and start of new
            // req: If less than two weeks - auto select the date minimum time on new cal
            if (firstNewCal.SelectedDate
                .Subtract(lastEndDateCal.SelectedDate).TotalDays < 13)
            {
                resultLabel.Text = "Invalid request: There must be at least two weeks between" 
                    + " the end of previous assignment, and the start of the new assignment.";
                firstNewCal.SelectedDate = lastEndDateCal.SelectedDate.Date.AddDays(14);
                // the line below not req'd but used as a courtesy to keep the dates close
                endNewCal.SelectedDate = firstNewCal.SelectedDate.Date.AddDays(3);
            }

            // they put exception later in process, at end (?) 
            // and used TimeSpan instead of simple difference to calc (??)
            // I like mine better on this
            // TimeSpan daysBetween = firstNewCal.SelectedDate.Subtract(lastEndDateCal.SelectedDate);
            // if (daysBetween.TotalDays < 14) { resultLabel.Text = "Error message, blah, blah"; }




            // ======== BONUS PAY + CALENDAR SUGGESTED DATES ========

            // req: $1k bonus on assignments over 21 days
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


            // ======== STANDARD PAY ========

            // req: compute $500/day cost for spy service
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

            
            // instructor solution similar except for:
            // I like this better ... fewer variables, more DRY
            TimeSpan daysWorked2 = endNewCal.SelectedDate
                .Subtract(firstNewCal.SelectedDate);
            double pay2 = daysWorked2.TotalDays * 500.0;
            if (daysWorked2.TotalDays > 21) { pay2 += 1000.0; }
 

            

        }
    }
}