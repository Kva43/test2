using System;
using System.Transactions;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Sumador sum = new Sumador(3);
            Sumador sum2 = new Sumador(0);

            //Console.WriteLine($"suma de objetos {nombre} y apellido es: {1}", , apellido);
            Console.WriteLine($"Suma de long : {sum2.Sumar(100, 687)} Sumador {sum2.Cantidad()}");
            Console.WriteLine($"suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum.Sumar("HOla ", "Munjjjjjdo")} Sumador {sum.Cantidad()}");
            if (sum | sum2)
            {
                Console.WriteLine("ES true");
            }
            Console.WriteLine($"suma de objetos {sum + sum2}");

            //CommittableTransaction 2
        }
    }
}