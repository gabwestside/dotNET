namespace RPG.src.Entities
{
    public class Swordsman : Hero
    {
        public Swordsman(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com a lança! ";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Atacou com o galope do cavalo super efetiva + bônus de " + Bonus;
            }
            else
            {
                return this.Name + " Atacou com a lança + bônus fraco de " + Bonus;
            }
        }
    }
}