using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shape = new List<Shape>();
        
        Square square = new Square("purple", 3);
        shape.Add(square);

        Rectangle rectangle = new Rectangle("teal", 3, 4);
        shape.Add(rectangle);

        Circle circle = new Circle("red", 5);
        shape.Add(circle);

        foreach (Shape i in shape)
        {
            string color = i.GetColor();
            double area = i.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}