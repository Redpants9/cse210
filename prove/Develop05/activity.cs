public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public void activity()
    {



    }
    public void displaystartmsg()
    {   
        Console.WriteLine("Start of activity");
    }
    public void displayendmsg()
    {
        Console.WriteLine("End of activity.");
    }
    public void showspinner(int sec)
    {
        _duration = sec;
    }
    public void showcountdown(int sec)
    {
        _duration = sec;
    }
}