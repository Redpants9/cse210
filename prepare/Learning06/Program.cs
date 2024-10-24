using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 23);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Red", 12, 24);
        shapes.Add(s2);

        Circle s3 = new Circle("Orange", 5);
        shapes.Add(s3);

        foreach (Shape shape in shapes)
        {
            string color = shape.Getcolor();
            double area = shape.Getarea();

            Console.WriteLine($"The color of the shape is {color} and the area is {area}");
        }
    }
}