public class Assignment
{
    private string _studentname;
    private string _topic;
    
    public string Getsummary()
    {
        return $"{_studentname}:{_topic}";
    }
}
