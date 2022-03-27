namespace WestsideRPGWithVSCode.src.Entities
{
    public class Ranger : Hero
    {
        public Ranger(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Ranger()
        {
        }

        public override string Attack()
        {
            return this.Name + " drew his bow and shot with dexterity.";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " got a critical and accurate shot plus a bonus of " + Bonus;
            }
            return this.Name + " got a accurate shot with a simple bonus of" + Bonus;
        }
    }
}