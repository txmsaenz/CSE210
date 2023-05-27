
public class Comments
{
    public string _commenter;
    public string _comment;

    public Comments(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }

    public string GetCommenter()
    {
        return _commenter;
    }

    public string GetComment()
    {
        return _comment;
    }
}