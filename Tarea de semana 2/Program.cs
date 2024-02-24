using System.Text.RegularExpressions;
using System.Transactions;
using System.Diagnostics.CodeAnalysis;

1.
//Codigo que convierte un numero entero a decimal

int entero = 10;

decimal deci = Convert.ToDecimal(entero);

Console.WriteLine("El numero 10 en decimal es: " + deci.ToString("0.0"));

2.

//Numero decimal a flotante

decimal deci = 10.10m;
float flotante = (float)(deci);

Console.WriteLine("Su numero decimal " + deci + " ha sido cambiado a flotante " + flotante);

3.

//Numero flotante a entero 

float flotante = 10.1f;

int entero = Convert.ToInt16(((flotante)));

Console.WriteLine("Su numero flotante " + flotante + " Ha sido cambiado a entero: " + entero);

4.

//Caracter a entero

char caracter = 'A';

int entero = Convert.ToInt16(caracter);

Console.WriteLine("El caracter " + caracter + " Ha sido cambiado a entero: " + entero);

5.

//Entero a caracter 

int entero = 65;

char caracter = Convert.ToChar(entero);

Console.WriteLine("Su entero " + entero + " Ha sido cambiado a caracter: ");

6.

//Suma de dos enteros


int num1 = 10;
int num2 = 20;

int respuesta = num1 + num2;

Console.WriteLine("La suma de " + num1 + " + " + num2 + " Es igual a: " + respuesta);

7.

//Resta de dos decimales

decimal num1 = 22.10m;

decimal num2 = 10.10m;

decimal respuesta = num1 - num2;

Console.WriteLine("La resta entre " + num1 + " - " + num2 + "Es igual a: " + respuesta);

8.
//Multiplicacion de dos flotantes

float num1 = 5.5f;

float num2 = 10.1f;

float respuesta = num1 * num2;

Console.WriteLine("La Multiplicacion entre " + num1 + " * " + num2 + " Es igual a: " + respuesta);

9.
//Division entre dos numeros enteros 

int num1 = 100;
int num2 = 2;

int respuesta = num1 / num2;

Console.WriteLine("La division entre " + num1 + " / " + num2 + " Es igual a: " + respuesta);

10.

//Calcular el modulo de dos numeros enteros 

int num1 = 23;
int num2 = 15;
float mod = num1 % num2;

Console.WriteLine("La division de los dos numeros es: " + mod);

11.

//Escrbie un programa que lea una cadena de texto y la imprima en mayusculas 

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
string txtm = texto.ToUpper();
Console.WriteLine(txtm);

12.

//Escriba un programa que lea una cadena de textos y la imprima en minusculas

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
string txtm = texto.ToLower();
Console.WriteLine(txtm);

13.

//Escribe un programa que lea una cadena de texto y la imprima al reves

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
string txtm = new string(texto.Reverse().ToArray());
Console.WriteLine(txtm);

14.

//Escribe un programa que lea una cadena de texto y busque una palabra en ella

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
Console.WriteLine("Cual es la palabra que busca?");
string palabra = Console.ReadLine();
if (texto.Contains(palabra))


    Console.WriteLine("La palabra si está en el texto");

else

    Console.WriteLine("La palabra no esta en el texto");

15.

//Escribe un programa que lea una cadena de texto y cuente el número de vocales que contiene. 

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
int vocales = Regex.Matches(texto, "[aeiouAEIOU]").Count;
Console.WriteLine("Su palabra tiene: " + vocales);

16.

//Escriba un programa que calcule el area de un triangulo 

Console.WriteLine("Ingrese la base del triangulo");
int bases = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triangulo");
int altura = int.Parse(Console.ReadLine());

float area = (bases * altura) / 2f;
Console.WriteLine("el area del triangulo es: " + area);

17.


//Escribe un programa que calcule el volumen de una esfera.

using System.Formats.Asn1;
using System.Text.RegularExpressions;

Console.WriteLine("Ingrese el radio de la esfera");
double radio = double.Parse(Console.ReadLine());
double volumen = (3.14 * (4 * (radio * radio * radio))) / 3;

Console.WriteLine("el volumen de una esfera es: " + volumen);

18.

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

19.

//Escribe un programa que calcule la temperatura en grados Fahrenheit a partir de la temperatura en grados Celsius

Console.WriteLine("Ingrese la temperatura en grados celsius:");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine("la temperatura en grados Fahrenheit es de:" + fahrenheit);

20.

//Escribe un programa que calcule la temperatura en grados Celsius a partir de la temperatura en grados Fahrenheit.

Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
double fahrenheit = double.Parse(Console.ReadLine());
double celsius = (fahrenheit - 32) * 5 / 9;

Console.WriteLine("la temperatura en grados Celsius es de:" + celsius);











