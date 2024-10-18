public class Mathassignment : Assignment
{
    private string _textbooksection;
    private string _problems;

    public string gethomeworklist()
    {
        return $"Section {_textbooksection} Problems {_problems}";
    }
    public Mathassignment(string studentName, string topic, string textbookSection, string problems)
            : base(studentName, topic)
    {
        _textbooksection = textbookSection;
        _problems = problems;
    }
}