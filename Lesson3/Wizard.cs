using System;

namespace ConsoleApp1.Lesson3;

internal class Wizard:player
{


    public int MagicLevel { get; private set; }
    public Wizard(string name) : base(name)
    {
        MagicLevel = 10;
    }
    

}
