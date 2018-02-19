using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittyPizza.DTO
{
    public class OrderDTO
    {
        public System.Guid OrderId { get; set; }
        public KittyPizza.DTO.Enums.SizeType Size { get; set; }
        public KittyPizza.DTO.Enums.CrustType Crust { get; set; }
        public bool Mouse { get; set; }
        public bool Goldfish { get; set; }
        public bool Catnip { get; set; }
        public bool Grass { get; set; }
        public decimal TotalCost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public KittyPizza.DTO.Enums.PaymentType PaymentType { get; set; }
        public bool Completed { get; set; }

    }
}
