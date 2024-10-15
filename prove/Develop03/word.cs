public class Word{
    private string _text;
    private bool _ishidden;
    
    public Word(string text)
    {
        _text = text;
        _ishidden = false;
    }

    public void hide()
    {
        _ishidden = true;
    }
    public void show()
    {
        _ishidden = false;
    }
    public bool ishidden()
    {
        return _ishidden;
    }
    public string getdisplaytext()
    {   
        int length = _text.Length;
        if(_ishidden == true)
        {
            string word = new string('_',length);
            return word; 
        }
        else
        {
            return _text;
        }
    }

}