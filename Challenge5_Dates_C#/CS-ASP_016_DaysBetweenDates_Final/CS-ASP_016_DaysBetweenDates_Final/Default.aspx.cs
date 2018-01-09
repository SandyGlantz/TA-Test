using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_016_DaysBetweenDates_Final
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        // =====  outputs selected dates to screen  ===== 
        protected void cal1_SelectionChanged(object sender, EventArgs e)
        {  date1Label.Text = cal1.SelectedDate.ToShortDateString();  }

        protected void cal2_SelectionChanged(object sender, EventArgs e)
        {  date2Label.Text = cal2.SelectedDate.ToShortDateString();  }


        

        protected void okButton_Click(object sender, EventArgs e)
        {

            /* =====  SG version =====
             * 
            // clears the label if second run done
            resultLabel.Text = " ";

            // sets the two dates
            DateTime day1 = cal1.SelectedDate;
            DateTime day2 = cal2.SelectedDate;

            var daysSpan = day1.Subtract(day2);
            // The line below works ... just tried another approach
            // int days = daysSpan.Days;
            // Another approach:
            var days = (int) daysSpan.TotalDays;


            if (days < 0) 
                days = days * (-1); 
            else if (days >= 0) 
                days = days * 1; 


            resultLabel.Text = days.ToString();

            ===== End SG version =====
            */

            // School solution version:
            // I added in the equal in " >= " to account for 0
            // ok to move parts of long line to next line, before the period

            if (cal1.SelectedDate >= cal2.SelectedDate)
            {  resultLabel.Text = cal1.SelectedDate
                   .Subtract(cal2.SelectedDate).TotalDays.ToString();  }

            else 
            {  resultLabel.Text = cal2.SelectedDate
                   .Subtract(cal1.SelectedDate).TotalDays.ToString();  }

        }


    }
}