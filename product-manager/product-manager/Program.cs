using product_manager.Utility;
using product_manager.business;
using System;

namespace product_manager
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello to the Product Manager App!");
            string code = MyConsole.GetRequiredString("Enter a product code: ");
            string productDescription = MyConsole.GetRequiredString("Enter a product description: ");
            double price = MyConsole.GetDouble("Enter a price: ");
            int quantity = MyConsole.GetInt("Enter quantity");
            Product p1 = new business.Product(code, productDescription, price*quantity);
            Console.WriteLine("Product summary: " + code  + " " + productDescription + " " + price);
            //haven't written the lineItem logic
        }
    }
}
