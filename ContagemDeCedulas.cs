using System;

namespace DIO
{
    class ContagemDeCedulas
    {
        static void Main(string[] args)
         {
        
            int.TryParse(Console.ReadLine(), out int valor);
            int notas, resto;

            Console.WriteLine(valor);
            notas = valor / 100;
            resto = valor % 100;
            Console.WriteLine($"{notas} nota(s) de R$ 100,00");
            notas = resto / 50;
            resto %= 50;
            Console.WriteLine($"{notas} nota(s) de R$ 50,00");
            notas = resto / 20;
            resto %= 20;
            Console.WriteLine($"{notas} nota(s) de R$ 20,00");
            notas = resto / 10;
            resto %= 10;
            Console.WriteLine($"{notas} nota(s) de R$ 10,00");
            notas = resto / 5;
            resto %= 5;
            Console.WriteLine($"{notas} nota(s) de R$ 5,00");
            notas = resto / 2;
            resto %= 2;
            Console.WriteLine($"{notas} nota(s) de R$ 2,00");
            notas = resto;
            Console.WriteLine($"{notas} nota(s) de R$ 1,00");
                                                   
        }
    }
}