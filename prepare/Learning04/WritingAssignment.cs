
public class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment()
    {

    }

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic}\n{_title}";
    }
}