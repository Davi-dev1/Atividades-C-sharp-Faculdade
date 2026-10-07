
using System;
using System.Globalization;
class HelloWorld {
  static void Main() {
   
string[] linha1= Console.ReadLine().Split(' ');

int codigo1 = int.Parse(linha1[0]);
int qtd1    = int.Parse(linha1[1]);
double preco1 = double.Parse(linha1[2], CultureInfo.InvariantCulture);
   
   
   string[] linha2 = Console.ReadLine().Split(' ');

int codigo2 = int.Parse(linha2[0]);
int qtd2    = int.Parse(linha2[1]);
double preco2 = double.Parse(linha2[2], CultureInfo.InvariantCulture);
   
   
  preco1 *= qtd1;
 preco2 *= qtd2;

double total = preco1 +  preco2;

Console.WriteLine("VALOR A PAGAR : R$ {0}",total.ToString("F2"));

  
  
  }
}
