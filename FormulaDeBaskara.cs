using System; 
using System.Globalization;

class FormulaDeBaskara {

    static void Main(string[] args) { 

            
            string[] valor = Console.ReadLine().Split(' ');
            //declare a variavel corretamente
            double a = double.Parse(valor[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valor[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valor[2], CultureInfo.InvariantCulture);
        //declare as demais variaveis

            double delta = Math.Pow(b, 2) - (4 * a * c);
            
            

            if (delta > 0 && a > 0 )
            {
              double r1 = (-b + (Math.Sqrt(delta))) / (2 * a);
              double r2 = (-b - (Math.Sqrt(delta))) / (2 * a);//complete a condicional
            
              Console.WriteLine("R1 = " + r1.ToString("F5",CultureInfo.InvariantCulture));
              Console.WriteLine("R2 = " + r2.ToString("F5",CultureInfo.InvariantCulture));
              
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }

    }

}