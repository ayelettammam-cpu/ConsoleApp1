using System;

namespace ConsoleApp1.Lesson3;

public class player

{
    public string Name { get; init; }
    public int Strenth { get; protected set; }
    public int Hp { get; protected set; }
    public player(string name)
    {
        Name = name;
        Hp = 100;
        Strenth = 10;
    }
    public void Attack(player p2)
    {
        System.Console.WriteLine("heeee- Yaaaa");
        p2.Hp -= 1;
    }
}
