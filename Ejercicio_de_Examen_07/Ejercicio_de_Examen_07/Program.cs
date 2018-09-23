using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Examen_07
{
    class Program
    {
        static void Main(string[] args)
        {
        Random Random = new Random();
        int [] GuardaNumeros  = new int [100];
        for (int Contador=0; Contador < 100; Contador++)
            {
                GuardaNumeros[Contador] = Convert.ToInt16(Random.Next(1, 101));
            }

            for (int Contador = 0; Contador < 100; Contador++)
            {
                Console.WriteLine("{0}. {1}", Contador + 1, GuardaNumeros[Contador]);
            }

            Array.Sort(GuardaNumeros);

            for (int Contador = 0; Contador < 100; Contador++)
            {
                Console.SetCursorPosition(15, Contador);
                Console.WriteLine("{0}. {1}", Contador + 1, GuardaNumeros[Contador]);
            }
            Console.ReadKey();      
        }
    }
}
