using System;

struct BankAccount
{
    public string AccountNumber;
    public string AccountType;
    public double Balance;
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount
        {
            AccountNumber = "123456789",
            AccountType = "Текущий",
            Balance = 1000.50
        };
        Console.WriteLine($"Номер счета: {account.AccountNumber}");
        Console.WriteLine($"Тип счета: {account.AccountType}");
        Console.WriteLine($"Баланс: {account.Balance}");
    }
}