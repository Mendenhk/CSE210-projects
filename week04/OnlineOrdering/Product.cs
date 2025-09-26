// Contains the name, product id, price, and quantity of each product.
// The total cost of this product is computed by multiplying the price per unit and the quantity. (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
public class Product
{
    //ATTRIBUTES
    private string _productName;
    private int _id;
    private double _price;
    private int _quantity;

    //CONSTRUCTORS
    public Product(string productName, int id, double price, int quantity)
    {
        _productName = productName;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    //METHODS
    //total cost is calculated by Order.

    //additional method added by me.  Called by order constructor.
    public int getId()
    {
        return _id;
    }
}