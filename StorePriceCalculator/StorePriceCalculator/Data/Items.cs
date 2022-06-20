using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorePriceCalculator.Models;

namespace StorePriceCalculator.Data
{
    public class Items
    {
        public static Item CreateItem(int itemNo)
        {
            switch (itemNo)
            {
                case 1:
                    return new Item
                    {
                        ItemId = 1,
                        ItemName = "Thumbs up",
                        Price = 50.00m
                    };
                case 2:
                    return new Item
                    {
                        ItemId = 2,
                        ItemName = "Toilet Cleaner",
                        Price = 100.40m
                    };
                case 3:
                    return new Item
                    {
                        ItemId = 3,
                        ItemName = "Mangoes",
                        Price = 90.00m
                    };
                case 4:
                    return new Item
                    {
                        ItemId = 4,
                        ItemName = "Cooking Oil Bottle - 1 liter",
                        Price = 230.30m
                    };
                case 5:
                    return new Item
                    {
                        ItemId = 5,
                        ItemName = "Sugar",
                        Price = 40.50m
                    };
                case 6:
                    return new Item
                    {
                        ItemId = 6,
                        ItemName = "Tea",
                        Price = 400.30m
                    };
                case 7:
                    return new Item
                    {
                        ItemId = 7,
                        ItemName = "Bulbs",
                        Price = 30.30m
                    };
                default:
                    throw new NotSupportedException($"Unrecognized Item No : {itemNo}");
            }
        }
    }
}
