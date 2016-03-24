namespace Bridge.Characters
{
    using Bridge.Weapons;

    public abstract class Character
    {
        public Character(Weapon weapon)
        {
            this.Weapon = weapon;
        }

        //Bridge
        public Weapon Weapon { get; set; }

        public override string ToString()
        {
            return string.Format("{0} with {1}", this.GetType().Name, this.Weapon.GetType().Name);
        }
    }
}