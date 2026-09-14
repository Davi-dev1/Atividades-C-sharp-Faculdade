// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



int a, b;

double x;


Console.WriteLine("Calculadora \n");

Console.WriteLine("\nDigite  o valor de a = ");

a = int.Parse(Console.ReadLine());

Console.WriteLine("\nDigite o valor de b = ");
b = int.Parse(Console.ReadLine());
x = 10.5;
x = (int)x;
x = (double)a / b;
Console.WriteLine("A = {0} e B = {1}",a,b);
Console.WriteLine("\nValor da soma  =  "+(a+b));
Console.WriteLine("\nValor da subtração = " + (a - b));
Console.WriteLine("\nValor da multiplicação = " +(a*b));
Console.WriteLine("\nValor da Divisão = " + x.ToString("0.00"));
Console.WriteLine("\nValor da Divisão = {0}", x.ToString("0.00"));
