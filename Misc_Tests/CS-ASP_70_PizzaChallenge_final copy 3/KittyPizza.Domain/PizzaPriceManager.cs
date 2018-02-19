using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KittyPizza.DTO;

namespace KittyPizza.Domain
{
    public class PizzaPriceManager
    {

        public static decimal CalculateCost(DTO.OrderDTO order)
        {
            decimal cost = 0.0M;
            var prices = getPizzaPrices();
            cost += calculateSizeCost(order, prices);
            cost += calculateCrustCost(order, prices);
            cost += calculateToppingsCost(order, prices);

            return cost;
        }


        // NOTE!
        // VS auto-generated these methods WITHOUT the DTO.
        // I added back in just do help keep trrack of where things are ...
        // VS = calculateToppingsCost(OrderDTO order, PizzaPriceDTO prices)
        // SG = calculateToppingsCost(DTO.OrderDTO order, DTO.PizzaPriceDTO prices)

        private static decimal calculateToppingsCost(DTO.OrderDTO order, PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            cost += (order.Mouse) ? prices.MouseCost : 0M;
            cost += (order.Goldfish) ? prices.GoldfishCost : 0M;
            cost += (order.Catnip) ? prices.CatnipCost : 0M;
            cost += (order.Grass) ? prices.GrassCost : 0M;

            return cost;
        }

        private static decimal calculateCrustCost(DTO.OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            switch (order.Crust)
            {
                case KittyPizza.DTO.Enums.CrustType.RegularGlutenFree:
                    cost = prices.RegularCrustCost;
                    break;
                case KittyPizza.DTO.Enums.CrustType.ThinSalmonSkin:
                    cost = prices.ThinCrustCost;
                    break;
                case KittyPizza.DTO.Enums.CrustType.ThickCrispyCheese:
                    cost = prices.ThickCrustCost;
                    break;
                default:
                    break;
            }


            return cost;
        }

        private static decimal calculateSizeCost(DTO.OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            switch (order.Size)
            {
                case DTO.Enums.SizeType.Kitten:
                    cost = prices.SmallSizeCost;
                    break;
                case DTO.Enums.SizeType.Cat:
                    cost = prices.MediumSizeCost;
                    break;
                case DTO.Enums.SizeType.Lion:
                    cost = prices.LargeSizeCost;
                    break;
                default:
                    break;
            }
            return cost;

        }

        private static DTO.PizzaPriceDTO getPizzaPrices()
        {
            // this is the non-var:
            // KittyPizza.DTO.PizzaPriceDTO prices = Data.PizzaPriceRepository.GetPizzaPrices();
            var prices = Data.PizzaPriceRepository.GetPizzaPrices();
            
            return prices;

        }
    }
}
