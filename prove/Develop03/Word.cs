
class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
    }

    public bool GetHiddenWord()
    {
        return _isHidden;
    }

    public void SetHiddenWord(bool isHidden)
    {
        _isHidden = isHidden;
    }

    public string GetWord()
    {
        return _word;
    }
}