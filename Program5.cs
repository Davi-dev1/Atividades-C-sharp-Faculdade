/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
      int primeiroValor;
      int segundoValor;
      int produtoDosValores;
      
    Console.WriteLine(" -------- Produtos Simples ------- ");
    
    
    Console.WriteLine("Digite o primeiro valor:  ");
    primeiroValor = int.Parse(Console.ReadLine());
    // Console.WriteLine("O valor informado é : "+primeiroValor);
    
    
    Console.WriteLine("Digite o segundo valor:  ");
    segundoValor = int.Parse(Console.ReadLine());
    // Console.WriteLine("O valor informado é : "+segundoValor);
    
    produtoDosValores = primeiroValor * segundoValor;
    
    
    Console.WriteLine("PROD =  "+produtoDosValores);
    
    
    
  }
}
