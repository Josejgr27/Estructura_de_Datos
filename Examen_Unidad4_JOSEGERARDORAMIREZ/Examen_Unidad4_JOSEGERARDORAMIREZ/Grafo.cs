using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4_JOSEGERARDORAMIREZ
{
    class Grafo
    {

        public int Vertices { get; set; } // Atributo vertice del grafo
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



        public void DFS(int Valor, int Dato) // Busca el camino al ultimo elemento
        {
            List<string> Ciudad = new List<string>();
            if(Dato==1||Dato==2)
            {
                Ciudad.Add("Boston");
                Ciudad.Add("Chicago");
                Ciudad.Add("Denver");
                Ciudad.Add("LA");
                Ciudad.Add("New York");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Miami");
                Ciudad.Add("Atlanta");
            }
            if(Dato==3)
            {
                Ciudad.Add("Atlanta");
                Ciudad.Add("Chicago");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Boston");
                Ciudad.Add("Denver");
                Ciudad.Add("LA");
                Ciudad.Add("New York");           
                Ciudad.Add("Miami");                
            }
            if (Dato == 4)
            {
                Ciudad.Add("Denver");
                Ciudad.Add("Chicago");
                Ciudad.Add("New York");
                Ciudad.Add("Atlanta");               
                Ciudad.Add("San Francisco");
                Ciudad.Add("Boston");                
                Ciudad.Add("LA");               
                Ciudad.Add("Miami");
            }

            bool[] Visita = new bool[Vertices]; // crea una arreglo boleano de tamaño atributo vertices
            Stack<int> Pila = new Stack<int>(); // crea una pila 
            Visita[Valor] = true; // el valor del arreglo con el parametro es igual a true
            Pila.Push(Valor); // agrega el valor parametro a la pila
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("La ruta es: ");     // EL camino al ultimo elemento es       
            while (Pila.Count != 0) // mientras la pila no este vacio
            {
                Valor = Pila.Pop(); // Valor se igual al ultmo elemento de la pila (lo saca)
                Console.Write("{0}-> ", Ciudad[Valor]); // agrega el valor                
                foreach (int item in Lista[Valor]) // por cada elemento entero en la lista de [Valor dado]
                {
                    if (!Visita[item]) // Si visita en la posicion item es diferente
                    {
                        Visita[item] = true; // esa posicion es igual a true
                        Pila.Push(item); // agrega el elemento item a la pila
                    }
                }
            }
            Console.Write("Fin de la ruta");
        }
    }
}
