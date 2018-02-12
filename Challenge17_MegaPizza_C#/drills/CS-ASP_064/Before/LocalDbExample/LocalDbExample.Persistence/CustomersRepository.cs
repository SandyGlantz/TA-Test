using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDbExample.Persistence
{
    public class CustomersRepository
    {
        // The class name of the .Persistence Solution should include "Repository" at the end
        //      

        public static List<DTO.Customer> GetCustomers()
        {
            ACMEEntities db = new ACMEEntities();
            // this gets the list of customers and puts it into a variable
            var dbCustomers = db.Customers.ToList(); 

            //this starts the setting up of the list to the DTO
            var dtoCustomers = new List<DTO.Customer>();

            // this goes through every customer and creates a dto object (~dto.customer)
            foreach (var dbCustomer in dbCustomers)
            {
                var dtoCustomer = new DTO.Customer();

                dtoCustomer.CustomerId = dbCustomer.CustomerId;
                dtoCustomer.Name = dbCustomer.Name;
                dtoCustomer.Address = dbCustomer.Address;
                dtoCustomer.City = dbCustomer.City;
                dtoCustomer.State = dbCustomer.State;
                dtoCustomer.PostalCode = dbCustomer.PostalCode;
                dtoCustomer.Notes = dbCustomer.Notes;

                dtoCustomers.Add(dtoCustomer);
            }

            //return dbCustomers;

            // this returns the lost now in the dto layer to the presentation layer
            return dtoCustomers;


        }



    }
}
