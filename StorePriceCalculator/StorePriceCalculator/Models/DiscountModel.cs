using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePriceCalculator.Models
{
    public class DiscountModel
    {
        public int ItemId { get; set; }

        public decimal? Percentage { get; set; }

        public int? Buy { get; set; }

        public int? Get { get; set; }
    }

    public class DiscountDayModel
    {
        public Days Day { get; set; }

        public decimal Percentage { get; set; }
    }

    public enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum DiscountType
    {
        None,
        Percentage,
        BuyGet
    }
}
