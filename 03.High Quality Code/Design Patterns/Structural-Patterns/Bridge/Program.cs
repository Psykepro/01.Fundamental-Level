namespace RPG
{
    using System;
    using System.Runtime.InteropServices;

    using Bridge.Bridges;

    using RPG.Characters;

    public class Program
    {
        static void Main()
        {
            //http://www.tutorialspoint.com/design_pattern/bridge_pattern.htm

            WarriorInjector warriorInjector = new WarriorInjector();
            MageInjector mageInjector = new MageInjector();
            Warrior axeWarrior = warriorInjector.CreateWithAxe();
            Warrior swordWarrior = warriorInjector.CreateWithSword();
            Mage axeMage = mageInjector.CreateWithAxe();
            Mage swordMage = mageInjector.CreateWithSword();

            Console.WriteLine(axeWarrior);
            Console.WriteLine(swordWarrior);
            Console.WriteLine(axeMage);
            Console.WriteLine(swordMage);
        }
    }
}
