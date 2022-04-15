using System;

namespace DIO {
    class ContagemDeCedulas {
        static void Main(string[] args) {
           
            int n = int.Parse(Console.ReadLine());

            //Exibir "Ho" do papai noel
            for (int i = 0; i < n - 1; i++) 
                {
                    Console.Write("Ho "); //Complete o código no espaço em branco
                }
                
                if (n !=0)
                {
                    Console.WriteLine("Ho!");
                }
            }
        }
    }