// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

Console.WriteLine("Hello, World!");


double a, b, c;

Console.WriteLine("Digite a primeira nota : ");
a = Convert.ToDouble(Console.ReadLine().Replace('.',','));
Console.WriteLine("Digite a segunda nota : ");
b = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
Console.WriteLine("Digite a terceira nota : ");
c = Convert.ToDouble(Console.ReadLine().Replace('.', ','));


double media = (a * 2 + b * 3 + c * 5)/10.0;
Console.WriteLine("MEDIA = " + media.ToString("F1").Replace(",","."));





