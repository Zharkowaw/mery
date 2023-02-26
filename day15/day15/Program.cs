using day15;

Console.WriteLine("-----Witamy w programie >>Oceny pracowników<<---");
Console.WriteLine("------------------------------------------------");
Console.WriteLine();
Console.WriteLine("--------------Infromacje------------------------");
Console.WriteLine("A - Pracownik z szansą na awans");
Console.WriteLine("B - Dobry pracownik");
Console.WriteLine("C - Przeciętny");
Console.WriteLine("D - Do poprawy!");
Console.WriteLine("E - Do zwolnienia!");
Console.WriteLine("------------------------------------------------");
Console.WriteLine();
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Wprowadź dane pracownika i oceny w skali 0-100 ");
Console.WriteLine("------------------------------------------------");
Console.WriteLine();
Console.WriteLine("------------------------------------------------");
Console.WriteLine("---Żeby zakonczyć sesję należy wpisać Q......---");
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Podaj imię: ");


string inputName = Console.ReadLine();

Console.WriteLine("Podaj nazwisko: ");
string inputSurname = Console.ReadLine();

Console.WriteLine("Podaj wiek: ");
int inputAge = Convert.ToInt32(Console.ReadLine());

var employee = new Employee(inputName, inputSurname);
var supervisor = new Supervisor(inputName, inputSurname);

while (true)
{
    Console.WriteLine("Dodaj ocene pracownika lub zakoncz sesje wciskająć Q i enter... ");

    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Exception catched: {exception.Message}");
    }
}

while (true)
{
    Console.WriteLine("Dodaj ocene pracownika lub zakoncz sesje wciskająć Q i enter... ");

    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }
    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Exception catched: {exception.Message}");
    }
}

var statisticsEmployee = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine("Podsumowanie ");
Console.Write($"Imię i nazwisko pracownika - {inputName} {inputSurname}\n");

Console.WriteLine($"Ocena min. - {statisticsEmployee.Min}");
Console.WriteLine($"Ocena max. - {statisticsEmployee.Max}");
Console.WriteLine($"Średnia z uzyskanych ocen - {statisticsEmployee.Average:N2}");
Console.WriteLine($"Ocena  - {statisticsEmployee.AverageLetter}");

var statisticsSupervisor = supervisor.GetStatistics();

Console.WriteLine();
Console.WriteLine("Podsumowanie  ");
Console.Write($"Imię i nazwisko kierownika - {inputName} {inputSurname}\n");

Console.WriteLine($"Ocena min.- {statisticsSupervisor.Min}");
Console.WriteLine($"Ocena max. - {statisticsSupervisor.Max}");
Console.WriteLine($"Średnia z uzyskanych ocen - {statisticsSupervisor.Average:N2}");
Console.WriteLine($"Ocena - {statisticsSupervisor.AverageLetter}");
