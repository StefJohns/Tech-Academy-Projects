using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaBobs.DTO;

namespace PapaBobs.Domain
{
    public class PizzaPriceManager
    {
        private static DTO.PizzaPriceDTO GetPizzaPrices()
        {
            var prices = Persistence.PizzaPriceRepository.GetPizzaPrices();
            return prices;
        }

        public static decimal CalculateCost(DTO.OrderDTO order)
        {
            decimal cost = 0M;
            var prices = GetPizzaPrices();

            cost += CalculateSizeCost(order, prices);
            cost += CalculateCrustCost(order, prices);
            cost += CalculateToppingsCost(order, prices);

            return cost;
        }

        private static decimal CalculateToppingsCost(OrderDTO order, PizzaPriceDTO prices)
        {
            decimal cost = 0M;

            cost += (order.Sausage) ? prices.SausageCost : 0M;
            cost += (order.Pepperoni) ? prices.PepperoniCost : 0M;
            cost += (order.Onions) ? prices.OnionsCost : 0M;
            cost += (order.GreenPeppers) ? prices.GreenPeppersCost : 0M;

            return cost;
        }

        private static decimal CalculateCrustCost(OrderDTO order, PizzaPriceDTO prices)
        {
            decimal cost = 0M;
            
            switch (order.Crust)
            {
                case DTO.Enums.CrustType.Regular:
                    cost = prices.RegularCrustCost;
                    break;
                case DTO.Enums.CrustType.Thick:
                    cost = prices.ThickCrustCost;
                    break;
                case DTO.Enums.CrustType.Thin:
                    cost = prices.ThinCrustCost;
                    break;
                default:
                    break;
            }
            return cost;
        }

        private static decimal CalculateSizeCost(OrderDTO order, PizzaPriceDTO prices)
        {
            decimal cost = 0M;

            switch (order.Size)
            {
                case DTO.Enums.SizeType.Small:
                    cost = prices.SmallSizeCost;
                    break;
                case DTO.Enums.SizeType.Medium:
                    cost = prices.MediumSizeCost;
                    break;
                case DTO.Enums.SizeType.Large:
                    cost = prices.LargeSizeCost;
                    break;
                default:
                    break;
                    
            }
            return cost;
        }
    }
}
