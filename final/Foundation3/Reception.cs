

public class Reception : Event
{
    private string _register;
    private string _fullMessage;

    public Reception(string register, string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
    {
        _register = register;
        _type = "Reception";
    }

    public string FullMessage()
    {
        _fullMessage = "Type of event: " + _type + ", title: " + _title + ", " + _description + ", on " + _date + ", at " + _time + ", at " + _address.GetAddress() + ", RSVPed: " + _register;

        return _fullMessage;
    }
}