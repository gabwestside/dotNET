namespace WestsideRPGWithVSCode.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Knight()
        {
        }

        public override string Attack()
        {
            return this.Name + " attacked bravely with his sword.";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " with his sword he got a critical and powerful attack plus a bonus of " + Bonus;
            }
            return this.Name + " attacked with his sword with a simple bonus of " + Bonus;
        }
    }
}