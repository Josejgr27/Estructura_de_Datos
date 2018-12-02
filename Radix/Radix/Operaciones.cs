using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix
{
    class Operaciones
    {

        public void Menu()
        {
        Menu:
            Console.Clear();
            Console.WriteLine("Bienvenido al metodo Radix\n\nIntroduzca numero del arreglo que desea ordenar\n1) 3, 6, 9, 5, 1, 4, 7, 2, 1, 3\n2) 8, 3, 9, 3, 11, 7, 1, 27, 12\n3) 10, 40, 36, 5, 24, 2, 5, 8\n4) 55, 42, 0, -3, 0, -1, 2, 4, 7\n5) 25, 108, 1024, 12, 351, 251, 39\n6)Salir");
            string Ejercicio = Console.ReadLine();
            if (Ejercicio == "1")
            {
                int[] Numeros = { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3};
                RadixSort(Numeros);
                Console.WriteLine("\n\nPresione cualquier tecla para volver al menu...");
                Console.ReadKey();
                goto Menu;
            }

            else if (Ejercicio == "2")
            {
                int[] Numeros = { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
                RadixSort(Numeros);
                Console.WriteLine("\n\nPresione cualquier tecla para volver al menu...");
                Console.ReadKey();
                goto Menu;
            }

            else if (Ejercicio == "3")
            {
                int[] Numeros = { 10, 40, 36, 5, 24, 2, 5, 8 };
                RadixSort(Numeros);
                Console.WriteLine("\n\nPresione cualquier tecla para volver al menu...");
                Console.ReadKey();
                goto Menu;
            }

            else if (Ejercicio == "4")
            {
                int[] Numeros = { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
                RadixSort(Numeros);
                Console.WriteLine("\n\nPresione cualquier tecla para volver al menu...");
                Console.ReadKey();
                goto Menu;
            }

            else if (Ejercicio == "5")
            {
                int[] Numeros = { 25, 108, 1024, 12, 351, 251, 39 };
                RadixSort(Numeros);
                Console.WriteLine("\n\nPresione cualquier tecla para volver al menu...");
                Console.ReadKey();
                goto Menu;
            }

            else if (Ejercicio == "6")
            {
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Introduzca un numero de ejercicio valido\nPresione cualquier tecla para volver al menu...");
                Console.ReadKey();
                goto Menu;
            }
        }








        public void RadixSort(int[] Numeros)
        {
            int i, NumerosNegativos = 0, Tamaño = Numeros.Length, ContadorN = 0, ContadorP = 0, Maximo, Minimo;
            // Busca cuantos numeros son negativos en el arreglo
            for (i = 0; i < Tamaño; i++)
            {
                if (Numeros[i] < 0)
                    NumerosNegativos++;
            }

            // Si existen numeros negativos, crea un arreglo de negativos y otro de de positivos
            if (NumerosNegativos != 0)
            {
                int[] ArregloPositivos = new int[(Tamaño - NumerosNegativos)];
                int[] ArregloNegativos = new int[NumerosNegativos];
                for (i = 0; i < Tamaño; i++)
                {
                    if (Numeros[i] < 0)
                    {
                        ArregloNegativos[ContadorN] = Numeros[i];
                        ContadorN++;
                    }
                    else
                    {
                        ArregloPositivos[ContadorP] = Numeros[i];
                        ContadorP++;
                    }

                }

                // Busca valores maximo y minimo
                Minimo = ArregloNegativos[0];
                Maximo = ArregloPositivos[0];


                // Convierte los valores negativos a positivos (temporalmente)
                ArregloNegativos[0] *= -1;
                for (i = 1; i < ArregloNegativos.Length; i++)
                {
                    ArregloNegativos[i] *= -1;
                    if (ArregloNegativos[i] > Minimo)
                        Minimo = ArregloNegativos[i];
                }
                for (i = 1; i < ArregloPositivos.Length; i++)
                {
                    if (ArregloPositivos[i] > Maximo)
                        Maximo = ArregloPositivos[i];
                }
                // Llama metodo sort 
                Ordena(ArregloNegativos);
                Ordena(ArregloPositivos);
                // Convierte los valores de los numeros negativos ordenados desciendietemente a negativos
                for (i = 0; i < ArregloNegativos.Length; i++)
                    ArregloNegativos[i] *= -1;
                Console.WriteLine("Sus numeros ordenados por el metodo Radix son: \n");
                for (i = ArregloNegativos.Length - 1; i >= 0; i--)
                    Console.Write("[" + ArregloNegativos[i] + "]    ");
                for (i = 0; i < ArregloPositivos.Length; i++)
                    Console.Write("[" + ArregloPositivos[i] + "]    ");
            }
            else // Si el arreglo no contiene negativos entonces 
            {
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
                for (i = 0; i < ArregloPositivos.Length; i++)
                    Console.Write("[" + ArregloPositivos[i] + "]    ");
            }
        }


        private int[] Ordena(int[] ArregloBase)
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
        }
    }

