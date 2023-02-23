using ChallengeApp;

var employee = new Employee("Tomasz", "Kowalski");
employee.AddGrade(34);
employee.AddGrade(45);
employee.AddGrade(5);
employee.AddGrade(5);

Console.WriteLine("Pętla przy pomocy Foreach");
var statistic = employee.GetStatistics();
Console.WriteLine($"Average: {statistic.Average:N2}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine("");

Console.WriteLine("Pętla przy pomocy For");
statistic = employee.GetStatisticsWithFor();
Console.WriteLine($"Average: {statistic.Average:N2}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine("");

Console.WriteLine("Pętla przy pomocy DoWhile");
statistic = employee.GetStatisticsWithDoWhile();
Console.WriteLine($"Average: {statistic.Average:N2}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine("");

Console.WriteLine("Pętla przy pomocy While");
statistic = employee.GetStatisticsWithWhile();
Console.WriteLine($"Average: {statistic.Average:N2}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine("");



































