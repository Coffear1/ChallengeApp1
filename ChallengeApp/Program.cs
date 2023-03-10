using ChallengeApp;
using System.Runtime.CompilerServices;

Console.WriteLine("Witamy w Programie XYZ do oceny pracownika");
Console.WriteLine("==========================================");
Console.WriteLine();

var employee = new EmployeeInMemory("Krzyszfof", "Stebel", 'M', 24);
employee.GradeAdded += EmployeeGradeAdded; 
employee.GradeAdded -= EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
       
    }
    catch (Exception e)
    {
       Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine("=====STATYSTYKI=====");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");
Console.WriteLine($"Average:{statistics.Average:N2}");












































