public class Comment{
    private string _commenter;
    private string _comment;

    public void display()
    {
        Console.WriteLine($"{_commenter}");
        Console.WriteLine($"{_comment}");
    }
    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }
}