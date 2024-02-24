using System.Text.RegularExpressions;
using System.Transactions;
using System.Diagnostics.CodeAnalysis;

//Escribe un programa que calcule la distancia entre dos puntos

Console.WriteLine("Ingrese las coordenadas del primer punto:");
Console.Write("Ingrese x: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese y: ");
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese las coordenadas del segundo punto:");
Console.Write(" Ingrese x: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Ingrese y: ");
double y2 = double.Parse(Console.ReadLine());
double resultado = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
Console.WriteLine("La distancia es de:" + resultado);











