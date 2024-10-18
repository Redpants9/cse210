public class Writingassignment:Assignment
{
    private string _title;

    public string Getwritinginformation()
    {
        string studentName = getname();

        return $"{_title} by {studentName}";
    }
    public Writingassignment(string studentName, string topic, string title)
        :base(studentName, topic)
    {
        _title = title;
    }
}