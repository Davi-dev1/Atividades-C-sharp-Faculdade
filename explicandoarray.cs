using System;
class HelloWorld {
    
    
    
  static void Main() {
      
      
string[] linha1= Console.ReadLine().Split(' ');

double A = Convert.ToDouble(linha1[0]);
double B = Convert.ToDouble(linha1[1]);
double C = double.Parse(linha1[2], CultureInfo.InvariantCulture);
  }
}



/*string[] linha1 = Console.ReadLine().Split(' ');

• Console.ReadLine(): O programa pausa e espera você digitar algo no teclado e apertar Enter. Digamos que você digitou: 2.5 4.0 6.5.
• .Split(' '): Ele pega o que você digitou e corta usando o espaço em branco como separador.
• string[] linha1: Guarda esses pedaços cortados em uma lista de textos.
	• linha1[0] vira "2.5"
	• linha1[1] vira "4.0"
	• linha1[2] vira "6.5"
csharp
double A = Convert.ToDouble(linha1[0]);

• O que faz: Pega o primeiro texto da lista (linha1[0], que é "2.5"), transforma ele em um número que aceita casas decimais (double) e guarda na variável A.
csharp
double B = Convert.ToDouble(linha1[1]);

• O que faz: Faz exatamente a mesma coisa com o segundo texto (linha1[1], que é "4.0"), transformando-o em número e guardando na variável B.
csharp
double C = double.Parse(linha1[2], CultureInfo.InvariantCulture);

• O que faz: Transforma o terceiro texto (linha1[2], que é "6.5") em número e guarda na variável C.
• O segredo do CultureInfo.InvariantCulture: Isso aqui serve para o programa não dar erro por causa do ponto (.). No Brasil, usamos vírgula para decimais (6,5), mas na programação usa-se o ponto (6.5). Esse comando avisa o C#: "Ei, ignore a configuração do computador do usuário e aceite o ponto como separador decimal".
*/
