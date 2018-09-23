using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Examen_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] GuardarValores = new int[3];
            for (int Contador = 0; Contador < GuardarValores.Length; Contador++)
            {
                Console.WriteLine("Introduzca el valor {0}", Contador + 1);
                GuardarValores[Contador] = int.Parse(Console.ReadLine());
            }
            Array.Sort(GuardarValores);
            Console.WriteLine("El numero menor es {0}", GuardarValores[0]);
            Console.ReadKey();
        }
    }
}

