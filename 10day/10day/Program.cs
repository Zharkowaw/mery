﻿using day10;
var employee = new Employee("Wiktoria", "Webow");
double komunikat = double.MaxValue;
employee.AddGrades(komunikat);
employee.AddGrades("12");
employee.AddGrades("Mery");
employee.AddGrades(9);
employee.AddGrades(-29);
employee.AddGrades(199);
var statistics = employee.GetStatistics();
Console.Write($"Avarege: {statistics.Average:N2} ");
Console.Write($"Min: {statistics.Min} ");
Console.Write($"Max: {statistics.Max} ");