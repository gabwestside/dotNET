using System.Globalization;
using System.Collections.Generic;
using System.Text;
public class ContaBancaria
{
    public int number { get; private set; }

    public string name { get; set; }

    public double balance { get; private set; }

    public ContaBancaria(int Number, string Name, double Balance)
    {
        number = Number;
        name = Name;
    }
    public ContaBancaria(int Number, string Name, double Balance) : this(number, name)
    {
        balance = Balance;
    }

    // public ContaBancaria(int Number, string Name, double Balance) : this(number, name)
    // {
    //     balance = Balance;
    // }
    // public double SaldoInicial()
    // {
    //     return balance = 0;
    // }

    // public double Deposito()
    // {
    //     return balance + initialDeposit + deposit;
    // }

    // public double Saque()
    // {
    //     return Deposito() - withdraw;
    // }

    public override string ToString()
    {
        return number
            + ", Titular: "
            + name
            + ", "
            + balance.ToString("F2", CultureInfo.InvariantCulture)
            + " deposito inicial."
            ;
    }
}