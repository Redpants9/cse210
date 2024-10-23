public class Product{
    private string prodname;
    private string prodid;
    private float price;
    private int quantity;

    public float total()
    {
        float total = price * quantity;
        return total;
    }
    public void display()
    {
        Console.WriteLine($"{prodname}:{prodid}");
        Console.WriteLine($"{price}");
    }
}