//company needs to produce packing labels, shipping labels, and compute final prices for billing.  2 orders with 2-3 products.  Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.

using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating a list of all available products using a product constructor - would normally be in a database or file.
        List<Product> allProducts = new List<Product>();
        Product product = new Product("Red Sneakers", 8209, 59.99, 1);
        allProducts.Add(product);
        product = new Product("Carton Milk", 4057, 6.50, 2);
        allProducts.Add(product);
        product = new Product("Tennis Racket", 6784, 140.99, 1);
        allProducts.Add(product);
        product = new Product("Shaving Cream", 3753, 3.00, 2);
        allProducts.Add(product);
        product = new Product("Chocolate Bar", 4231, 2.50, 5);
        allProducts.Add(product);
        product = new Product("Lego Set", 5563, 49.99, 1);
        allProducts.Add(product);
        


        // //customer1


        //create a product list
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }
}