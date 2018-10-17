using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_2_Jose_Gerardo_Ramirez
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Cola = new Queue(); // Se crea la cola con el el nombre cola
            for (int i = 0; i < 5; i++) // Se utiliza un for para llenar la Cola de cualquier tipo de dato
            {
                Console.Write("Introduzca un valor a la cola: ");
                var Elemento = Console.ReadLine(); // Se lee el valor y se guarda en la variable de tipo Var llamada elemento
                Cola.Enqueue(Elemento); // PAra asi mandar llamar la funcion Enqueue que guarda las variables del elemento que le den.
            }

            Cola.Dequeue(); // Elimina el primer elemento de la cola
            foreach(var Elemento in Cola) // Foreach para imprimir los elementos de la cola
            {
                Console.WriteLine(Elemento);
            }

            Cola.TrimToSize(); // Establece la capacidad en el numero real de elementos que hay en la cola
            Console.ReadKey();
        }
    }
}
