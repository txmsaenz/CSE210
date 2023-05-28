
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _address;

    public Address(string street, string city, string state)
    {
        _street = street;
        _city = city;
        _state = state;
    }

    public string GetAddress()
    {
        _address = _street + ", " + _city + ", " + _state;

        return _address;
    }
}