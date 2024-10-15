public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string singword in text.Split(" "))
        {
            Word word = new Word(singword);
            _words.Add(word);
        }
    }

    public void hiderandomword()
    {
        List<Word> unhidden = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.ishidden())
            {
                unhidden.Add(word);
            }
        }
        unhidden.Count();
        Random rng = new Random();
        int numwords = unhidden.Count;
        int index = rng.Next(0, numwords);
        if (unhidden.Count() == 0)
        {
            return;
        }
        unhidden[index].hide();

    }
    public string getdisplaytext()
    {   
        string text = "";
        foreach(Word word in _words)
        {
            text += " " + word.getdisplaytext();
        }
        return $"{_reference.getdisplaytext()} {text}";
    }
    public bool iscompletelyhidden()
    {
        List<Word> hidden = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.ishidden())
            {
                hidden.Add(word);
            }
        }
        if (_words.Count == hidden.Count)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}