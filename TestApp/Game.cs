using ClassLibrary1;
using System;

class Game
{
    static void Main()
    {
        //string name, int health, int attack, int defense
        Mage mage = new Mage("Merlin", 60, 70, 50);
        Warrior warrior = new Warrior("Arthur", 80, 90, 70);
        Dragon dragon = new Dragon("Smaug", 80, 80, 110);

        while (warrior.Health > 0 && dragon.Health > 0 || mage.Health > 0 && dragon.Health > 0
            || mage.Health > 0 && warrior.Health > 0)
        {

            Console.WriteLine(warrior.Name + " is a warrior with " + warrior.Health + " Health");
            Console.WriteLine(mage.Name + " is a mage with " + mage.Health + " Health");
            Console.WriteLine(dragon.Name + " is a dragon with " + dragon.Health + " Health");
            Console.WriteLine("");
            Console.WriteLine("Fight Begins");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");

            warrior.Charge(mage);
            mage.Defend();
            dragon.BreatheFire(warrior);
            dragon.Defend();
            warrior.Defend();
            mage.CastSpell(dragon);

            Console.WriteLine("--- Battle between " + warrior.Name + " and " + mage.Name + " ---");

            if (warrior.Health > mage.Health)
            {
                Console.WriteLine(warrior.Name + " wins!");
            }
            else
            {
                Console.WriteLine(mage.Name + " wins!");
            }

            Console.WriteLine("--- Battle between " + dragon.Name + " and " + warrior.Name + " ---");

            if (warrior.Health > dragon.Health)
            {
                Console.WriteLine(warrior.Name + " wins!");
            }
            else
            {
                Console.WriteLine(dragon.Name + " wins!");
            }

            Console.WriteLine("--- Battle between " + mage.Name + " and " + dragon.Name + " ---");

            if (warrior.Health > dragon.Health)
            {
                Console.WriteLine(warrior.Name + " wins!");
            }
            else
            {
                Console.WriteLine(dragon.Name + " wins!");
            }
            Character highestHealthCharacter = (warrior.Health > mage.Health)
            ? (warrior.Health > dragon.Health ? warrior : dragon)
            : (mage.Health > dragon.Health ? mage : dragon);

            Console.WriteLine(warrior.Name + " Health is " + warrior.Health);
            Console.WriteLine(mage.Name + " Health is " + mage.Health);
            Console.WriteLine(dragon.Name + " Health is " + dragon.Health);

            Console.WriteLine("Final Winner is " + highestHealthCharacter.Name);

            Console.ReadLine();
        }
    }
}