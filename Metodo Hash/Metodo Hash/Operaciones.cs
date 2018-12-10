using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Hash
{
    class Operaciones
    {
        string[] arreglo; // Se declara arreglo y variable tamaño
        int tamaño;
        public Operaciones (int tam)         // CONSTRUCTOR 
        {
            tamaño = tam;
            arreglo = new string[tam];
        }

        public void funcionHASH(string[] cadenaArreglo, string[] arreglo) // Funcion Hash el caso base
        {
            int i;
            for (i = 0; i < cadenaArreglo.Length; i++)
            {
                string elemento = cadenaArreglo[i];
                int indiceArreglo = int.Parse(elemento) % 7;
                Console.WriteLine("El indice es " + indiceArreglo + " para el Elemento " +
                        elemento);
                // Se Tratan las coliciones
                while (arreglo[indiceArreglo] == "-1")
                {
                    indiceArreglo++;
                    Console.WriteLine("Ocurrio una colision en el indice " +
                            (indiceArreglo - 1) +
                            "Cambiar al Indice " + indiceArreglo);
                    indiceArreglo %= tamaño;
                }
                arreglo[indiceArreglo] = elemento;
            }
        }
        public void mostrar()        // Metodo donde se muestra el vector
        {
            int i = 0;
            foreach (var item in arreglo)
            {
                Console.WriteLine(arreglo[i]+"   ");
                i++;
            }
        }
            public string BuscarClave(string elemento) // Busca si el elemento se encuentra en el arreglo, si este existe no regresa nada, si noe xiste regresa un valor null
            {
                int indiceArreglo = int.Parse(elemento) % 7;
                int contador = 0;
                while (arreglo[indiceArreglo] != "-1")
                {
                    if (arreglo[indiceArreglo] == elemento)
                    {
                        Console.WriteLine("El elemento" + elemento + "Fue encontrado en el indice" + indiceArreglo);
                        return arreglo[indiceArreglo];
                    }
                    indiceArreglo++;
                    indiceArreglo %= tamaño;
                    contador++;
                    if (contador > 7)
                    {
                        break;
                    }
                }
                return null; // REgresa null
        }
    }
}
