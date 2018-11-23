using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4_JOSEGERARDORAMIREZ
{
    class Program
    {
        static void Main()
        {
            Operaciones BlackOps = new Operaciones();
            Console.WriteLine("Seleccione el programa que desea ver: \n1. Grafos\n2. Arboles");
            int Variable = int.Parse(Console.ReadLine());
            if (Variable == 1)
            {
                BlackOps.Grafo();
            }


            if (Variable == 2)
            {
                Arbolbinarioordenado arbol = new Arbolbinarioordenado();//se instancia el objeto de la clase Arbolbinarioordenado
                arbol.Menu();
                Console.ReadKey();
            }



        }
        public class Arbolbinarioordenado //se crea una clase de tipo publica llamada Arbolbinarioordenado
        {
            public void Imprimiendo()
            {
                Arbol Placata = new Arbol(); // crea un objeto arbol de BinaryTree

                Placata.Titular = new Nodo("A");
                Placata.Titular.Izquierda = new Nodo("B");
                Placata.Titular.Medio = new Nodo("C");
                Placata.Titular.Derecha = new Nodo("D");
                Placata.Titular.Izquierda.Izquierda = new Nodo("E");
                Placata.Titular.Izquierda.Medio = new Nodo("F");
                Placata.Titular.Izquierda.Derecha = new Nodo("G");
                Placata.Titular.Derecha.Izquierda = new Nodo("H");
                Placata.Titular.Derecha.Medio = new Nodo("I");
                Placata.Titular.Derecha.Derecha = new Nodo("J");
                Placata.Titular.Izquierda.Izquierda.Izquierda = new Nodo("K");
                Placata.Titular.Izquierda.Izquierda.Medio = new Nodo("L");
                Placata.Titular.Izquierda.Izquierda.Derecha = new Nodo("M");
                Placata.Titular.Izquierda.Derecha.Medio = new Nodo("N");
                Placata.Titular.Derecha.Izquierda.Medio = new Nodo("O");
                Placata.Titular.Derecha.Derecha.Izquierda = new Nodo("P");
                Placata.Titular.Derecha.Derecha.Derecha = new Nodo("Q");
                Placata.Titular.Izquierda.Derecha.Medio.Izquierda = new Nodo("R");
                Placata.Titular.Izquierda.Derecha.Medio.Derecha = new Nodo("S");

                Console.WriteLine("Arbol A");
                Console.WriteLine("Recorrido pre orden del arbol es: ");
                Placata.PrintPreorder();
                Console.WriteLine();
                Console.WriteLine("\nRecorrido post orden del arbol es: ");
                Placata.PrintPostorder();
                Console.WriteLine();
                Console.ReadKey();
            }
            public void Imprime()
            {
                Arbol ArbolesDeLaBarrranca = new Arbol(); // crea un objeto arbol de BinaryTree

                ArbolesDeLaBarrranca.Titular = new Nodo("A");
                ArbolesDeLaBarrranca.Titular.Izquierda = new Nodo("B");
                ArbolesDeLaBarrranca.Titular.Derecha = new Nodo("E");
                ArbolesDeLaBarrranca.Titular.Izquierda.Izquierda = new Nodo("C");
                ArbolesDeLaBarrranca.Titular.Izquierda.Derecha = new Nodo("D");
                ArbolesDeLaBarrranca.Titular.Derecha.Derecha = new Nodo("F");
                ArbolesDeLaBarrranca.Titular.Derecha.Derecha.Izquierda = new Nodo("G");
                ArbolesDeLaBarrranca.Titular.Derecha.Derecha.Derecha = new Nodo("H");

                Console.WriteLine("Arbol B");
                Console.WriteLine("Recorrido preorden del arbol es: ");
                ArbolesDeLaBarrranca.PrintPreorder();
                Console.WriteLine();
                Console.WriteLine("\nRecorrido posorden del arbol es: ");
                ArbolesDeLaBarrranca.PrintPostorder();
                Console.WriteLine();
                Console.ReadKey();
            }
            public class Nodo
            {
                public string x;
                public Nodo Izquierda, Derecha, Medio;

                public Nodo(string y)
                {
                    x = y;
                    Izquierda = Derecha = Medio = null;
                }
            }
            public class Arbol
            {
                public Nodo Titular;
                public Arbol()
                {
                    Titular = null;
                }
                public void PostOrden(Nodo nude)
                {
                    if (nude == null)
                        return;
                    PostOrden(nude.Izquierda);
                    PostOrden(nude.Medio);
                    PostOrden(nude.Derecha);
                    Console.Write(nude.x + " ");
                }
                public void PreOrden(Nodo nodin)
                {
                    if (nodin == null)
                        return;
                    Console.Write(nodin.x + " ");
                    PreOrden(nodin.Izquierda);
                    PreOrden(nodin.Medio);
                    PreOrden(nodin.Derecha);
                }
                public void PrintPostorder() { PostOrden(Titular); }
                public void PrintPreorder() { PreOrden(Titular); }
            }
            public void Menu()
            {
                int Menu = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Seleccione la opcion\n1.Imprimir Arboles\n2.Salir");                       
                    Menu = Convert.ToInt16(Console.ReadLine());
                    switch (Menu)
                    {
                        case 1:
                            Console.Clear();
                            Imprimiendo();
                            Imprime();
                            Console.ReadKey();
                            break; 
                        case 2:
                            Console.WriteLine("Presione cualquier tecla para salir...");
                            Console.ReadKey();
                            break;                            
                    }
                } while (Menu != 3);
            }
        }
    }
}