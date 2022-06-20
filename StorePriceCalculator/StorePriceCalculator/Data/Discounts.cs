using StorePriceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePriceCalculator.Data
{
    public static class Discounts
    {
        public static List<DiscountModel> _discounts = new List<DiscountModel>()
        {
            new DiscountModel() { ItemId = 1, Percentage = 10, Buy = null, Get = null},
            new DiscountModel() { ItemId = 2, Percentage = 10, Buy = null, Get = null},
            new DiscountModel() { ItemId = 3, Percentage = null, Buy = null, Get = null},
            new DiscountModel() { ItemId = 4, Percentage = null, Buy = 3, Get = null},
            new DiscountModel() { ItemId = 5, Percentage = null, Buy = null, Get = null},
            new DiscountModel() { ItemId = 6, Percentage = 5, Buy = null, Get = null},
            new DiscountModel() { ItemId = 7, Percentage = null, Buy = null, Get = null},
        };

        public static List<DiscountDayModel> discountDays = new List<DiscountDayModel>()
        {
            new DiscountDayModel() { Day = Days.Sunday, Percentage = 0 },
            new DiscountDayModel() { Day = Days.Monday, Percentage = 2 },
            new DiscountDayModel() { Day = Days.Tuesday, Percentage = 0 },
            new DiscountDayModel() { Day = Days.Wednesday, Percentage = 5 },
            new DiscountDayModel() { Day = Days.Thursday, Percentage = 0 },
            new DiscountDayModel() { Day = Days.Friday, Percentage = 0 },
            new DiscountDayModel() { Day = Days.Saturday, Percentage = 0 }
        };

    }
}
