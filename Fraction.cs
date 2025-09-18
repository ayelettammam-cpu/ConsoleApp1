using System;

namespace ConsoleApp1;

public class Fraction
{
    //private int nominator;//מונה
    private int denominator;//מונה

    public int Nominator { get; set; }//גט וסט למשתנים שאין להם לוגיקה- ט=וכך ניתן למחוק את השונה הראשונה

    public int Denominator
    {
        get
        {
            return denominator;
        }
        set
        {
            if (value != 0)
                denominator = value;
        }
    }

    public Fraction(int nominator, int denominator)
    {
        Nominator = nominator;
        Denominator = denominator;
    }

    public double Result()
    {
        return (double)Nominator / Denominator;
    }

    public override string ToString()
    {
        return $"{Nominator}/{Denominator}";
    }

}
