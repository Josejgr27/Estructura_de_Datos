using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaArboles
{
    class Nodo
    {
        public string Name; // Atributo de nombre
        public Nodo[] Arreglo; // Arreglo de nod
        public Nodo(string Nombre)//Un constructor donde se le tenga que introducir el nombre del nodo a crear
        {
            Name = Nombre;
        }
    }
}
