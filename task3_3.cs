// Создаем перечисление для ВУЗов
enum University
{
    VUZKGU, // ВУЗКГУ
    KAI,     // КАИ
    KHTI     // КХТИ
}

// Создаем структуру для работника
struct Worker
{
    public string Name;      // Имя работника
    public University Uni;   // ВУЗ, в котором учился работник
}

// Создаем переменную типа Worker и заполняем ее
Worker worker = new Worker
{
    Name = "Иван Иванов",
    Uni = University.KAI
};
Console.WriteLine($"Имя работника: {worker.Name}");
Console.WriteLine($"ВУЗ: {worker.Uni}");