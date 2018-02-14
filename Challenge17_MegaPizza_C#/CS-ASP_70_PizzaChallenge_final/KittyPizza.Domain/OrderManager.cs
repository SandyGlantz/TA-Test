using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittyPizza.Domain
{
    public class OrderManager
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            if (orderDTO.Name.Trim().Length==0)
            {  throw new Exception("It would help if you entered a name ...");  }

            if (orderDTO.Address.Trim().Length == 0)
            { throw new Exception("Unless you want us to eat your pizza, we need an address."); }

            if (orderDTO.Zip.Trim().Length == 0)
            { throw new Exception("Zippy-do-da ... we need your Zip Code, please."); }

            if (orderDTO.Phone.Trim().Length == 0)
            { throw new Exception("It's so... last century - but we need your phone number!"); }


            orderDTO.OrderId = Guid.NewGuid();
            orderDTO.TotalCost = PizzaPriceManager.CalculateCost(orderDTO);

            Data.OrderRepository.CreateOrder(orderDTO);

        }

        public static void CompleteOrder(Guid orderId)
        {
            Data.OrderRepository.CompleteOrder(orderId);
        }


        // +L9
        public static object GetOrders()
        {
            return Data.OrderRepository.GetOrders();
        }
    }
}
