public class Comment{
    private string commenter;
    private string comment;

    public void display()
    {
        Console.WriteLine($"{commenter}");
        Console.WriteLine($"{comment}");
    }
}