using System.Text.RegularExpressions;
using System.Transactions;

//Codigo que convierte un numero entero a decimal

int entero = 10;

decimal deci = Convert.ToDecimal(entero);

Console.WriteLine("El numero 10 en decimal es: " + deci.ToString("0.0"));
