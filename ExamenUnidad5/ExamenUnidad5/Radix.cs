using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad5
{
    class Radix
    {
        private int[] Ordena(int[] ArregloBase) // Copie mi codigo y lo pegue aqui
        {
            int[] ATemporal = new int[ArregloBase.Length]; // Este es nuestro arreglo auxiliar .
            int BitsEntero = 32; // Número de bits de un entero en c#.
            int BitsGrupo = 2;  // Tamaño en bits de nuestro grupo. Intenta también 2, 8 o 16 para ver si es rápido o no.         
            int[] ConteoArreglos = new int[1 << BitsGrupo];  // Inicia el conteo a asignación de los arreglos.
            int[] Valores = new int[1 << BitsGrupo];  // Dimensiones 2^r el cual es el número de todos los valores posibles de un número r-bit
            int Grupos = (int)Math.Ceiling((double)BitsEntero / (double)BitsGrupo);  // Número de grupos. 
            int Identificador = (1 << BitsGrupo) - 1; // Máscara para identificar los grupos.
            for (int c = 0, Apoyo = 0; c < Grupos; c++, Apoyo += BitsGrupo)   // Implementación del algoritmo 
            {
                for (int j = 0; j < ConteoArreglos.Length; j++) // Reiniciar el conteo en los arreglos.
                {
                    ConteoArreglos[j] = 0;
                }
                for (int i = 0; i < ArregloBase.Length; i++)  // Contar elementos del c-vo grupo.
                {
                    ConteoArreglos[(ArregloBase[i] >> Apoyo) & Identificador]++;
                    Valores[0] = 0; // Calculando prefijos.
                }
                for (int i = 1; i < ConteoArreglos.Length; i++)
                {
                    Valores[i] = Valores[i - 1] + ConteoArreglos[i - 1];
                }

                for (int i = 0; i < ArregloBase.Length; i++) // De a[] a t[] elementos ordenados por c-vo grupo .
                {
                    ATemporal[Valores[(ArregloBase[i] >> Apoyo) & Identificador]++] = ArregloBase[i];
                }
                ATemporal.CopyTo(ArregloBase, 0); // a[]=t[] e inicia otra vez hasta el último grupo.
            }
            return ArregloBase;
        }


        public void RadixSort(int[] Numeros)
        {
            int i, NumerosNegativos = 0, Tamaño = Numeros.Length, ContadorP = 0, Maximo;
            // Busca cuantos numeros son negativos en el arreglo
            for (i = 0; i < Tamaño; i++)
            {
                if (Numeros[i] < 0)
                    NumerosNegativos++;
            }

            // Si existen numeros negativos, crea un arreglo de negativos y otro de de positivos

            int[] ArregloPositivos = new int[Tamaño]; // Crea el arreglo
            for (i = 0; i < Tamaño; i++) // ciclo para guardar en arreglo temporal
            {
                ArregloPositivos[ContadorP] = Numeros[i];
                ContadorP++; // Cntador
            }
            Maximo = ArregloPositivos[0]; // se declara variable de maxiimo
            for (i = 1; i < ArregloPositivos.Length; i++) //For para ir ordenando del maximo al minimo
            {
                if (ArregloPositivos[i] > Maximo)
                    Maximo = ArregloPositivos[i];
            }
            Ordena(ArregloPositivos); //Manda llamar la funcion ORdena del radix
            Console.WriteLine("\nSus numeros ordenados por el metodo Radix son: \n"); // Imprime los elementos del arreglo
            int Contador = 1;
            for (i = 0; i < ArregloPositivos.Length; i++)
            {
                Console.Write("{0}.[" + ArregloPositivos[i] + "]   ", i + 1);
                if (Contador % 10 == 0)
                {
                    Console.WriteLine();
                }
                Contador++;
            }
        }
    }
}
