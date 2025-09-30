using System;

namespace Exercise3_1
{
    enum BankAccountType
    {
        Current,   // Текущий счет
        Savings    // Сберегательный счет
    }

    class Program
    {
        static void Main()
        {
            BankAccountType accountType = BankAccountType.Current;
            string typeName = accountType == BankAccountType.Current ? "Текущий" : "Сберегательный";
            Console.WriteLine("Тип банковского счета: " + typeName);
        }
    }
}
