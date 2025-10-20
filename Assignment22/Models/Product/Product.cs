using Assignment22.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22.Models.Product
{
    internal class Product
    {
        // Properties
        public string Name;
        public double Price;
        public int Quantity;

// Overload constructors:
//- Default constructor
        public Product()
        {
            Name = "Unknown";
            Price = 0;
            Quantity = 0;
        }

        //- Constructor with all properties
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

//Add overloaded method CalculateTotal():
//- One with no parameters → uses class fields
        public double CalculateTotal()
        {
            return Price * Quantity;
        }

        //One with parameters price, quantity
        public double CalculateTotal(double price, int quantity)
        {
            return price * quantity;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}, Quantity: {Quantity}, Total: {CalculateTotal():F2}");
        }
    }

    class Order
    {
        private List<Product> Products;

        public Order()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public double CalculateOrderTotal()
        {
            double total = 0;
            foreach (Product product in Products)
            {
                total += product.CalculateTotal();
            }
            return total;
        }

        public void PrintOrderSummary()
        {
            Console.WriteLine("Order Summary:");
            foreach (Product product in Products)
            {
                product.PrintInfo();
            }
            Console.WriteLine($"Total Order Cost: {CalculateOrderTotal():F2}");
        }
    }

}