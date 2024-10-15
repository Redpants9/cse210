public class Reference{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;
    

    public Reference(string book,  int chapter,  int verse) 
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = verse;
    }
    public Reference(string book, int chapter, int starverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = starverse;
        _endverse = endverse;
    }
    public string getdisplaytext()
    {
        string line;
        if(_verse == _endverse)
        {
            line = $"{_book} {_chapter}:{_verse}";
        } 
        else
        {
            line = $"{_book} {_chapter}:{_verse}-{_endverse}";
        }
        return line;
    }

}