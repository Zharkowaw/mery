using ChallengeApp;

var employee = new Employee("Weber", "Webow");

employee.AddGrade(4);
employee.AddGrade(6);
employee.AddGrade(2);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N3}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
