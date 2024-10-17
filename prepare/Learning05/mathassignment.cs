public class Mathassignment : Assignment 
{
    private string _textbooksection;
    private string _problems;

    public string gethomeworklist()
    {
        return $"{_textbooksection} {_problems}";
    }
}