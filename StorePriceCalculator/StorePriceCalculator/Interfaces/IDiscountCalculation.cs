using StorePriceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePriceCalculator.Interfaces
{
    public interface IDiscountCalculation
    {
        public decimal ApplyItemDiscount(ItemValues values);

        public decimal ApplyTotalDiscount(decimal value);
    }
}
