using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercicio da tabuada!
            Console.WriteLine("qual tabuada voce deseja ver? ");
            int resposta = int.Parse(Console.ReadLine());

            int resultado;

            for (int contador = 1; contador <= 10; contador++)
            {
                resultado = resposta * contador;
                Console.WriteLine($" {resposta} * {contador} = {resultado} ");
            }


            
            // While!

            // Console.WriteLine("Deseja receber um bom dia?");
            // string respondendo = Console.ReadLine();

            // int numeroDeVezes = 0;

            // while(respondendo == "Sim") {
            //     Console.WriteLine("Tenha um bom dia!");

            //     numeroDeVezes++;

            //     Console.WriteLine("Ainda deseja receber um bom dia?");
            //     respondendo = Console.ReadLine();
            // }

            // Console.WriteLine($"Número de vezes que foi processado: {numeroDeVezes}");
            // Console.WriteLine("fim!");


            // // Do While!

            // string resposta = "";

            // int numDeVezes = 0;

            // do {
            //     Console.WriteLine("Tenha um bom dia!");
            //     Console.WriteLine("Ainda deseja receber um bom dia?");

            //     numDeVezes++;

            //     resposta = Console.ReadLine();
            // } while(resposta == "Sim");


            // For!

            // Console.WriteLine("Qual o número de vezes que você deseja receber um bom dia?");

            // for(int contador = 10; contador >= 0; contador--){
            //     Console.WriteLine($"{contador} contando de 0 a 10!");
            //     System.Threading.Thread.Sleep(1200);
            // }
            // Console.WriteLine("contagem concluida!");

        }
    }
}
