using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Examen_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantas palabras desea a ingresar: ");
            int TotalPalabras = int.Parse(Console.ReadLine());
            string[] GuardarPalabras = new string[TotalPalabras];
            for(int Contador = 0; Contador < GuardarPalabras.Length; Contador++)
            {
                Console.Write("Ingrese la palabra {0}: ", Contador + 1);
                GuardarPalabras[Contador] = Console.ReadLine();
            }
            for(int Contador = TotalPalabras - 1; Contador > -1; Contador--)
            {
                Console.Write("{0} ", GuardarPalabras[Contador]);
            }
            Console.ReadKey();
        }
    }
}
