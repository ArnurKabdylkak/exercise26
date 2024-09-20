namespace Packt.Shared;

public class Circle : Shape
{
    public Circle() { }

    public Circle(double radius)
    {
        this.Height = radius * 2;
        this.Width = radius * 2;
    }

    public double Radius
    {
        get
        {
            return Height / 2;
        }
        set
        {
            Height = value * 2;
            Width = value * 2;
        }
    }

    public override double Area
    {
        get
        {
            double radius = Height / 2;
            return Math.PI * radius * radius;
        }
    }
}


