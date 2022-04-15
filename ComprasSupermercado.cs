using System;
using System.Collections.Generic;
using System.Linq;

class ComprasSupermercado {
  public static void Main (string[] args) {
    
    int totalDeCasosDeTeste = int.Parse(Console.ReadLine());
    // Implemente a solução aqui
    for (int i = 0; i < totalDeCasosDeTeste; i++) {
      List<string> listDeCompras = new List<String>(Console.ReadLine().Split(' '));
      List<string> listaSemDuplicados = listDeCompras.Distinct().ToList();

      listaSemDuplicados.Sort();
  
      foreach (string item in listaSemDuplicados) {
        Console.Write($"{item} ");
      }
      
      Console.WriteLine(" ");
    }
  }
}

