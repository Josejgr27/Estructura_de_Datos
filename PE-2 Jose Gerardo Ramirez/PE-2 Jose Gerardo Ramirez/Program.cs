using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2_Jose_Gerardo_Ramirez
{
    class Program
    {
        static void Main(string[] args)
        {
            Sucesion Sucesion1 = new Sucesion();
            Console.Write("Introduzca la cantidad de datos de la sucesion: ");
            int TamañoArreglo = int.Parse(Console.ReadLine());
            int[] Sucesion = new int[TamañoArreglo];
            Sucesion1.GuardarDatos(Sucesion, TamañoArreglo);
        inicio:
            Console.WriteLine();
            Console.WriteLine("Seleccione el numero de lo que desea hacer");
            Console.WriteLine("1. Encontrar el minimo del arreglo");
            Console.WriteLine("2.Encontrar el maximo del arreglo");
            Console.WriteLine("3. invertir el arreglo");
            Console.WriteLine("4. Salir");
            int Menu=int.Parse(Console.ReadLine());
            if(Menu==1)
            {
               
                Console.WriteLine("El minimo del arreglo es: {0}", Sucesion1.EncontrarElMinimo(Sucesion, 0, Sucesion[0]));
                goto inicio;
            }
           else if(Menu==2)
            {               
                Console.WriteLine("El maximo del arreglo es: {0}", Sucesion1.EncontrarElMaximo(Sucesion, 0, Sucesion[0]));
                goto inicio;
            }
               
            else if(Menu==3)
            {
                 Sucesion1.InvertirNumero(Sucesion, TamañoArreglo);
                goto inicio;
            }
            else if (Menu == 4)
            {
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Introduzca solo 1, 2 o 3 dependiendo su eleccion");
                goto inicio;
            }           
            Console.ReadKey();                        
        }
    }
}
