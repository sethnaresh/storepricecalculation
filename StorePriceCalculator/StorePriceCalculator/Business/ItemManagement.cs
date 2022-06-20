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
    public class ItemManagement
    {
        public readonly IDiscountCalculation _discount;
        public ItemManagement(IDiscountCalculation discount)
        {
            _discount = discount;
        }


        public void AddItem(ref List<ItemValues> purchasedItems, int option, int quantity)
        {
            Item item = Items.CreateItem(option);
            if (purchasedItems.Any(i => i.ItemQ.Item.ItemId == option))
            {

                int quan = purchasedItems.First(i => i.ItemQ.Item.ItemId == option).ItemQ.Quantity += quantity;
                purchasedItems.First(i => i.ItemQ.Item.ItemId == option).BeforeDiscount = quan * item.Price;
                purchasedItems.First(i => i.ItemQ.Item.ItemId == option).AfterDiscount = _discount.ApplyItemDiscount(purchasedItems.First(i => i.ItemQ.Item.ItemId == option));
            }
            else
            {

                ItemValues values = new ItemValues()
                {
                    ItemQ = new ItemQuantity() { Item = item, Quantity = quantity },
                    BeforeDiscount = quantity * item.Price,
                    AfterDiscount = 0                     
                };
                values.AfterDiscount = _discount.ApplyItemDiscount(values);

                purchasedItems.Add(values);
            }
        }

        public decimal GetTotalDiscount(decimal value)
        {
            return _discount.ApplyTotalDiscount(value);
        }
    }
}
