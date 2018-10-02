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
            Fibonacci SumasIterativo = new Fibonacci(); //Inicio del modo Iterativo
            Console.Write("Introduzca las sumas requeridas del Fibonacci para ambos modos: ");
            int NumeroDeSumas = int.Parse(Console.ReadLine());
            DateTime InicioFor = DateTime.Now;
            SumasIterativo.Iterativo(NumeroDeSumas);
            DateTime FinalFor = DateTime.Now;
            TimeSpan DuracionFor = FinalFor - InicioFor;
            double SegundosTotalesFor = DuracionFor.TotalSeconds;
            Console.WriteLine("El programa Iterativo tiene una duracion de {0} segundos", SegundosTotalesFor);
            Console.ReadKey();
            Fibonacci SumasRecursivo= new Fibonacci(); //Inicio del modo Recursivo
            DateTime InicioRecursividad = DateTime.Now;
            for(int Contador = 0; Contador<=NumeroDeSumas; Contador++)
            {
                Console.WriteLine(SumasRecursivo.Recursividad(Contador));
            }
            DateTime FinalRecursividad = DateTime.Now;
            TimeSpan DuracionRecursividad = FinalRecursividad - InicioRecursividad;
            double SegundosTotalesRecursividad = DuracionRecursividad.TotalSeconds;
            Console.WriteLine("El programa con Recursividad tiene una duracion de {0} segundos", SegundosTotalesRecursividad);
            Console.ReadKey();
        }
    }
}
