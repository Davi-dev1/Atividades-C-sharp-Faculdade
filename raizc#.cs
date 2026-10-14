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
    
    
    string[] p1 = Console.ReadLine().Split(' ');

double x1 = double.Parse(p1[0], CultureInfo.InvariantCulture);
double y1 = double.Parse(p1[1], CultureInfo.InvariantCulture);

    
    string[] p2 = Console.ReadLine().Split(' ');

double x2 = double.Parse(p2[0], CultureInfo.InvariantCulture);
double y2 = double.Parse(p2[1], CultureInfo.InvariantCulture);
    
    
    double distancia =(x2-x1)*(x2-x1) + (y2-y1)*(y2-y1);
    double result = Math.Sqrt(distancia);
    Console.WriteLine("{0}",result.ToString("0.0000")); 
    
    
  }
}