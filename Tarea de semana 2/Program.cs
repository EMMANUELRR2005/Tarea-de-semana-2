using System.Text.RegularExpressions;
using System.Transactions;
using System.Diagnostics.CodeAnalysis;

//Escribe un programa que calcule la temperatura en grados Fahrenheit a partir de la temperatura en grados Celsius

Console.WriteLine("Ingrese la temperatura en grados celsius:");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine("la temperatura en grados Fahrenheit es de:" + fahrenheit);











