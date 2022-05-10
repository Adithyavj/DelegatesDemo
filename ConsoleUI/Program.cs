using System;
using System.Collections.Generic;
using DemoLibrary;
    
namespace ConsoleUI
{
    class Program
    {
        static ShoppingCartModel cart = new ShoppingCartModel();

        static void Main(string[] args)
        {
            PopulateCartWithDemoData();

            // Create a method to pass in as the parameter to GenerateTotal()

            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, AlertUser):C2}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the application");
            Console.ReadLine();
        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }

        // Has same structure of the delegate
        private static void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The subtotal is {subTotal:C2}");
        }

        private static void AlertUser(string message)
        {
            Console.WriteLine(message);
        }

        // Has same structure of the Func<List<ProductModel>,decimal,decimal>
        private static decimal CalculateLeveledDiscount(List<ProductModel> items, decimal subTotal)
        {
            if (subTotal > 100)
            {
                return subTotal * 0.80M; // 20% discount
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M; // 15% discount
            }
            else if (subTotal > 10)
            {
                return subTotal * 0.90M; // 10% discount
            }
            else
            {
                return subTotal;
            }
        }
    }
}
