public class Circle:Shape
{
    private double _radius;

    public override double Getarea()
    {
        return _radius*_radius * Math.PI;
    }
    public Circle(string color, double radius):base(color)
    {
        _radius = radius;
    }
}