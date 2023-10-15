using System.Runtime;

var name = "Wiktoria";
var age = 44;
bool female = true;
bool male = true;

if (female && age > 30)
{
    Console.WriteLine("Kobieta powyżej 30 lat");
}
else if (name == "Wiktoria" && age == 44)
{
    Console.WriteLine("Wiktoria,Lat 44");
}
else if (male && age < 18)
{
    Console.WriteLine("Męszzycna poniżej 18 lat");
}
