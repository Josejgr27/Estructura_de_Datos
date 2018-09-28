using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            DateTime InicioFor = DateTime.Now; // inicio de programa con ciclo For
            int Resultado = 1;           
            for (int Contador =1; Contador<=6; Contador++)
            {
                Resultado = Resultado * Contador;
            }
            Console.WriteLine("El resultado con el ciclo for es: {0}", Resultado);
            DateTime FinalFor = DateTime.Now;
            TimeSpan DuracionFor = FinalFor - InicioFor;
            double SegundosTotalesFor = DuracionFor.TotalSeconds;
            Console.WriteLine("EL programa con el ciclo For tiene una duracion de {0} segundos\n", SegundosTotalesFor);
            DateTime InicioRecursividad = DateTime.Now; // Inicio de programa con Recursividad
            Console.WriteLine("El resultado con Recursividad es: {0}", Factorial(6));
            DateTime FinalRecursividad = DateTime.Now;
            TimeSpan DuracionRecursividad = FinalRecursividad - InicioRecursividad;
            double SegundosTotalesRecursividad= DuracionRecursividad.TotalSeconds;
            Console.WriteLine("El programa con Recursividad tiene una duracion de {0} segundos", SegundosTotalesRecursividad);
            Console.ReadKey();
        }
        public static int Factorial(int Numero)
        {
            if (Numero == 0)
            {
                return 1;
            }
            else
            {
                return Numero * Factorial(Numero - 1);
            }
        }
    }
}
