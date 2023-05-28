

public class OutdoorGathering : Event
{
    private string _weather;
    private string _fullMessage;

    public OutdoorGathering(string weather, string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
    {
        _weather = weather;
        _type = "Outdoor Gathering"; 
    }

    public string FullMessage()
    {
        _fullMessage = "Type of event: " + _type + ", title: " + _title + ", " + _description + ", on " + _date + ", at " + _time + ", at " + _address.GetAddress() + ", weather: " + _weather;

        return _fullMessage;
    }
}