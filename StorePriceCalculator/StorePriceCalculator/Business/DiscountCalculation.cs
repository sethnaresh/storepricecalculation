using StorePriceCalculator.Data;
using StorePriceCalculator.Interfaces;
using StorePriceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePriceCalculator.Business
{
    public class DiscountCalculation : IDiscountCalculation
    {
        public decimal ApplyItemDiscount(ItemValues values)
        {
            //Strategy
            var strategy = Discounts._discounts.Where(i => i.ItemId == values.ItemQ.Item.ItemId).FirstOrDefault();
            if(strategy != null && (strategy.Percentage != null || strategy.Get != null))
            {
                if(strategy.Percentage.HasValue)
                {
                    return values.BeforeDiscount * (100 - strategy.Percentage.Value)/ 100;
                }else
                {
                    return values.BeforeDiscount - (values.ItemQ.Quantity / strategy.Buy.Value) * values.ItemQ.Item.Price;
                }
            }
            else
            {
                return values.BeforeDiscount;
            }
        }

        public decimal ApplyTotalDiscount(decimal value)
        {
            var day = DateTime.Now.DayOfWeek;

            if(Discounts.discountDays.Any(d => d.Day == (Days)day))
            {
                value = value * (100 - Discounts.discountDays.Where(d => d.Day == (Days)day).First().Percentage)/100;
            }
            return value;
        }

    }
}
