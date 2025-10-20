using System;

namespace ConsoleApp1.Lesson3;


    internal class Warrior : player
    {
        public bool HasSword
        {
            get; private set;
        }
        public Warrior(string name) : base(name)
        {
            HasSword = false;

        }
        
    }



