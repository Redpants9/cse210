public class Assignment
{
    private string _studentname;
    private string _topic;
    
    public string Getsummary()
    {
        return _studentname + " - " + _topic;
    }
    public string getname()
    {
        return _studentname;
    }
    public string gettopic()
    {
        return _topic;
    }
    public Assignment(string studentName, string topic)
    {
        _studentname = studentName;
        _topic = topic;
    }
}
