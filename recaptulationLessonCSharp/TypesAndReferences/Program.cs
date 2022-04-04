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

    static void Demo3()
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

    static void Demo4()
    {
        string name = "Gabriel";

        TrocarNome(name, "Westside");

        WriteLine($"O novo nome é {name}");
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

    static void TrocarNome(string name, string novoNome)
    {
        name = novoNome;
    }

    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }

    public static void Main()
    {
        int[] pares =  new int[]{0,2,4,6,8};

        MudarParaImpar(pares);

        WriteLine($"Os impares {string.Join(", ", pares)}");
    }
}