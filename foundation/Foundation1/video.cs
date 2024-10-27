public class Video{
    public string _title;
    public string _author;
    private int _length;
    public void fullvid()
    {
        Console.WriteLine($"{_title}:{_author},");
        Console.WriteLine($"{_length} Seconds");
    }

    List<Comment> comments = new List<Comment>();

    public void addcomment(Comment comment)
    {
        comments.Add(comment);
    }
    public void displaycomment()
    {
        foreach(Comment comment in comments) 
        {
            Console.WriteLine(comment.display());
        }
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
}