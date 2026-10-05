using System.Globalization;

int codigo1, codigo2;
int qtd1,qtd2;
double preco1,preco2;

double total1, total2;

codigo1  = int.Parse(Console.ReadLine());
//Console.WriteLine(codigo1);

qtd1 = int.Parse(Console.ReadLine());

preco1=Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);



codigo2 = int.Parse(Console.ReadLine());
//Console.WriteLine(codigo2);

qtd2 = int.Parse(Console.ReadLine());

preco2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

total1 = preco1 * qtd1;
total2 = preco2 * qtd2;

double total = total1 +  total2;

Console.WriteLine("VALOR A PAGAR : R$ {0}",total.ToString("F2"));
