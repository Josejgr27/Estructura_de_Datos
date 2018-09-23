using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Examen_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos numeros va a ingresar: ");
            int NumerosIngresar = int.Parse(Console.ReadLine());
            int [] Numeros = new int[NumerosIngresar];
            int ValorMaximo = 0,LugarMayor = 0, Maximo = 0;
            Console.Write("ingrese el numero y presione enter: \n");
            for (int Operador = 0; Operador < Numeros.Length; Operador++)
            {     
                Numeros[Operador] = Convert.ToInt32(Console.ReadLine());
            }
            for (Maximo = 0; Maximo < Numeros.Length; Maximo++)
            {
                if (Numeros[Maximo] > ValorMaximo || ValorMaximo== Numeros[Maximo])
                {
                    ValorMaximo = Numeros[Maximo];
                    LugarMayor = Maximo;
                }
            }
            Console.Write("\n\nEl numero mayor es de el lugar: " + (LugarMayor + 1));
            Console.ReadKey();
        }
    }
}
