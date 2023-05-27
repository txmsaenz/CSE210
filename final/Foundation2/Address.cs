
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _address;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddress()
    {
        _address = _street + ", " + _city + ", " + _state + ", " + _country;
        
        return _address;
    }

    public bool InTheUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}