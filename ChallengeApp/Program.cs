using ChallengeApp;

var employee = new Employee("Tomasz", "Kowalski");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(5);
var statistic = employee.GetStatistics();

Console.WriteLine($"Average: {statistic.Average:N2}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");
































