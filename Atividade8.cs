// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int numeroFunc;
int horasTrabalhadas;
double recebePorHora;
double TotalSalario;

Console.WriteLine("====== Calculadora  ======");

Console.WriteLine("Digite o seu número de funcionário");
numeroFunc = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a sua hora trabalhada");
horasTrabalhadas = int.Parse(Console.ReadLine());

Console.WriteLine("Digite quanto voce recebe por hora");
recebePorHora = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

TotalSalario = horasTrabalhadas * recebePorHora;
Console.WriteLine("NUMBER = " + numeroFunc);
Console.WriteLine("SALARY =  U$ " +TotalSalario.ToString("F2"));

