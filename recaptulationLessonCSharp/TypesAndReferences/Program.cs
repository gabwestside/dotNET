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

    static void Demo2()
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

    static int Adicionar20(int a)
    {
        return a + 20;
    }

    static void TrocarNome(Pessoa p1, string novoNome)
    {
        p1.Nome = novoNome;
    }

    static StructPessoa TrocarNome(StructPessoa p1, string novoNome)
    {
        p1.Nome = novoNome;
        return p1;
    }

    public static void Main()
    {
        StructPessoa p1 = new StructPessoa
        {
            Documento = "1234",
            Idade = 24,
            Nome = "Gabriel"
        };

        var p2 = p1;

        p1 = TrocarNome(p1, "Westside");

        WriteLine($@"
            Nome do p1: {p1.Nome}
            Nome do p2: {p2.Nome}
        ");
    }
}