using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_014
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {

            
             // ===== Create the variable with the datatype: ===== 
             DateTime myValue = DateTime.Now;


             //  ===== Convert DateTime datatype ===== 
             resultLabel.Text = myValue.ToString();
             // returns 12/22/17 12:38:57 AM


             // =====  These are a few of the methods ===== 

             resultLabel.Text = myValue.ToLongDateString();
             // returns December 22, 2017
             // NOTE: Instructor's ToLongDateString includes day of week at beginning

             resultLabel.Text = myValue.ToLongTimeString();
             // returns 12:47:35 AM

             resultLabel.Text = myValue.ToShortDateString();
             // returns 12/22/17

             resultLabel.Text = myValue.ToShortTimeString();
             // returns 12:50 AM



             // ===== Add and subtract days--note chaining of methods ===== 

             resultLabel.Text = myValue.AddDays(2).ToString();
             // returns 12/24/17 12:52:35 AM (OMG ... Santa's almost here!!!)

             resultLabel.Text = myValue.AddMonths(-2).ToString();
             // returns 10/22/17 12:54:00 AM


             // ===== Isolates the month, day of week or year ===== 
             resultLabel.Text = myValue.Month.ToString();
             // returns 12

             resultLabel.Text = myValue.DayOfWeek.ToString();
             // returns Friday

             resultLabel.Text = myValue.DayOfYear.ToString();
             // retuns 356 

             // ===== Boolean return for DST T/F ===== 
             resultLabel.Text = myValue.IsDaylightSavingTime().ToString();



             // ===== Using a specified date for a variable ===== 

             DateTime myValue = DateTime.Parse("9/14/1969");
             resultLabel.Text = myValue.ToLongDateString();
             // returns September 14, 1969
             // NOTE: Instructors version included day of week (Sunday, September 14, 1969)
             resultLabel.Text = myValue.DayOfWeek.ToString();
             // returns Monday


            // ===== alternate way to specify date variable ===== 
            DateTime myValue = new DateTime(1969, 9, 14, 10, 53, 0);
            resultLabel.Text = myValue.ToLongDateString();
            // returns September 14, 1969 ... DOES NOT INCLUDE hours, minutes ...

        }
    }
}