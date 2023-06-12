﻿using ClassLibrary1;
using System;

public class Dragon : Character
{

    public Dragon(string name, int health, int attack, int defense) : base(name, health, attack, defense)
    {

    }

    public void BreatheFire(Character target)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 10);
        double damage = (target.attack - target.Defense) * randomNumber;

        if (damage > 0)
        {
            target.Health -= (int)damage;
            Console.WriteLine(Name + " breathes fire on " + target.Name + " for " + (int)damage + " damage!");
        }

        else
        {
            Console.WriteLine(Name + " Attack on " + target.Name + " Missed");
        }
    }

    public override void Defend()
    {
        base.Defend();
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int defenseThreshold = 50;
        if (randomNumber <= defenseThreshold)
        {
            Defense += 10;
            Console.Write(" defends and gains " + Defense + " points\n");

        }
        else
        {
            Console.Write(" defense failed.\n");
            return;
        }
    }
}