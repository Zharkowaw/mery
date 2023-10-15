// liczby cakowite
using System.Globalization;
int myAge = 120;
int newAge = myAge + 6;
int myVar = int.MinValue;
uint myVar2 = uint.MaxValue;
ulong myVar3 = ulong.MaxValue;

//liczby zmiennoprzecinkowe 
float myNuber = float.MaxValue;
double myNuber2 = double.MaxValue;

//zmienne tekstowe
string name = "Wiktoria";
string surname = "1";
string result = name + surname + myAge;
//Console.WriteLine(result);
char myVar5 = 'c';
var result2 = name.ToArray();

//zmienna logiczna
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
Console.WriteLine(isValid);