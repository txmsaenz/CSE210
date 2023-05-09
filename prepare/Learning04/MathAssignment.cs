
public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment()
    {

    }
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic}\n{_textbookSection} {_problems}";
    }

    public void SetHomeworkList(string textbookSection, string problems)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
}