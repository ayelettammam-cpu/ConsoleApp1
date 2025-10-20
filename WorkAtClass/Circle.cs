using System;

namespace WorkAtClass;

public class Circle : Shape
{

    private double radius;

    public double Radius
    {
        get { return radius; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("דיי");
            }
            radius = value;
        }
    }

    public Circle(double r) : base("Circle")
    {
        radius = r;
    }
    
    public override double Area()
    {
        return Math.PI*radius*radius;
    }
    
    public override double Perimeter()
    {
        return 2*Math.PI*radius;
    }
}
