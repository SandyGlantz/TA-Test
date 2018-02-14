using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KittyPizza.Data
{
    public class OrderRepository
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            var db = new KittyPizzaDbEntities();

            var order = convertToEntity(orderDTO);          
        
            db.Orders.Add(order);
            db.SaveChanges();
        }



        private static Order convertToEntity(DTO.OrderDTO orderDTO)
        {
            var order = new Order();

            //mapping:
            order.OrderId = orderDTO.OrderId;
            order.Size = orderDTO.Size;
            order.Crust = orderDTO.Crust;
            order.Mouse = orderDTO.Mouse;
            order.Goldfish = orderDTO.Goldfish;
            order.Catnip = orderDTO.Catnip;
            order.Grass = orderDTO.Grass;
            order.Name = orderDTO.Name;
            order.Address = orderDTO.Address;
            order.Zip = orderDTO.Zip;
            order.Phone = orderDTO.Phone;
            order.TotalCost = orderDTO.TotalCost;
            order.PaymentType = orderDTO.PaymentType;
            order.Completed = orderDTO.Completed;

            return order;
        }

        public static void CompleteOrder(Guid orderId)
        {
            var db = new KittyPizzaDbEntities();
            var order = db.Orders.FirstOrDefault(p => p.OrderId == orderId);
            order.Completed = true;
            db.SaveChanges();
        }


        // +L9
        public static List<DTO.OrderDTO> GetOrders()
        {
            var db = new KittyPizzaDbEntities();
            var orders = db.Orders.Where(p => p.Completed == false).ToList();
            var ordersDTO = convertToDTO(orders);
            return ordersDTO;           
        }


        private static List<DTO.OrderDTO> convertToDTO(List<Order> orders)
        {

            var ordersDTO = new List<DTO.OrderDTO>();

            foreach (var order in orders)
            {
                // more mapping
                var orderDTO = new DTO.OrderDTO();
                orderDTO.OrderId = order.OrderId;
                orderDTO.Name = order.Name;
                orderDTO.Address = order.Address;
                orderDTO.Zip = order.Zip;
                orderDTO.Phone = order.Phone;
                orderDTO.Crust = order.Crust;
                orderDTO.Size = order.Size;
                orderDTO.Mouse = order.Mouse;
                orderDTO.Goldfish = order.Goldfish;
                orderDTO.Catnip = order.Catnip;
                orderDTO.Grass = order.Grass;
                orderDTO.PaymentType = order.PaymentType;
                orderDTO.Completed = order.Completed;
                orderDTO.TotalCost = order.TotalCost;

                ordersDTO.Add(orderDTO);
            }
            return ordersDTO;
        }

    }
}
