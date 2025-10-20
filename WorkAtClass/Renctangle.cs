using System;
using System.Drawing;

namespace WorkAtClass;

public class Renctangle : Shape
{

    private double width;
    private double lenth;

    public double Width
    {
        get { return width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("דיי");
            }
            width = value;
        }
    }
    public double Lenth
    {
        get { return lenth; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("דיי");
            }
            lenth = value;
        }
    }

    public Renctangle(double w, double l) : base("REctangle")
    {
        Width = w;
        Lenth = l;
    }

    public override double Area()
    {
        return width * lenth;
    }
    
    public override double Perimeter()
    {
        return 2*width+2*lenth;
    }

}
