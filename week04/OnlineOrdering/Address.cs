// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
public class Address
{
    //ATTRIBUTES
    private string streetAddress; //(city, state/province, and country)

    //CONSTRUCTORS

    //METHODS
    public bool LivesUSA()
    {
        //extracts if lives in US or not.
        return true; //or false
    }

    public string ExtractAddress()
    {
        //returns all fields together with new lines where appropriate.
        return "address";
    }
}