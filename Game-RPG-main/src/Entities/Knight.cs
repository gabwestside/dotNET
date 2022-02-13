namespace RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com a espada! ";
        }

        public string Attack(int Bonus)
        {
            return this.Name + " Atacou com espada + bônus de ataque! " + Bonus;
        }
    }
}