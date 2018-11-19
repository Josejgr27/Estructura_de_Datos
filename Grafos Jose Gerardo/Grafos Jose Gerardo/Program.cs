using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_Jose_Gerardo
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafo Grafin = new Grafo(8); // Grafo de 8 letras
            Grafin.Agregar(1, 1); // agrega el 1
            Grafin.Agregar(3, 7); // agrega el 7
            Grafin.Agregar(1, 2); // agrega el 2
            Grafin.Agregar(2, 3); // agrega el 3
            Grafin.Agregar(6, 7); // agrega el 7
            Grafin.Agregar(4, 5); // agrega el 5
            Grafin.Agregar(2, 7); // agrega el 7
            Grafin.Agregar(3, 4); // agrega el 4
            Grafin.Agregar(5, 6); // agrega el 6
            Grafin.Agregar(4, 6); // agrega el 6                       
            Grafin.Dibujar(); // dibuja el grafo
            Grafin.DFS(1); // bisca la trayectoria al ultimo elemento
            Grafin.Trayectorias(); // pone las trayectorias simpels
            Console.ReadKey(true);
        }
    }
}
