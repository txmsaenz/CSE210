
class Scripture
{
    private Reference _scriptureReference;
    private List<Word> words;

    public Scripture(Reference scriptureReference, string scriptureText)
    {
        _scriptureReference = scriptureReference;
        words = new List<Word>();
        CreateWords(scriptureText);
    }

    public void CreateWords(string scriptureText)
    {
        List<string> allWords = scriptureText.Split(' ').ToList();
        foreach (string newWords in allWords)
        {
            Word word = new Word(newWords);
            words.Add(word);
        }
    }

    public string GetScripture()
    {
        string scriptureText = "";
        foreach (Word word in words)
        {
            if (word.GetHiddenWord() == false)
            {
                scriptureText += word.GetWord() + " ";
            }
            else
            {
                scriptureText += new string('_', word.GetWord().Length)+ " ";
            }
        }
        return ($"{_scriptureReference.GetReference()} {scriptureText}");
    }

    public void RemoveWords()
    {
        int numWordsToRemove = new Random().Next(2,4);
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, words.Count());
            if (words[rndIndex].GetHiddenWord() == false)
            {
                words[rndIndex].SetHiddenWord(true);
                wordsRemoved++;
            }
            
        }while (wordsRemoved != numWordsToRemove && this.WordsLeft());
    }

    public bool WordsLeft()
    {
        bool retValue = false;

        foreach (Word word in words)
        {
            if (word.GetHiddenWord() == false)
            {
                retValue = true;
            }
        }

        return retValue;
    }
}