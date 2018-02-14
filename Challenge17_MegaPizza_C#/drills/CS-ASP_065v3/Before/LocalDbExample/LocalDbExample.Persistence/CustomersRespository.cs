using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDbExample.Persistence
{
    public class CustomersRespository
    {
        public static List<DTO.Customer> GetCustomers()
        {
            ACMEEntities db = new ACMEEntities();
            var dbCustomers = db.Customers.OrderBy(p => p.Name).ToList();

            var dtoCustomers = new List<DTO.Customer>();

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
            return dtoCustomers;
        }






        // this is a reverse of above
        public static void AddCustomer(DTO.Customer newCustomer)
        {
            ACMEEntities db = new ACMEEntities();
            // important to remove the ToList unlike above version
            var dbCustomers = db.Customers; ;

            var customer = new Customer();

            // need some validation here to prevent errors
            if (newCustomer.Name.Trim().Length ==0)
            {
                throw new Exception("Please enter a name");
                // other validation would go here
            }

            customer.CustomerId = newCustomer.CustomerId;
            customer.Name = newCustomer.Name;
            customer.Address = newCustomer.Address;
            customer.City = newCustomer.City;
            customer.State = newCustomer.State;
            customer.PostalCode = newCustomer.PostalCode;
            customer.Notes = newCustomer.Notes;

            try
            {
                dbCustomers.Add(customer);
                // without the following line the info is only kept in memory
                // not actually added the db
                // use this with add or delete (or update)
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                // log exception would go here (future lesson)
                throw ex;
            }


        }
    }
}
