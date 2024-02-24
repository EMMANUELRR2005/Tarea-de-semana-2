using System.Text.RegularExpressions;
using System.Transactions;
using System.Diagnostics.CodeAnalysis;

//Escribe un programa que lea una cadena de texto y busque una palabra en ella

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
Console.WriteLine("Cual es la palabra que busca?");
string palabra = Console.ReadLine();
if (texto.Contains(palabra))


    Console.WriteLine("La palabra si está en el texto");

else

    Console.WriteLine("La palabra no esta en el texto");













