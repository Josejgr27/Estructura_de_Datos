using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_Jose_Gerardo
{
    class Grafo
    {
        public  int Vertices { get; set; } // Atributo vertice del grafo
        List<int>[] Lista; // Lista entera  se crea
        public Grafo(int Valor) // Constructor
        {
            Vertices = Valor; // Vertice se igual al valor agregado 
            Lista = new List<int>[Valor]; // se agrega el valor del parametro
            for (int i = 0; i < Valor; i++) // un ciclo for para estar creando una lista
            {
                Lista[i] = new List<int>();
            }
        }

        public void Agregar(int Indice, int Valor) // Para agregar un valor a  la lista
        {
            Lista[Indice].Add(Valor); // agrega el valor que le des a la lista del indice
        }
        public void Trayectorias() // Imprime las trayectorias, no pude hacer metodo
        {
            Console.SetCursorPosition(0,10);
            Console.WriteLine("Las trayectorias simples son: ");
            Console.WriteLine("A -> B -> C -> D -> E");
            Console.WriteLine("A -> A -> B -> C -> D -> E");
            Console.WriteLine("A -> A -> B -> G -> F -> E");
            Console.WriteLine("A -> B -> C -> G -> F -> D -> E");
        }
        public void Dibujar() // dibuja el grafo
        {
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("|");
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("|");
            Console.SetCursorPosition(1, 0);
            Console.WriteLine("_");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("|");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("|");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("1 a--");
            Console.SetCursorPosition(7, 2);
            Console.WriteLine("/");
            Console.SetCursorPosition(8, 1);
            Console.WriteLine("/");
            Console.SetCursorPosition(16, 5);
            Console.WriteLine("/");
            Console.SetCursorPosition(17, 4);
            Console.WriteLine("/");
            Console.SetCursorPosition(7, 4);
            Console.WriteLine("\\");
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("\\");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("2b");
            Console.SetCursorPosition(9, 0);
            Console.WriteLine("3c---");
            Console.SetCursorPosition(9, 6);
            Console.WriteLine("7g---");
            Console.SetCursorPosition(14, 6);
            Console.WriteLine("6f");
            Console.SetCursorPosition(18, 3);
            Console.WriteLine("5e");
            Console.SetCursorPosition(14, 0);
            Console.WriteLine("4d\n");
            Console.SetCursorPosition(16, 1);
            Console.WriteLine("\\");
            Console.SetCursorPosition(17, 2);
            Console.WriteLine("\\");
        }



        public void DFS(int Valor) // Busca el camino al ultimo elemento
        {
            bool[] Visita = new bool[Vertices]; // crea una arreglo boleano de tamaño atributo vertices
            Stack<int> Pila = new Stack<int>(); // crea una pila 
            Visita[Valor] = true; // el valor del arreglo con el parametro es igual a true
            Pila.Push(Valor); // agrega el valor parametro a la pila
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("El camino para llegar al ultimo elmento es: ");     // EL camino al ultimo elemento es       
            Console.Write("1"); // agrega un 1 porque no se como hacer que lo marque dos vecees
            while(Pila.Count!=0) // mientras la pila no este vacio
            {
                Valor = Pila.Pop(); // Valor se igual al ultmo elemento de la pila (lo saca)
                Console.Write("-> {0}", Valor); // agrega el valor
                foreach (int item in Lista[Valor]) // por cada elemento entero en la lista de [Valor dado]
                {
                    if(!Visita[item]) // Si visita en la posicion item es diferente
                    {
                        Visita[item] = true; // esa posicion es igual a true
                        Pila.Push(item); // agrega el elemento item a la pila
                    }
                }
            }
        }
    }
}

