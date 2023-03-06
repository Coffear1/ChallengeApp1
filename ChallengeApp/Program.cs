using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny pracownika");
Console.WriteLine("==========================================");
Console.WriteLine();


var employee = new Employee("Krzysztof", "Stebel", 'M', 24);
var supervisior = new Supervisor("Agnieszka", "Nowak", 'K', 45);

Console.WriteLine("Wybierz odpowiednią osobę: Pracownik == '1' , Kierownik == '2' ");
var choisePerson = Console.ReadLine();



while (choisePerson != null)
{
    if (choisePerson == "1")
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
    else if (choisePerson == "2")
    {
        Console.WriteLine("Podaj kolejną ocenę kierownika");
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
}
var statistic = employee.GetStatistics();
Console.WriteLine("========================================");
Console.WriteLine($"Average Letter: {statistic.AverageLetter}");
Console.WriteLine($"Average: {statistic.Average:N2}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");






































