public class Address{
    private string street;
    private string city;
    private string state;
    private string country;
    
    public bool Usa()
    {
        if (country == "Usa")
        {
            return true;
        }
        return false;
    }
    public void display()
    {
        Console.WriteLine($"{street}");
        Console.WriteLine($"{city} {state}");
        Console.WriteLine($"{country}");
    }
}