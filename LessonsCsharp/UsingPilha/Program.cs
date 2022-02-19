using System;

namespace UsingPilha
{
    public class Program
    {
        public Program()
        {
            //Declara��o de vari�vel (objeto)
            Pilha p1;
            //Instancia��o de uma objeto
            p1 = new Pilha();
            p1.Push(45);
            p1.Push(36);
            p1.Push(72);
            this.Print(p1);
        }

        static void Main(string[] args)
        {
            Program app = new Program();
        }

        public void Print(Pilha pilha)
        {
            Pilha aux = new Pilha();

            //Desempilhando toda a p na aux
            while (pilha.Empty() == false)
            {
                aux.Push(pilha.Pop());
            }

            //Reempilhando toda a p a partir da aux
            while (aux.Empty() == false)
            {
                Console.WriteLine(aux.Top() + "-");
                pilha.Push(aux.Pop());
            }
        }
    }
}