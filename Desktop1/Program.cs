using System;

namespace Desktop1_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Chevete chevete = new Chevete();
            chevete.cor = "Roxo";
            chevete.qtdGasolina = 15;
            chevete.rodas = 4;
            chevete.numPortas = 2;

            Chevete chevete2 = new Chevete();
            chevete2.cor = "Preto";
            chevete2.qtdGasolina = 2;
            chevete2.numPortas = 3;
            chevete2.rodas = 4;

            Console.WriteLine("Chevete 1:");
            Console.WriteLine("Cor: " + chevete.cor);
            Console.WriteLine("Quantidade de gasolina: " + chevete.qtdGasolina + "L");
            Console.WriteLine("Número de rodas: " + chevete.rodas);
            Console.WriteLine("Número de portas: " + chevete.numPortas);

            Console.WriteLine();

            Console.WriteLine("Chevete 2:");
            Console.WriteLine("Cor: " + chevete2.cor);
            Console.WriteLine("Quantidade de gasolina: " + chevete2.qtdGasolina + "L");
            Console.WriteLine("Número de rodas: " + chevete2.rodas);
            Console.WriteLine("Número de portas: " + chevete2.numPortas);


        }
    }
}
