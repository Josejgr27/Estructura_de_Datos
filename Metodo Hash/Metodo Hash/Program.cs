using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones OBJ = new Operaciones(10); // Tamaño del arreglo en el constructor
            string[] elementos = { "10", "5", "81","14","73","34", "99", "12","11","3"};            // le enviamos los elementos al arreglo 
            OBJ.funcionHASH(elementos, elementos); // Lammamos el metodo hash
            OBJ.mostrar(); // Mostramos los elementos del arreglo
            string buscando = OBJ.BuscarClave("500"); //Buscamos el 500 en el metodo Buscar Clave
            if (buscando == null) // Si buscando no esxite
            {
                Console.WriteLine("El elemento " + buscando + " No se encuentra en la tabla"); // escribe esto
            }
            Console.ReadKey(); // Lee un caracter
        }
    }
}
