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
        // Method to print product information
        public void PrintInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}, Quantity: {Quantity}, Total: {CalculateTotal():F2}");
        }
    }
    //Create a class Order that can contain a list of Products and calculate total cost for the order.
    // Order class to manage multiple products
    class Order
    {
        // List to hold products
        private List<Product> Products;
        // Constructor
        public Order()
        {
            Products = new List<Product>();
        }
        // Method to add a product to the order
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        // Method to calculate total order cost
        public double CalculateOrderTotal()
        {
            // Using foreach loop to iterate through products
            double total = 0;
           
            foreach (Product product in Products)
            {
                total += product.CalculateTotal();
            }
            return total;
        }
        // Method to print order summary
        public void PrintOrderSummary()
        {
            Console.WriteLine("Order Summary:");
            foreach (Product product in Products)
            {
                product.PrintInfo();
            }
            Console.WriteLine($"Total Order Cost: {CalculateOrderTotal():F2}");
        }
        public override string ToString()
        {
            return $"Order with {Products.Count} products, Total Cost: {CalculateOrderTotal():F2}";
        }
    }

}