namespace Bridge.Bridges
{
    using global::Bridge.Characters;

    using RPG.Characters;
    using RPG.Weapons;

    public class WarriorInjector 
    {
        public Warrior CreateWithAxe()
        {
            var axe = new Axe();
            return new Warrior(axe);
        }

        public Warrior CreateWithSword()
        {
            var sword = new Sword();
            return new Warrior(sword);
        }
    }
}