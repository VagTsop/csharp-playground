using System;

namespace ClassLibrary1
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int attack { get; set; }
        public int Defense { get; set; }


        public Character(string name, int health, int attack, int defense)
        {
            this.Name = name;
            this.Health = health;
            this.attack = attack;
            this.Defense = defense;
        }

        public virtual void Defend()
        {
            Console.Write(Name);
        }
    }
}
