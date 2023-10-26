using Bank;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Account ac1 = new Account(1000.0);

        Console.WriteLine(ac1.GetBalance());

        ac1.DepositFunds(500);

        Console.WriteLine(ac1.GetBalance());

    }
}