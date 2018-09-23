using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Examen_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantas palabras va a ingresar: ");
            int PalabrasIngresar = int.Parse(Console.ReadLine());
            string[] Palabras = new string[PalabrasIngresar];
            int ValorMaximo = 0, LugarMayor = 0, Maximo = 0;
            Console.Write("ingrese el numero y presione enter: \n");
            for (int Operador = 0; Operador < Palabras.Length; Operador++)
            {
                Palabras[Operador] = Console.ReadLine();
            }
            ValorMaximo = Palabras[0].Length;
            for (Maximo = 0; Maximo < Palabras.Length; Maximo++)
            {
                if (ValorMaximo < Palabras[Maximo].Length)
                {                  
                    ValorMaximo = Palabras[Maximo].Length;
                    LugarMayor = Maximo;
                    Console.WriteLine(LugarMayor+1);
                    Console.ReadKey();
                    break;
                }
            }          
        }
    }
}
