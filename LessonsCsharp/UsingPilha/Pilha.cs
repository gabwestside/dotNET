using System;

namespace UsingPilha
{
    public class Pilha
    {
        private int Capacidade = 50;
        private int[] Vetor;
        private int Topo = -1;

        public void Push(int element)
        {
            if (this.Size() < Capacidade)
            {
                Vetor[++Topo] = element;
            }
        }

        public int Pop()
        {                   //Desempilhar
            if (this.Empty() == false)
            {
                return Vetor[Topo--];
            }
            return -1;
        }

        public int Size()
        {
            return Topo + 1;
        }

        public Boolean Empty()
        {
            if (this.Size() == 0)
            {
                return true;
            }
            return false;
        }

        public int Top()
        {
            return Vetor[Topo];
        }
    }
}