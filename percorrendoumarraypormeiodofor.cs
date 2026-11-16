      
      string[] valores =  Console.ReadLine().Split(' ');
  int v1 = int.Parse(valores[0]);
  int v2 = int.Parse(valores[1]);
  int v3 = int.Parse(valores[2]);
//   Console.WriteLine("Valores : {0},{1},{2}",v1,v2,v3);
  
  for(int i = 0; i<3;i++){
      Console.WriteLine("Valor  {0} em valores : {1}",i+1,valores[i]);
  }
