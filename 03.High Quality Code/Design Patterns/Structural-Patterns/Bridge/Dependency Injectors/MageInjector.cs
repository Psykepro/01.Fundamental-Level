namespace Bridge.Bridges
{
    using global::Bridge.Characters;

    using RPG.Characters;
    using RPG.Weapons;

    public class MageInjector 
    {
        public Mage CreateWithAxe()
        {
            var axe = new Axe();
            return new Mage(axe);
        }

        public Mage CreateWithSword()
        {
            var sword = new Sword();
            return new Mage(sword);
        }
    }
}