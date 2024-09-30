public class Entry{
    public string date;
    public string promptText;
    public string entryText;

    public void Display()
    {
        Console.WriteLine($"Date:{date}-Promt:{promptText}");
        Console.WriteLine($"{entryText}");
    }
}