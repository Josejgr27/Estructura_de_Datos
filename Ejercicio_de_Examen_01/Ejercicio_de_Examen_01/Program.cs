using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Examen_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos datos desea ingresar: ");
            int NumeroDatos = int.Parse(Console.ReadLine());
            int[] GuardarDatos = new int[NumeroDatos];
            for (int Contador = 0; Contador < GuardarDatos.Length; Contador++)
            {
                Console.Write("Ingrese el valor numero {0}: ", Contador + 1);
                GuardarDatos[Contador] = int.Parse(Console.ReadLine());
            }
            Array.Sort(GuardarDatos);
            Console.Write("El numero mayor ingresado fue: {0}\nEl numero menor ingresado fue: {1}", GuardarDatos[0], GuardarDatos[NumeroDatos - 1]);
            Console.ReadKey();
        }
    }
}
