using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewButtonCommand
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cars = new List<Car>() {
                new Car { CarId=Guid.NewGuid(), Make="BMW", Model="528i", Year=2010 },
                new Car {CarId=Guid.NewGuid(), Make="Toyota", Model="4Runner", Year=2010},
                new Car {CarId=Guid.NewGuid(), Make="Hyundai", Model="Elantra", Year=2013}
            };


            GridView1.DataSource = cars;
            GridView1.DataBind();


        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // This determines what was selected ... array based = 0 is the first row
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView1.Rows[index]; // GridViewRow could just be "var"

            // Considered risky because indivual cells are referenced ... if the grid is ever changed - this is messed up
            var make = row.Cells[1].Text;
            var model = row.Cells[3].Text;
            var value = row.Cells[4].Text;

            // instructor says this next line will come in handy for the pizza final project
            // hint is that you will want to convert it to it's original type of INT
            // in this example the original type is GUID 
            var carId = Guid.Parse(value);

            resultLabel.Text = $"{make} {model} {carId}";
            // SG NOTE:  The GUID CHANGED evey time this was run



        }
    }

    public class Car 
    {
        public Guid CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}