/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Globalization;
class HelloWorld {
  
static string[] linha1= Console.ReadLine().Split(' ');
static double A = Convert.ToDouble(linha1[0]);
static double B = Convert.ToDouble(linha1[1]);
static double C = double.Parse(linha1[2], CultureInfo.InvariantCulture);
 static double Area;
   
  static double Triangulo(){


  Area = (A *C )/2;
  Console.WriteLine("TRIANGULO: {0}",Area.ToString("0.000"));
  return Area;
  } 
  
static double circulo(){  
double pi;
  pi =  3.14159;
  Area = pi*(C*C);
  Console.WriteLine("CIRCULO: {0}",Area.ToString("0.000"));
    return Area;
  }
 
static double trapezio(){

    Area = (A + B)*C/2;
    Console.WriteLine("TRAPEZIO: {0}",Area.ToString("0.000"));
    return Area;
}
static double quadrado(){
    
    Area = B*B;
    Console.WriteLine("QUADRADO: {0}",Area.ToString("0.000"));
    return Area;
    
}  

static double retangulo(){
    Area = A * B;
    Console.WriteLine("RETANGULO: {0}",Area.ToString("0.000"));
    return Area;
}

  
  
  static void Main() {
  
   Triangulo();
   circulo();
   trapezio();
   quadrado();
   retangulo();
   
   
  }
}