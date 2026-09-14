/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
      double primeiraNota;
      double segundaNota;
      double result;
      

Console.WriteLine("Calculo de Médias");

Console.WriteLine("Digite a Primeira Nota: ");
primeiraNota = double.Parse(Console.ReadLine());
// Console.WriteLine("Primeira nota definida é : " +primeiraNota.ToString("0.00000"));


Console.WriteLine("Digite a Segunda Nota: ");
segundaNota = double.Parse(Console.ReadLine());
// Console.WriteLine("Segunda nota definida é : " +segundaNota.ToString("0.00000"));


result = primeiraNota + segundaNota/2;

Console.WriteLine("MÉDIA = "+result.ToString("0.00000"));


  }
}
