using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittyPizza.DTO
{
    public class PizzaPriceDTO
    {
        public int Id { get; set; }
        public decimal SmallSizeCost { get; set; }
        public decimal MediumSizeCost { get; set; }
        public decimal LargeSizeCost { get; set; }
        public decimal ThickCrustCost { get; set; }
        public decimal ThinCrustCost { get; set; }
        public decimal RegularCrustCost { get; set; }
        public decimal MouseCost { get; set; }
        public decimal GoldfishCost { get; set; }
        public decimal CatnipCost { get; set; }
        public decimal GrassCost { get; set; }
    }


}
