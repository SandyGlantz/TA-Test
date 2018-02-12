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
        // The class name of the .Domain Solution should include "Manager" at the end  
        //    

        public static List<DTO.Customer> GetCustomers()
        {
            var customers = Persistence.CustomersRepository.GetCustomers();
            return customers;
        }

    }
}
