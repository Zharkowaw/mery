using day11;

var employee = new Employee("Wiktoria", "Webow");

employee.AddGrade("Mery");
employee.AddGrade("6000");
employee.AddGrade(16);
employee.AddGrade(13);
employee.AddGrade(12);

Console.WriteLine("Wyniki dla Foreach ↓");
var statistics = employee.ForeachStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");

Console.WriteLine("Wyniki dla For ↓ ");
statistics = employee.ForStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");

Console.WriteLine("Wyniki dla DoWhile ↓ ");
statistics = employee.DoWhileStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");

Console.WriteLine("Wyniki dla While ↓ ");
statistics = employee.WhileStatisticsWhile();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");