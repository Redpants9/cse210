public class Video{
    private string _title;
    private string _author;
    private int _length;

    List<Comment> comments = new List<Comment>();
    public void fullvid()
    {
        Console.WriteLine($"{_title}:{_author},");
        Console.WriteLine($"{_length} Seconds");
    }
    public void displaycomment()
    {
        foreach(Comment comment in comments) 
        {
            comment.display();
        }
    }    
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
}