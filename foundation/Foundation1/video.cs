using System.Dynamic;

public class Video{
    private string title;
    private string author;
    private int length;

    List<Comment> comments = new List<Comment>();
    public void fullvid()
    {
        Console.WriteLine($"{title}:{author},{length}Seconds");
    }
    public void displaycomment()
    {
        foreach(Comment comment in comments) 
        {
            comment.display();
        }
    }    
}