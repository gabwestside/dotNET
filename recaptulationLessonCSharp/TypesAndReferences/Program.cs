using static System.Console;

public class Program
{
    static int Adicionar20(int a)
    {
        return a + 20;
    }

    public static void Main()
    {
        int a = 2;
        a = Adicionar20(a);

        WriteLine($"O valor da variavel a é {a}");
    }
}