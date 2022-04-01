using TypesAndReferences;
using static System.Console;

public class Program
{
    static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);

        WriteLine($"O valor da variavel a é {a}");
    }
    static int Adicionar20(int a)
    {
        return a + 20;
    }

    static void TrocarNome(Pessoa p1, string novoNome) 
    {
        p1.Nome = novoNome;
    }

    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Gabriel";
        p1.Idade = 24;
        p1.Documento = "1234";

        Pessoa p2 = p1.Clone();

        TrocarNome(p1, "Wstside");

        WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nome de p2 é: {p2.Nome}
        ");
    }
}