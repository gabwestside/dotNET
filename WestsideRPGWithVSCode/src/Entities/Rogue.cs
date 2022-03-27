namespace WestsideRPGWithVSCode.src.Entities
{
    public class Rogue : Hero
    {
        public Rogue(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Rogue()
        {
        }

        public override string Attack()
        {
            return this.Name + " with his two daggers he attacked a very silent.";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " with several brutal attacks with his daggers had a critical damage plus a bonus of " + Bonus;
            }
            return this.Name + " got a amezing daggers cuts with a simple bonus of" + Bonus;
        }
    }
}