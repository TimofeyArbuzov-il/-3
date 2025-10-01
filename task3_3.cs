enum University
{
    VUZKGU, 
    KAI,     
    KHTI     
}

struct Worker
{
    public string Name;      
    public University Uni;   
}

Worker worker = new Worker
{
    Name = "Иван Иванов",
    Uni = University.KAI
};
Console.WriteLine($"Имя работника: {worker.Name}");
Console.WriteLine($"ВУЗ: {worker.Uni}");
