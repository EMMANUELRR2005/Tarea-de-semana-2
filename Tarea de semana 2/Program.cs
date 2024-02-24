using System.Text.RegularExpressions;
using System.Transactions;
using System.Diagnostics.CodeAnalysis;

//Escriba un programa que calcule el area de un triangulo 

Console.WriteLine("Ingrese la base del triangulo");
int bases = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triangulo");
int altura = int.Parse(Console.ReadLine());

float area = (bases * altura) / 2f;
Console.WriteLine("el area del triangulo es: " + area);











