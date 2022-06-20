// See https://aka.ms/new-console-template for more information
using StorePriceCalculator.Business;
using StorePriceCalculator.Data;
using StorePriceCalculator.Models;

Console.WriteLine("Hello, Customer!");
Console.WriteLine("Please choose item from the list for billing:");
Console.WriteLine("1 : Thumbs up");
Console.WriteLine("2 : Toilet Cleaner");
Console.WriteLine("3 : Mangoes");
Console.WriteLine("4 : Cooking Oil Bottle - 1 liter");
Console.WriteLine("5 : Sugar");
Console.WriteLine("6 : Tea");
Console.WriteLine("7 : Bulbs");
Console.WriteLine("0 : None");
List<ItemValues> purchasedItems = new List<ItemValues>();
bool isSelected = true;
while(isSelected)
{
    int option = Convert.ToInt32(Console.ReadLine());
    var itemManagement = new ItemManagement(new DiscountCalculation());

    if (option > 0 && option < 8)
    {
        Console.WriteLine("Please enter quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        //Add Product and Calculate Discount
        itemManagement.AddItem(ref purchasedItems, option, quantity);

        Console.WriteLine("Item       Quantity      Total Price      AfterDiscount");

        foreach (var item in purchasedItems)
        {
            Console.WriteLine("{0}        {1}         {2}         {3}",item.ItemQ.Item.ItemName, item.ItemQ.Quantity, item.BeforeDiscount, item.AfterDiscount);
        }
        Console.WriteLine("Total Price of all Items {0}", itemManagement.GetTotalDiscount(purchasedItems.Sum(i => i.AfterDiscount)));
    } 
    else if (option == 0)
    {
        Console.WriteLine("Thank you for shopping");
    }
    else
    {
        Console.WriteLine("Item does not exist in the inventory.");
    }
}


