// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

//Console.WriteLine("Hello, World!");


//double a, b, c;

//Console.WriteLine("Digite a primeira nota : ");
//a = Convert.ToDouble(Console.ReadLine().Replace('.',','));
//Console.WriteLine("Digite a segunda nota : ");
//b = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
//Console.WriteLine("Digite a terceira nota : ");
//c = Convert.ToDouble(Console.ReadLine().Replace('.', ','));


//double media = (a * 2 + b * 3 + c * 5)/10.0;
//Console.WriteLine("MEDIA = " + media.ToString("F1").Replace(",","."));


double primeiraNota;
double segundaNota;
double result;


Console.WriteLine("Calculo de Médias");

Console.WriteLine("Digite a Primeira Nota: ");
primeiraNota = double.Parse(Console.ReadLine().Replace('.', ','));
// Console.WriteLine("Primeira nota definida é : " +primeiraNota.ToString("0.00000"));


Console.WriteLine("Digite a Segunda Nota: ");
segundaNota = double.Parse(Console.ReadLine().Replace('.', ','));
// Console.WriteLine("Segunda nota definida é : " +segundaNota.ToString("0.00000"));


result = (primeiraNota*3.5 + segundaNota*7.5) / 11;

Console.WriteLine("MÉDIA = " + result.ToString("0.00000"));

