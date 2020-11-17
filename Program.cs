using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;

            Console.WriteLine("Digite o número que você quer ver a tabuada.");
            numero = int.Parse(Console.ReadLine());

            for(int n = 1; n <= 10; n++) {

                resultado = numero * n;
                Console.WriteLine(n+ " X " +numero+ " = " +resultado);
            }

            Console.ReadLine();
        }
    }
}
