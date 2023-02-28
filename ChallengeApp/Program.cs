using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny pracownika");
Console.WriteLine("==========================================");
Console.WriteLine();

var employee = new Employee("Krzysztof", "Stebel");

while(true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if(input == "q" )
    {
        break;
    }
    employee.AddGrade(input);
}

var statistic = employee.GetStatistics();
Console.WriteLine("========================================");
Console.WriteLine($"Average Letter: {statistic.AverageLetter}");
Console.WriteLine($"Average: {statistic.Average:N2}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");





































