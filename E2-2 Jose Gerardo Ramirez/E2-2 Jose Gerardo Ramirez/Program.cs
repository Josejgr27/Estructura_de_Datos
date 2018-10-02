using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_2_Jose_Gerardo_Ramirez
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci Fibonacci = new Fibonacci(); //Inicio del modo Iterativo
            Console.Write("Introduzca las sumas requeridas del Fibonacci para ambos modos: ");
            int NumeroDeSumas = int.Parse(Console.ReadLine());
            DateTime InicioFor = DateTime.Now;
            Fibonacci.Iterativo(NumeroDeSumas);
            DateTime FinalFor = DateTime.Now;
            Fibonacci.ConversionASegundos(InicioFor, FinalFor);
            Console.ReadKey(); 
            DateTime InicioRecursividad = DateTime.Now; //Inicio del modo Recursivo
            int Numero = 1;
            while(Numero<=NumeroDeSumas)
            {
             Console.WriteLine(Fibonacci.Recursividad(Numero));
                Numero++;
            }    
            DateTime FinalRecursividad = DateTime.Now;
            Fibonacci.ConversionASegundos(InicioRecursividad, FinalRecursividad);
            Console.ReadKey();
        }
    }
}
