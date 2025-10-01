using System;

namespace task_3.cs
{
    enum University
    {
        KGU,
        KAI,
        KHTI
    }

    struct Employee
    {
        public string Name;
        public University Uni;

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.Write("ВУЗ: ");
            switch (Uni)
            {
                case University.KGU: Console.WriteLine("КГУ"); break;
                case University.KAI: Console.WriteLine("КАИ"); break;
                case University.KHTI: Console.WriteLine("КХТИ"); break;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Employee worker = new Employee { Name = "Иванов Иван", Uni = University.KAI };
            worker.PrintInfo();
        }
    }
}
