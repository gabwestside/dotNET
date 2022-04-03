using static System.Console;

namespace BeeCrowdChallengesHomeEdition
{
    public class Desenho
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Peso { get; set; }
        public Desenho[] Filhos { get; set; }

        public int PesoTotal(int Peso, Desenho[] Filhos)
        {
            return Peso += Peso;
        }
    }
}