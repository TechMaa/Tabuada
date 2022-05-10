using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("==================== TABUADA ====================");
            Console.WriteLine("DIGITE UM NUMERO, PARA SABER SUA TABUADA");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = i * n;
                Console.WriteLine(n + "x" + i + " = " + resultado);
            }
        }
    }
}