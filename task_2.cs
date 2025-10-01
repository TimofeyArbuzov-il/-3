using System;

namespace task_2.cs
{
    enum BankAccountType
    {
        Current,   
        Savings    
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
