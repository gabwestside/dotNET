namespace RPG.src.Entities
{
    public class Druid : Hero
    {
        public Druid(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Magia! ";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia transformando o adversário em coelho + bônus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou Magia + bônus fraco de " + Bonus;
            }
        }
    }
}