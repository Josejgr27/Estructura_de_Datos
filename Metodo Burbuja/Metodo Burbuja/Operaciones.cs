using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Burbuja
{
    class Operaciones
    {
        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido al Metodo Burbuja\nPresione cualquier tecla para continuar..."); // Se introduce una bienvenida
            Console.ReadKey(); // Lee un caracter
            Console.Clear(); // Borra la pantalla
        }

        public void Menu()
        {
            Bienvenida();
            Console.WriteLine("Introduzca la cantidad de datos a ingresar: ");
            int Datos = int.Parse(Console.ReadLine()); // Guarda lo que ingresa el usuario en la variable declarada Datos
            int[] Numeros = new int[Datos]; // Se crea el arreglo de tamaño que guardamos en la variable Datos
            for (int i = 0; i < Numeros.Length; i++) // ciclo para agregar numeros al arreglo desde 0 hasta el tamaño del arreglo
            {
                Console.WriteLine("Introduzca el numero {0}", i+1); 
                Numeros[i] = int.Parse(Console.ReadLine()); // Guarda el valor en la variable contador (i)
            }
            Console.Clear(); // Borra pantalla
            Console.WriteLine("Sus numeros sin ordenar son: "); 
            for (int i = 0; i < Numeros.Length; i++) // Imprime los elementos del arreglo
            {
                Console.Write(Numeros[i] + "   "); // separados por un espacio
            }
            Console.WriteLine("\n\nPresione cualquier tecla para ordenar sus datos...");
            Console.ReadKey(); // Lee un caracter
            int Auxiliar=0; // se declara la variable auxiliar CASO BASE PARA METODO BURBUJA
            for (int i = 0; i <= Numeros.Length; i++) // se crea un for desde 0 hasta el tamaño del arreglo para que haga eso con todos los elementos del arreglo
            {
                for (int j = 0; j < Numeros.Length - 1; j++) // un for anidados para ir comparandolos
                {
                    if (Numeros[j] > Numeros[j + 1]) // si numeros en la posicion del contador j es mayor a la posicion j+1 es decir la de enfrente 
                    {
                        Auxiliar = Numeros[j]; // la variable auxiiliar toma el valor de la posicion del contador j en el arreglo numeros
                        Numeros[j] = Numeros[j + 1]; // numeros en la posicion j toma el valor de la siguiente posicion en el arreglo
                        Numeros[j + 1] = Auxiliar; // y la sigueinte posicion toma el valor de la variable auxiliar
                    }
                }
            }          
            Console.WriteLine("\nLos numeros ordenados son: ");
            for (int i = 0; i < Numeros.Length; i++) // imprime los elementos del arreglo ya ordenados
            {
                Console.Write(Numeros[i]+"   "); // separados por espacios
            }
            Console.ReadKey(); // fin del programa
        }
    }
}
