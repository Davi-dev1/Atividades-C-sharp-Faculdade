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
   String[] linha1= Console.ReadLine().Split(' ');
    int A = int.Parse(linha1[0]);
    int B = int.Parse(linha1[1]);
    int C = int.Parse(linha1[2], CultureInfo.InvariantCulture);
    int MaiorAB;
    int MaiorValor;
    MaiorAB = (A+B+Math.Abs(A-B))/2;
    MaiorValor = (MaiorAB + C+Math.Abs(MaiorAB - C))/2;
    Console.WriteLine("{0} eh o maior", MaiorValor );
    
    
  }
}
