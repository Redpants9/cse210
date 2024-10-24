public class Square:Shape
{
    private double _side;

    public override double Getarea()
    {
        return _side * _side;
    }
    public Square(string color, double side):base(color)
    {
        _side = side;
    }
}