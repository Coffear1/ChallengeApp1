﻿using ChallengeApp;

Employee employee1 = new Employee("Artur", "Nowak", "32");
Employee employee2 = new Employee("Marcin", "Greń", "23");
Employee employee3 = new Employee("Bogdan", "Gawlas", "45");


employee1.AddScore(3);
employee1.AddScore(6);
employee1.AddScore(5);       // łącznie 26pkt
employee1.AddScore(4);
employee1.AddScore(8);

employee2.AddScore(4);
employee2.AddScore(8);
employee2.AddScore(5);       // łącznie 31pkt
employee2.AddScore(5);
employee2.AddScore(9);

employee3.AddScore(4);
employee3.AddScore(6);
employee3.AddScore(5);       //łącznie 30pkt
employee3.AddScore(6);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result; 
    }
}
Console.WriteLine("Pracownik z najwyższą liczbą punktów:" + " " + employeeWithMaxResult.Imię + " " + employeeWithMaxResult.Nazwisko + " " + maxResult + "pkt" );

































