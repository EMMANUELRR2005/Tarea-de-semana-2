using System.Text.RegularExpressions;
using System.Transactions;
using System.Diagnostics.CodeAnalysis;

//Escribe un programa que calcule la temperatura en grados Celsius a partir de la temperatura en grados Fahrenheit.

Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
double fahrenheit = double.Parse(Console.ReadLine());
double celsius = (fahrenheit - 32) * 5 / 9;

Console.WriteLine("la temperatura en grados Celsius es de:" + celsius);











