using System.Globalization;

string nome;
double salarioFixo;
double totalVendas;

nome = Console.ReadLine();
//Console.WriteLine("Olá {0}",nome);

salarioFixo = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture); // CultureInfo.InvariantCulture força o C# a usar o padrão internacional, fazendo com que o ponto (.) seja sempre lido como separador decimal, independentemente do idioma ou das definições do sistema operativo.
totalVendas = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
double Total = (totalVendas * 0.15 ) + salarioFixo;
Console.WriteLine("TOTAL = R${0}", Total.ToString("f2"));
