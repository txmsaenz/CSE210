
public class Lecture : Event
{
    private string _speaker;
    private string _capacity;
    private string _fullMessage;

    public Lecture(string speaker, string capacity, string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _type = "Lecture"; 
    }

     public string FullMessage()
    {
        _fullMessage = "Type of event: " + _type + ", title: " + _title + ", speaker: " + _speaker + ", capacity: " + _capacity + ", " + _description + ", on " + _date + ", at " + _time + ", at" + _address.GetAddress();

        return _fullMessage;
    }

}