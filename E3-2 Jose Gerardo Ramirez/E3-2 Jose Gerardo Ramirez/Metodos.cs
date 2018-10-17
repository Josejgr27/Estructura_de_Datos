using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_2_Jose_Gerardo_Ramirez
{
    class Metodos
    {
        private Queue pcola; // Se declara la cola
        public void Cola()
        { 
            pcola = new Queue(); // Se inicializa la cola
        }

        public void EnQueue(object item) // Añade un objeto a de cualquier tipo a la lista
        {
            pcola.Enqueue(item); // el objeto puede ser cualquier tipo de dato.
        }

        public void DeQueue()
        {// Elimina el valor de la posicion 0 del arraylist
            pcola.Dequeue();
        }
    }
}
