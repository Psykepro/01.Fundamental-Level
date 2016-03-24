namespace Animals
{
    class Tomcat : Cat
    {
        private Gender gender;
        public Tomcat(string name, int age, Gender gender)
            : base(name, age)
        {
            this.Gender = gender;
        }

        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = Gender.Male; }
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + ", gender: {0}", this.Gender);
        }
    }
}