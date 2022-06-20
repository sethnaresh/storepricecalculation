using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePriceCalculator.Models
{
    public class ItemValues
    {
        public ItemQuantity ItemQ { get; set; }

        public decimal BeforeDiscount { get; set; }

        public decimal AfterDiscount { get; set; }
    }
}
