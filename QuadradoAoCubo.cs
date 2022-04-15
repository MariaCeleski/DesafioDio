using System;

namespace DIO
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= n; i++)
            {

                //escreva aqui o seu código
                Console.WriteLine($"{i} {i * i} {i * i * i}");
            }
        }
    }
}