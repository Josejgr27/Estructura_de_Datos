using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad5
{
    class Quick_Sort
    {
        int[] ArregloValores; // Se declara el Arreglo 
        List<char> Letras = new List<char>();
        List<int> Numeros = new List<int>();
        List<string> Letrillas = new List< string > ();
        public void AgregarDatos() //Agrega los datos dependiendo el ejercicio
        {
            string Texto= "lorem ipsum dolor sit amet consectetur adipscing elit fusce varios augue vitae tincidunt viverra sem felis bibendum nisl id cursus diam leo sit amet urna dius ac massa est";
            foreach (char item in Texto)
            {
                Letras.Add(item);
            }
            foreach (var item in Letras)
            {
                char Letra = item;
                if(Letra == 'a')
                {
                    Numeros.Add(1);
                }
                else if(Letra=='b')
                {
                    Numeros.Add(2);
                }
                else if (Letra == 'c')
                {
                    Numeros.Add(3);
                }
                else if (Letra == 'd')
                {
                    Numeros.Add(4);
                }
                else if (Letra == 'e')
                {
                    Numeros.Add(5);
                }
                else if (Letra == 'f')
                {
                    Numeros.Add(6);
                }
                else if (Letra == 'g')
                {
                    Numeros.Add(7);
                }
                else if (Letra == 'h')
                {
                    Numeros.Add(8);
                }
                else if (Letra == 'i')
                {
                    Numeros.Add(9);
                }
                else if (Letra == 'j')
                {
                    Numeros.Add(10);
                }
                else if (Letra == 'k')
                {
                    Numeros.Add(11);
                }
                else if (Letra == 'l')
                {
                    Numeros.Add(12);
                }
                else if (Letra == 'm')
                {
                    Numeros.Add(13);
                }
                else if (Letra == 'n')
                {
                    Numeros.Add(14);
                }
                else if (Letra == 'o')
                {
                    Numeros.Add(15);
                }
                else if (Letra == 'p')
                {
                    Numeros.Add(16);
                }
                else if (Letra == 'q')
                {
                    Numeros.Add(17);
                }
                else if (Letra == 'r')
                {
                    Numeros.Add(18);
                }
                else if (Letra == 's')
                {
                    Numeros.Add(19);
                }
                else if (Letra == 't')
                {
                    Numeros.Add(20);
                }
                else if (Letra == 'u')
                {
                    Numeros.Add(21);
                }
                else if (Letra == 'v')
                {
                    Numeros.Add(22);
                }
                else if (Letra == 'w')
                {
                    Numeros.Add(23);
                }
                else if (Letra == 'x')
                {
                    Numeros.Add(24);
                }
                else if (Letra == 'y')
                {
                    Numeros.Add(25);
                }
                else if (Letra == 'z')
                {
                    Numeros.Add(26);
                }
            }
            ArregloValores = new int [Numeros.Count];
            for (int i = 0; i < ArregloValores.Length; i++)
            {
                ArregloValores[i] = Numeros[i];
            }
            QuickSort(ArregloValores, 0, ArregloValores.Length-1);
            Imprimir(ArregloValores.Length);
            Console.WriteLine("\n\n\n");
            foreach (int item in ArregloValores)
            {
                int Letra = item;
                if (Letra == 1)
                {
                    Letrillas.Add("a");
                }
                else if (Letra == 2)
                {
                    Letrillas.Add("b");
                }
                else if (Letra == 3)
                {
                    Letrillas.Add("c");
                }
                else if (Letra == 4)
                {
                    Letrillas.Add("d");
                }
                else if (Letra == 5)
                {
                    Letrillas.Add("e");
                }
                else if (Letra == 6)
                {
                    Letrillas.Add("f");
                }
                else if (Letra == 7)
                {
                    Letrillas.Add("g");
                }
                else if (Letra == 8)
                {
                    Letrillas.Add("h");
                }
                else if (Letra == 9)
                {
                    Letrillas.Add("i");
                }
                else if (Letra == 10)
                {
                    Letrillas.Add("j");
                }
                else if (Letra == 11)
                {
                    Letrillas.Add("k");
                }
                else if (Letra == 12)
                {
                    Letrillas.Add("l");
                }
                else if (Letra == 13)
                {
                    Letrillas.Add("m");
                }
                else if (Letra == 14)
                {
                    Letrillas.Add("n");
                }
                else if (Letra == 15)
                {
                    Letrillas.Add("o");
                }
                else if (Letra == 16)
                {
                    Letrillas.Add("p");
                }
                else if (Letra == 17)
                {
                    Letrillas.Add("q");
                }
                else if (Letra == 18)
                {
                    Letrillas.Add("r");
                }
                else if (Letra == 19)
                {
                    Letrillas.Add("s");
                }
                else if (Letra == 20)
                {
                    Letrillas.Add("t");
                }
                else if (Letra == 21)
                {
                    Letrillas.Add("u");
                }
                else if (Letra == 22)
                {
                    Letrillas.Add("v");
                }
                else if (Letra == 23)
                {
                    Letrillas.Add("w");
                }
                else if (Letra == 24)
                {
                    Letrillas.Add("x");
                }
                else if (Letra == 25)
                {
                    Letrillas.Add("y");
                }
                else if (Letra == 26)
                {
                    Letrillas.Add("z");
                }
            }
            Console.WriteLine("El vector ordenado de letras es: ");
            foreach (var item in Letrillas)
            {
                Console.Write(" {0} ", item);
            }
        }

        private void QuickSort(int[] ArregloValores, double Inicio, double Union) // MEtodo Quick Sort para acomodar los elementos del arreglo 
        {
            int Indice, Mama, Papa; // Se declaran variables
            double Pivote; // Se declara la variable pivote tipo double
            Papa = Convert.ToInt32((Inicio + Union) / 2); // Papa se iguala a inicio + union sobre 2 convirtiendolos a entero
            Pivote = ArregloValores[Papa]; // pivote se igual al la posicion del arreglo en el valor Papa
            Indice = Convert.ToInt32(Inicio); // indice es igual al parametro inicio convirtiendolo a entero
            Mama = Convert.ToInt32(Union); // indice es igual al parametro union convirtiendolo a entero
            do // Ciclo do while
            {
                while (ArregloValores[Indice] < Pivote) Indice++; // dos condiciones
                while (ArregloValores[Mama] > Pivote) Mama--;

                if (Indice <= Mama) // Si indice es menor o igual a mama
                {

                    int Temporal = ArregloValores[Indice]; //declara variable y se igual al ArregloValores en la posicion Indice
                    ArregloValores[Indice] = ArregloValores[Mama]; // Se iguala la posicion del indice a la posicion en mama
                    ArregloValores[Mama] = Temporal; // La posicion de mama toma la variable Temporal
                    Indice++; // indice se le agrega 1
                    Mama--; // Mama se le resta 1

                }
            } while (Indice <= Mama); // Se hara esto mientras indice sea menor o igual a mama

            if (Inicio < Mama) // Si inicio es menor que mama
            {
                QuickSort(ArregloValores, Inicio, Mama); // Se manda llamar el metodo quick sort recursivamente
            }
            if (Indice < Union) // Si inicio es menor que union
            {
                QuickSort(ArregloValores, Indice, Union); // Se manda llamar el metodo quick sort recursivamente
            }
        }

        private void Imprimir(int TamañoArreglo) // Este metodo imprime el Vector con el parametro del tamaño del arreglo
        {
            Console.WriteLine("\n\nEl vector ordenado de numeros es: ");
            for (int i = 0; i < TamañoArreglo; i++) // Ciclo for para desde la variable contador i 0 hasta menor que el tamaño del arreglo 
            {
                Console.Write(ArregloValores[i] + "   "); // Los valores del vector ya acomodado separado por 3 espacios
            }
        }
    }
}
