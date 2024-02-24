using System.Text.RegularExpressions;
using System.Transactions;
using System.Diagnostics.CodeAnalysis;

//Escribe un programa que lea una cadena de texto y la imprima al reves

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
string txtm = new string(texto.Reverse().ToArray());
Console.WriteLine(txtm);















