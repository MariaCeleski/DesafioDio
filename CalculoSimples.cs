using System;
using System.Globalization;

namespace calculoSimples
{
    class Dio
    {
        static void Main(string[] args)
        {
            int cod1, nPecas1, cod2, nPecas2;
            double valorUni1, valorUni2, total;

            string[] vet1 = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vet1[0]);
            nPecas1 = int.Parse(vet1[1]);
            valorUni1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vet2[0]);
            nPecas2 = int.Parse(vet2[1]);
            valorUni2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            total = (nPecas1 * valorUni1) + (nPecas2 * valorUni2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}