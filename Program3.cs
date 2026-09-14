// See https://aka.ms/new-console-template for more information

int primeiroValor;
int SegundoValor;
int soma;

Console.WriteLine("Digite o Valor de A ");
primeiroValor = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o Valor de B ");
SegundoValor = int.Parse(Console.ReadLine());

soma = primeiroValor + SegundoValor;
Console.WriteLine("SOMA = " + soma);
