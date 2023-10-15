
using day13;

Console.WriteLine("Witamy w programie --Oceny pracowników-- ");
Console.WriteLine("-----------------------------------------");
Console.WriteLine();
Console.WriteLine("--------------Infromacje-----------------");
Console.WriteLine("A - Pracownik z szansą na awans");
Console.WriteLine("B - Dobry pracownik");
Console.WriteLine("C - Przeciętny");
Console.WriteLine("D - Do poprawy!");
Console.WriteLine("E - Do zwolnienia!");
Console.WriteLine("-----------------------------------------");

var employee = new Employee("Mery", "Webow", "Worker");

while (true)
{
    Console.WriteLine("Dodaj ocenę ");
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
        Console.WriteLine(e.Message);
    }
}


var statistics = employee.GetStatistics();
Console.Write(employee.Name + " ");
Console.Write(employee.Surname + " ");
Console.WriteLine(employee.Position);
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");