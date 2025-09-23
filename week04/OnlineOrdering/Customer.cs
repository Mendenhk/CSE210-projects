// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
public class Customer
{
    //ATTRIBUTES
    private string _name;
    private Address _address;  //a class

    //CONSTRUCTORS

    //METHODS
    public bool LivesInUSA()
    {
        //calls a method on address to determine if lives in usa
        //eg.  value = LivesInUSAAddress();
        return true; //or false.  return value;
    }

}