namespace WestsideRPGWithVSCode.src.Entities
{
    public class Arus
    {
        public Arus(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Arus()
        { }

        public string Name;

        public int Level;

        public string HeroType;
    }
}