namespace WestsideRPGWithVSCode.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " throws a magic spell. Pftt!";
        }

        public string Attack(int Bonus) {
            return this.Name + " throws a magic spell with a bonus of " + Bonus;
        }
    }
}