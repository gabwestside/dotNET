namespace WestsideRPGWithVSCode.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero()
        { }

        public string Name;

        public int Level;

        public string HeroType;

        public override string ToString()
        {
            return this.Name +
                " " +
                this.Level +
                " " +
                this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " strikes with your sword.";
        }
    }
}