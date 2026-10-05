/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Globalization;
class HelloWorld {
  static void Main() {
  double pi;
  int raio;
  
  pi = 3.14159;
  raio =  int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
  
  double valorTotal = (4/3.0) * pi * (raio*raio*raio);
  Console.WriteLine("VOLUME = {0}",valorTotal.ToString("0.000"));
  
  
  
  
  
  
  
  
  
  
  }
}