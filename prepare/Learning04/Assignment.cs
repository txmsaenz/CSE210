
public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";

    public Assignment()
    {
        
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public void SetSummary(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}