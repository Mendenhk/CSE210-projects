// (finished) The customer contains a name and an address.
// (finished) The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
public class Customer
{
    //ATTRIBUTES
    private string _name;
    private Address _address;  //a class

    //CONSTRUCTORS
    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        Address address = new Address(street, city, state, country);
        _address = address;
    }

    //METHODS
    //another method added by me
    public string GetCustomer()
    {
        return _name;
    }

    //method added by me
    public string GetAddress()
    {
        string addressString = _address.ExtractAddress();
        return addressString;
    }

    public bool LivesInUSA()
    {
        bool usaYes = _address.LivesUSA();
        return usaYes; //or false.  return value;
    }

}