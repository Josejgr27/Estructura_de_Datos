using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
        Fak: // Etiqueta para volver aqui
            Console.Clear(); // Borra pantalla
            Console.WriteLine("Seleccione el ejercicio\n1. Ejercicio 1\n2. Ejercicio 2\n3. Ejercicio 3\n4. Ejercicio 4\n5. Salir"); // Menu
            int Parametro = int.Parse(Console.ReadLine()); // Variable entera
            if(Parametro==1) // SI parametro es igual a 1
            {
                Desarrollo Objeto = new Desarrollo(); // Se crea el objeto
                Objeto.AgregarDatos(11,1); // Se manda llamar el metodo agregar datos, con el segundo parametro de 1 para el arreglo 1
                Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                goto Fak; // Regresa a fak
            }
            if (Parametro == 2) // SI parametro es igual a 2
            {
                Desarrollo Objeto = new Desarrollo(); // Se crea el objeto
                Objeto.AgregarDatos(12,2); // Se manda llamar el metodo agregar datos, con el segundo parametro de 2 para el arreglo 2
                Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                Console.ReadKey();// Lee caracter
                goto Fak; // Regresa a fak
            }
            if (Parametro == 3) // SI parametro es igual a 3
            {
                Desarrollo Objeto = new Desarrollo(); // Se crea el objeto
                Objeto.AgregarDatos(12,3); // Se manda llamar el metodo agregar datos, con el segundo parametro de de 3 para el arreglo 3
                Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                Console.ReadKey();// Lee caracter
                goto Fak; // Regresa a fak
            }
            if (Parametro == 4) // SI parametro es igual a 4
            {
                Desarrollo Objeto = new Desarrollo(); // Se crea el objeto
                Objeto.AgregarDatos(10,4); // Se manda llamar el metodo agregar datos, con el segundo parametro de 4 para el arreglo 4
                Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                Console.ReadKey();// Lee caracter
                goto Fak; // Regresa a fak
            }
            if (Parametro == 5)
            {
                Console.Clear(); // Borra pantalla
                Console.WriteLine("ADIOS");
                Console.ReadKey(); // Lee caracter
            }
        }
    }
}
//FIN DEL PROGRAMA