//Next, finish creating 2 customer instances.  Then work on Order Class and instances.
//company needs to produce packing labels, shipping labels, and compute final prices for billing.  2 orders with 2-3 products.  Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.

using System;

class Program
{
    static void Main(string[] args)
    {
        //PRODUCTS - Creating a list of all available products using a product constructor - would normally be in a database or file.
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

        //CUSTOMERS - Creating a list of all customers (or all customers with orders) and their addresses using a Customer constructor - again, this would normally be in a database or file.   
        List<Customer> allCustomers = new List<Customer>();
        Customer customer = new Customer("Kathlyn Brown", "234 Amber Ave.", "Atascadero", "CA", "USA");
        allCustomers.Add(customer);
        customer = new Customer("Rupert Shen", "3000 A Street Unit #4", "Montreal", "Quebec", "Canada");
        allCustomers.Add(customer);

        //ORDERS - Creating a list of customers and orders placed using an Order Constructor.  
        List<Order> orders = new List<Order>();
        Order order = new Order("Kathlyn Brown", [8209, 4057, 6784], allProducts);
        orders.Add(order);
        order = new Order("Rupert Shen", [3753, 4231, 5563], allProducts);

        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }
}