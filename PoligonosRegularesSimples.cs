class PoligonosRegularesSimples {

    static void Main(string[] args) { 

        string[] v = Console.ReadLine().Split();
            
        //Insira o seu código aqui
        uint.TryParse(v[0], out uint n);
        uint.TryParse(v[1], out uint l);
        Console.WriteLine(n * l);
    }

}