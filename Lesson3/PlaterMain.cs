using System;

namespace ConsoleApp1.Lesson3;

public class PlaterMain
{
    static void Main(string[] args)
    {
        Warrior w1 = new Warrior("Ayelet");
        Wizard wiz1 = new Wizard("Tzlil");
        Warrior w2 = new Warrior("EliEliNorNor");
        player[] players = new player[3];
        players[0] = w1;
        players[1] = wiz1;
        players[2] = w2;

        for (int i = 0; i < players.Length; i++)
        {
            System.Console.WriteLine(players[i].Name + "Hp" + players[i]);
            if (players[i] is Warrior w)
            {
                System.Console.WriteLine((w.HasSword));
            }   
        }



     }

}
