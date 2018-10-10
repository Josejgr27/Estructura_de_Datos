using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.C.Jose_Gerardo_Ramirez
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack PilaDeDeportes = new Stack(); // Creacion de la pila
            PilaDeDeportes.Push("Beisbol"); // El metodo push ingresa un valor en la pila
            PilaDeDeportes.Push("Futbol");
            PilaDeDeportes.Push("Ajedrez");
            foreach (var Deporte in PilaDeDeportes) // Cree un foreach para imprimir cada deporte en la pila de deportes
            {
                Console.WriteLine(Deporte); // imprime los deportes
            }
            Console.ReadKey();
            Console.Write("El Deporte Beisbol esta en la pila?: {0}", PilaDeDeportes.Contains("Beisbol")); // Ejemplo de contains para regresar un valor True si Beisbol se encuentra en la pila
            Console.ReadKey(); //El Deporte Beisbol esta en la pila?: True
            object Referencia = 0;
            Console.WriteLine("Los elementos de la pila son de tipo:");
            for(int Contador =0; Contador<=PilaDeDeportes.Count+1; Contador++) // Cree un foreach para imprimir cada deporte en la pila de deportes y compararlo conn su tipo de dato
            {
                Referencia = (object)PilaDeDeportes.Pop();
                Console.WriteLine(Referencia+ "=" + Referencia.GetType()); // imprime los deportes y su tipo de dato
            }
            Console.ReadKey();
            Stack PilaDeNumeros = new Stack(); // Creacion de una nueva pila donde guardar los datos
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa el texto numero " + (i + 1).ToString()); // .ToString convierte a cadena de texto lo alamacenado en la pila
                PilaDeNumeros.Push(Console.ReadLine()); // Lee el vector y lo almacena en la pila con el punto push
            }
            foreach (var String  in PilaDeNumeros) // Cree un foreach para imprimir cada string en la pila de Numeros
            {
                Console.WriteLine(String); // imprime los deportes
            }
            Console.ReadKey();

            Stack PilaDeNombres = new Stack(); // Creacion de una nueva pila
            PilaDeNombres.Push("Jose"); // El metodo push ingresa un valor en la pila
            PilaDeNombres.Push("Marco");
            PilaDeNombres.Push("Antonio");
            Console.WriteLine("Contenido de la pila: ");
            IEnumerator miEnum = PilaDeDeportes.GetEnumerator();//Creacion de obj que enumera la pila GetEnumerator
            foreach (var String in PilaDeNombres)
            { 
                Console.WriteLine(String + " = " + miEnum); // Imprime los elementos de la pila sin enumero y los iguala con las enumeradas
            }
            Console.ReadKey();




            Stack<string> Numeros = new Stack<string>(); // Creacion de la nueva pila llamada numbers
            Numeros.Push("Uno");
            Numeros.Push("Dos");
            Numeros.Push("Trees");
            Numeros.Push("Cuatro");
            Numeros.Push("Cinco");

            foreach (string Numero in Numeros)//Distribucion de contenido
            {
                Console.WriteLine(Numero);
            }
            Console.WriteLine("\nSalto  '{0}'", Numeros.Pop()); // Creando la pila, usando ToArray 
            Console.WriteLine("Siguiente en salir : {0}",
            Numeros.Peek());
            Console.WriteLine("Salto '{0}'", Numeros.Pop());
            Stack<string> stack2 = new Stack<string>(Numeros.ToArray());
            Console.WriteLine("\nlos primeros contenidos :");
            foreach (string number in stack2)
            {
                Console.WriteLine(number);
            }           
            string[] array2 = new string[Numeros.Count * 2]; // Se crea el arreglo
            Numeros.CopyTo(array2, Numeros.Count);
            Stack<string> stack3 = new Stack<string>(array2); // Esto crea la segunda pila, usando el  constructor 
            Console.WriteLine("\nsegundo contenido:");
            foreach (string Numero in stack3)
            {
                Console.WriteLine(Numero);
            }
            Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
            stack2.Contains("four"));
            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
            Console.ReadKey();
        }
    }
}
