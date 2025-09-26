//Responsibilities: Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer.
using System.Reflection.Emit;

public class Order
{
    //ATTRIBUTES
    private List<Product> _products;
    private Customer _customer;

    //CONSTRUCTORS
    public Order(string customer, List<int> orderedProductIds, List<Product> allProducts, List<Customer> allCustomers)
    {
        //initialize products
        _products = new List<Product>();

        //extracting and saving the customer instance
        foreach (Customer instance in allCustomers)
        {
            if (instance.getCustomer() == customer)
            {
                _customer = instance;
            }
        }

        //creating a list of ordered product instances
        foreach (int item in orderedProductIds)
        {
            foreach (Product instance in allProducts)

                if (instance.getId() == item)
                {
                    _products.Add(instance);
                }
        }
    }

    //METHODS
    public string PackingLabel()
    {
        string labelString = "";
        string customerName = _customer.getCustomer();
        foreach (Product instance in _products)
        {
            labelString += $"Item id: {instance.getId()}   No. items: {instance.GetQuantity()}    Item price: ${instance.GetPrice():F2}\n";
        }
        return $"PACKING LABEL\n***************\n{customerName}\n{labelString}";
    }

    public string ShippingLabel()
    {
        //returns shipping label string
        //(name and address of customer)
        string customerName = _customer.getCustomer();
        string address = _customer.getAddress();
        return $"SHIPPING LABEL\n***************\n{customerName}\n{address}\n\n";
    }
    
        public double TotalCost()
    {
        //calculates total order cost
        //Total = sum of products + one time shipping cost of $5 (USA), $35 (foreign)
        double total = 0;
        foreach (Product instance in _products)
        {
            double subtotal = instance.GetPrice() * instance.GetQuantity();
            total += subtotal;
        }
        if (_customer.LivesInUSA())
        {
            total += 5;
            Console.WriteLine("In USA shipping = $5");
        }
        else
        {
            total += 35;
            Console.WriteLine("Outside of USA shiping = $35");
        }
        return total;  //not actual number
    }
}