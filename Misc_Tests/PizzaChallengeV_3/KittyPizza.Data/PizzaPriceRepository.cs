using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittyPizza.Data
{
    public class PizzaPriceRepository
    {
        public static DTO.PizzaPriceDTO GetPizzaPrices()
        {
            var db = new KittyPizzaDbEntities();
            var prices = db.PizzaPriceLookupTables.First();
            var dto = convertToDTO(prices);
            return dto;
        }

        private static DTO.PizzaPriceDTO convertToDTO(PizzaPriceLookupTable pizzaPrice)
        {
            var dto = new DTO.PizzaPriceDTO();

            // mapping:
            dto.SmallSizeCost = pizzaPrice.SmallSizeCost;
            dto.MediumSizeCost = pizzaPrice.MediumSizeCost;
            dto.LargeSizeCost = pizzaPrice.LargeSizeCost;
            dto.MouseCost = pizzaPrice.MouseCost;
            dto.GoldfishCost = pizzaPrice.GoldfishCost;
            dto.CatnipCost = pizzaPrice.CatnipCost;

            return dto;
        }


    }
}
