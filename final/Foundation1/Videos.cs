
public class Videos
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comments>_comments = new List<Comments>();

    public Videos(string title, string author, int length, List<Comments> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public int NumComments()
    {
        return _comments.Count();
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }
}