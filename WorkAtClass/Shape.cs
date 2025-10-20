using System;

namespace WorkAtClass;

public class Shape
{
    public String Name { set; get; }

    public Shape(String name)
    {

    }
    public virtual double Area()
    {
        return 0;
    }
    
    public virtual double Perimeter()
    {
        return 0;
    }
    

}
