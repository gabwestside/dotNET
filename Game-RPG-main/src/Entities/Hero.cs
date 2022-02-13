namespace RPG.src.Entities
{
    public abstract class Hero
    {    
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType{ get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacando ";
        }
    }
}