using System;

namespace TESTE {
    class Program {
         static void Main(string[] args)
      {
         // Declarando a entrada normalmente
            int N = int.Parse(Console.ReadLine());

            int a = 1, b = 2, c = 3;
            for (int i = 1; i <= N; i++) {
                
                Console.WriteLine($"{a} {b} {c} PUM");
                a += 4;
                b += 4;
                c += 4;
         }
    }
}
}