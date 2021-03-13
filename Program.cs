using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            double cm = 100, km = 1000, metros, resCM, resKM;

            Console.Write("Digite o valor em METROS: ");
            entrada = Console.ReadLine();
           
           metros = Convert.ToDouble(entrada);

           resCM = metros * cm;
           resKM = metros / km;
           

           Console.WriteLine($"{metros} Metros");
           Console.WriteLine();
           Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("--------CONVERSÃO--------");
           Console.ResetColor();
           Console.WriteLine();
           Console.WriteLine($"A conversão para Centimetros é {resCM}");
           Console.WriteLine($"A conversão para Quilômetros é {resKM:N3}");


        

        }
    }
}
