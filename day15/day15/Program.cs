
using day15;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
Console.WriteLine("               Welcome to the SiMoN employee evaluation program              ");
Console.WriteLine("=============================================================================");
Console.WriteLine();

Console.WriteLine("Enter the employee's data and their grades one by one to get their statistics\n\n");
Console.ResetColor();

Console.WriteLine("Enter the name of the employee:");
var name = DataInput();

Console.WriteLine("Enter the surname of the employee:");
var surname = DataInput();

string sex = SexInput();

int age = AgeInput();

string jobPosition = JobPositionInput();

string selectMemory = SelectMemory();

if (jobPosition == "Supervisor" && selectMemory == "In program memory")
{
    var employee = new SupervisorInMemory(name, surname, sex, age, jobPosition);
    employee.GradeAdded += EmployeeGradeAdded;
    AddGradesSupervisor(employee);
    VievStatistics(employee);
}
else if (jobPosition == "Supervisor" && selectMemory == "In file")
{
    var employee = new SupervisorInFile(name, surname, sex, age, jobPosition);
    employee.GradeAdded += EmployeeGradeAddedInFile;
    AddGradesSupervisor(employee);
    VievStatistics(employee);
}
else if (jobPosition == "Employee" && selectMemory == "In program memory")
{
    var employee = new EmployeeInMemory(name, surname, sex, age, jobPosition);
    employee.GradeAdded += EmployeeGradeAdded;
    AddGradesEmployee(employee);
    VievStatistics(employee);
}
else if (jobPosition == "Employee" && selectMemory == "In file")
{
    var employee = new EmployeeInFile(name, surname, sex, age, jobPosition);
    employee.GradeAdded += EmployeeGradeAddedInFile;
    AddGradesEmployee(employee);
    VievStatistics(employee);
}
else
{
    Console.WriteLine("Something went wrong, please try again!\n");
}
static string DataInput()
{
    string input;
    while (true)
    {
        input = null;
        var dataInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(dataInput))
        {
            input = dataInput;
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Data cannot be left blank, please try again!");
            Console.ResetColor();
        }
    }
    return input;
}
static string SexInput()
{
    string sex;
    while (true)
    {
        Console.WriteLine("Enter the sex of the employee:\n M - male, F - female");
        var sexInput = Console.ReadLine();
        if (sexInput == "M" || sexInput == "m")
        {
            sex = "Male";
            break;
        }
        else if (sexInput == "F" || sexInput == "f")
        {
            sex = "Female";
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{sexInput}] is incorect gender");
            Console.ResetColor();
        }
    }
    return sex;
}
static int AgeInput()
{
    int age;
    while (true)
    {
        Console.WriteLine("Enter the age of the employee:");
        bool ageInInt = int.TryParse(Console.ReadLine(), out age);
        if (age > 0 && age <= 200)
        {
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid age value! \n");
            Console.ResetColor();
        }
    }
    return age;
}
static string JobPositionInput()
{
    string jobPosition;
    while (true)
    {
        Console.WriteLine("Enter the employee's job title:\n S - Supervisor, E - Employee");
        var position = Console.ReadLine();
        if (position == "S" || position == "s")
        {
            jobPosition = "Supervisor";
            break;
        }
        else if (position == "E" || position == "e")
        {
            jobPosition = "Employee";
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{position}] is incorect job title");
            Console.ResetColor();
        }
    }
    return jobPosition;
}
static string SelectMemory()
{
    string selectMemory;
    while (true)
    {
        Console.WriteLine("Select the type of memory to save grades:\n M - program memory, F - in file");
        var inputMemory = Console.ReadLine();
        if (inputMemory == "M" || inputMemory == "m")
        {
            selectMemory = "In program memory";
            break;
        }
        else if (inputMemory == "F" || inputMemory == "f")
        {
            selectMemory = "In file";
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{inputMemory}] is incorect memory type");
            Console.ResetColor();
        }
    }
    return selectMemory;
}
static void AddGradesSupervisor(IEmployee employee)
{
    while (true)
    {
        Console.WriteLine("Enter the next grade  from 1 to 6, you can also use + or - for each rating, or press Q to view statistics");
        var inputGrade = Console.ReadLine();
        if (inputGrade == "q" || inputGrade == "Q")
        {
            break;
        }
        try
        {
            employee.AddGrade(inputGrade);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{ex.Message}");
            Console.ResetColor();
        }
    }
}
static void AddGradesEmployee(IEmployee employee)
{
    while (true)
    {
        Console.WriteLine("Enter the next grade from 0 to 100, or from A to F and press Enter, or press Q to view statistics");
        var inputGrade = Console.ReadLine();
        if (inputGrade == "q" || inputGrade == "Q")
        {
            break;
        }
        try
        {
            employee.AddGrade(inputGrade);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{ex.Message}");
            Console.ResetColor();
        }
    }
}
static void VievStatistics(IEmployee employee)
{
    var statistics = employee.GetStatistics();

    Console.WriteLine("----------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"\n{employee.JobPosition} {employee.Name} {employee.Surname}  {employee.Sex} {employee.Age} years old received the evaluation results:");
    Console.WriteLine($"Number of ratings: {statistics.Count}");
    Console.WriteLine($"Sum of ratings: {statistics.Sum:N2}");
    Console.WriteLine($"Average of ratings: {statistics.Average:N2}");
    Console.WriteLine($"Maximum rating: {statistics.Max:N2}");
    Console.WriteLine($"Minimum rating: {statistics.Min:N2}");
    Console.WriteLine($"Average Letter is {statistics.AverageLetter}\n");
    Console.ResetColor();
}
static void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("A new grade has been added!\n");
    Console.ResetColor();
}
static void EmployeeGradeAddedInFile(object sender, EventArgs args)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("A new grade has been added in File!\n");
    Console.ResetColor();
}