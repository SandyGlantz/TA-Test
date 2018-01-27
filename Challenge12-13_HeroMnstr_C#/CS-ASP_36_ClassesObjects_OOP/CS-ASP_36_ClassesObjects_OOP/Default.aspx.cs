using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_36_ClassesObjects_OOP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car myNewCar = new Car();

            //setting the properties
            myNewCar.Make = "Toyota";
            myNewCar.Model = "Prius";
            myNewCar.Year = 2010;
            myNewCar.Color = "Grey";

            // when method determineMarketValue moved to class Car
            //  the method red squiggles and does not exist in current  context
            // this line was from the first two versions
            //double myMarketValueOfCar = determineMarketValue(myNewCar);
            // this line is from the version with the method (determineMarket ...) 
            //     inside Car class
            double myMarketValueOfCar = myNewCar.DetermineMarketValue();

            //getting the (values of) the properties
            resultLabel.Text = string.Format("{0} - {1} - {2} - {3} - {4:C}",
                myNewCar.Make, myNewCar.Model, myNewCar.Year, myNewCar.Color, 
                myMarketValueOfCar);
        } // end class Page_Load


/* third version moves this method to Car class
        private double determineMarketValue(Car car)
        // since class Car is defining a data type 
        // - passing in the class and the instance
        //   like passing in int whateverintValueVarname
        {
            // this was the first version:
            //double carValue = 100.0;
            // version2 = use kbb ...
            //    retrieve value and pass in place of 100
            //return carValue;

            // second version with a formula:
            double carValue;

            if (car.Year > 1990)
                carValue = 7500.0;
            else carValue = 2500.0;

            return carValue;
*/
        } // end class Default

    }  //end class namespace



    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


    // moved method determineMarketValue, from class Page_Load:
    // changed private to public
    // capitalize the D at the beginning (because public)
    // replace "  (Car car) " passed into outside class method (now commented out), 
    //      and inside its class used with " this " (optional for functionality)
    // NOTE: * this *  isn't needed ... but good for clarity
    // sg NOTE: intellisense suggests " this " be removed
    // sg note: when Car car was left in:
    //      " this " still works and is still considered to not be simplified

    public double DetermineMarketValue()
    {
        double carValue;

        
        if (this.Year > 1990)
            carValue = 7500.0;
        else carValue = 2500.0;

        return carValue;
    }


}  //end class car