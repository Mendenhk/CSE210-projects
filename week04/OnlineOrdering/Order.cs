//Responsibilities: Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer.
public class Order
{
    //ATTRIBUTES
    private List<Product> _products;
    private string _customer;

    //CONSTRUCTORS
    public Order(string customer, List<int> orderedProductIds, List<Product> allProducts)
    {
        _customer = customer;
        foreach(int item in orderedProductIds)
        {
            foreach (Product instance in allProducts)
            
                if(instance.getId() == item){
                    _products.Add(instance);
                }
            }
        }
    }

    //METHODS
    public double TotalCost()
    {
        //calculates total order cost
        //Total = sum of products + one time shipping cost of $5 (USA), $35 (foreign)
        return 12.32;  //not actual number
    }

    public string PackingLabel()
    {
        //returns packing label string
        //(name and product id)
        return "random string";
    }

    public string ShippingLabel()
    {
        //returns shipping label string
        //(name and address of customer)
        return "random string";
    }
}