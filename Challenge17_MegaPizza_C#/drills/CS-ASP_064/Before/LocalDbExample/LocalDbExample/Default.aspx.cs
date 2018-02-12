using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LocalDbExample;

namespace LocalDbExample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            ACMEEntities db = new ACMEEntities();

            var customers = db.Customers;

            string result = "";

            
            foreach (var customer in customers)
            {
                result += "<p>" + customer.Name + "</p>";
            }
            */


            // in the video this didn't have red squigglies but caused a "Metadata exception
            // mine had red squigglies
            // turned out it was pointing to the LOCAL db file
            //  which when deleted made the reds squiggles go away
            // .... until they came right back

            var customers = Domain.CustomerManager.GetCustomers();

            customersGridView.DataSource = customers.ToList();
            customersGridView.DataBind();

            //resultLabel.Text = result;
        }
    }
}