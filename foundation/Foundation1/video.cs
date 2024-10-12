using System.Reflection;

public class Video{
    private string title;
    private string author;
    private int length;

    public string fullvid()
    {
        return $"{title}:{author},{length}Seconds";
    }

}