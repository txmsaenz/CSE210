
public class Event
{
    protected string _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _standardMessage;
    protected string _shortMessage;
    

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public Event()
    {
    }

    public string StandardMessage()
    {
        _standardMessage = "Title: " + _title + ", " + _description + ", on " + _date + ", at " + _time + ", at " + _address.GetAddress();

        return _standardMessage;
    }

    public string ShortMessage()
    {
        _shortMessage = "Type of event: " + _type + ", title: " + _title + ", on " + _date;

        return _shortMessage;
    }
}