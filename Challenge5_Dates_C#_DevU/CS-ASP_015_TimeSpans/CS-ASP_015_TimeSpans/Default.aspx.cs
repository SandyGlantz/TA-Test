using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_015
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            
            // This creates an amount of time spanned
            TimeSpan myTimeSpan = TimeSpan.Parse("1.2:3:30.5");
            // Format = Days.Hours:Minutes:Seconds.Milliseconds
            // More at:    http://is.gd/timespan




            // This creates the first point in time:
            DateTime myBirthday = DateTime.Parse("9/14/1969");
            // And this is the second time - so there is a time span
            // Key is subtract method
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            // The above creates the span object
            // then, (below) you can get parts out of the object (the span)

            // Returns the hour count since 12:00AM (0:00)
            resultLabel.Text = myAge.Hours.ToString();

            // TotalDays returns a Double ... includes fractions of hours
            resultLabel.Text = myAge.TotalDays.ToString();
            

        } 
    }
}