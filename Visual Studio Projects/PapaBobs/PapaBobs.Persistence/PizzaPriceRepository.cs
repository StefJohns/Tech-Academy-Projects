using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Persistence
{
    public class PizzaPriceRepository
    {
        public static DTO.PizzaPriceDTO GetPizzaPrices()
        {
            var dB = new PapaBobsEntities();
            var prices = dB.PizzaPrices.First();

            var dto = ConvertToDTO(prices);
            return dto;
        }
        private static DTO.PizzaPriceDTO ConvertToDTO(PizzaPrice pizzaPrice)
        {
            var dto = new DTO.PizzaPriceDTO();

            dto.LargeSizeCost = pizzaPrice.LargeSizeCost;
            dto.MediumSizeCost = pizzaPrice.MediumSizeCost;
            dto.SmallSizeCost = pizzaPrice.SmallSizeCost;
            dto.ThickCrustCost = pizzaPrice.ThickCrustCost;
            dto.ThinCrustCost = pizzaPrice.ThinCrustCost;
            dto.RegularCrustCost = pizzaPrice.RegularCrustCost;
            dto.SausageCost = pizzaPrice.SausageCost;
            dto.PepperoniCost = pizzaPrice.PepperoniCost;
            dto.OnionsCost = pizzaPrice.OnionsCost;
            dto.GreenPeppersCost = pizzaPrice.GreenPeppersCost;

            return dto;
        }
    }
}
