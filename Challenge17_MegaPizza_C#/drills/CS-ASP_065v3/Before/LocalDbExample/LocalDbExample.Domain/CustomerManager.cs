using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalDbExample;

namespace LocalDbExample.Domain
{
    public class CustomerManager
    {
        public static List<DTO.Customer> GetCustomers()  
        {
            var customers = Persistence.CustomersRespository.GetCustomers();
            return customers;
        }

        public static void AddCustomer(DTO.Customer customer) // alt pass in Name, Address, etc.
        {
            try
            {
                // passes the customer to the persistence layer
                // this is unnecessary for small apps
                Persistence.CustomersRespository.AddCustomer(customer);
            }
            catch (Exception)
            {
                // logging would go here
                throw;
            }

            
             
        }
    }
}
