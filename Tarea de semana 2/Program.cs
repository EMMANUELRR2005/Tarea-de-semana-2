using System.Text.RegularExpressions;
using System.Transactions;
using System.Diagnostics.CodeAnalysis;

//Escribe un programa que lea una cadena de texto y cuente el numero de vocales que tiene 

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
int vocales = Regex.Matches(texto, "[aeiouAEIOU]").Count;
Console.WriteLine("Su palabra tiene: " + vocales);













