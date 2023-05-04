
class Reference
{
    private string _verseStart;
    private string _verseEnd;
    private string _chapter;
    private string _book;

    public Reference(string chapter, string book, string verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = "";
    }

    public Reference(string chapter, string book, string verseStart, string verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetReference()
    {
        if (_verseEnd == "")
        {
            return ($"{_book} {_chapter}:{_verseStart}");
        }
        else
        {
            return ($"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
        }
    }
}