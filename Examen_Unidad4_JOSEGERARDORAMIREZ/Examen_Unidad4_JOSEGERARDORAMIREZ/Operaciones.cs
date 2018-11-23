using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4_JOSEGERARDORAMIREZ
{
    class Operaciones
    {


        public void Arbol1()
        {








        }




            public void Grafo()
        {
        Seleccion:
            Console.Clear();
            Console.WriteLine("Seleccione la Ruta que desea mirar:\n1) Boston->LA\n2)NewYork->San Francisco\n3)Atlanta->San Francisco\n4)Denver->NewYork\n5)Salir");
            int Dato = int.Parse(Console.ReadLine());
            if (Dato == 1)
            {
                Grafo Grafin = new Grafo(5);
                Grafin.Agregar(0, 1);
                Grafin.Agregar(1, 2);
                Grafin.Agregar(2, 3);
                Grafin.DFS(0, 1);
                Console.WriteLine("\n\nPresione para continuar...");
                Console.ReadKey();
                goto Seleccion;
            }

            if (Dato == 2)
            {
                Grafo Grafin = new Grafo(7);
                Grafin.Agregar(0, 1);
                Grafin.Agregar(1, 2);
                Grafin.Agregar(2, 3);
                Grafin.Agregar(4, 5);
                Grafin.DFS(4, 2);
                Console.WriteLine("\n\nPresione para continuar...");
                Console.ReadKey();
                goto Seleccion;
            }

            if (Dato == 3)
            {
                Grafo Grafin = new Grafo(4);
                Grafin.Agregar(0, 1);
                Grafin.Agregar(1, 2);
                Grafin.DFS(0, 3);
                Console.WriteLine("\n\nPresione para continuar...");
                Console.ReadKey();
                goto Seleccion;
            }

            if (Dato == 4)
            {
                Grafo Grafin = new Grafo(4);
                Grafin.Agregar(0, 1);
                Grafin.Agregar(1, 2);
                Grafin.DFS(0, 4);
                Console.WriteLine("\n\nPresione para continuar...");
                Console.ReadKey();
                goto Seleccion;
            }
            if (Dato == 5)
            {
                Console.Clear();
                Console.WriteLine("ADIOS");
                Console.ReadKey();
            }
        }




    }
}
