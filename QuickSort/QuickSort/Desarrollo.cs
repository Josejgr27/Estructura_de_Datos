using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Desarrollo
    {
        double[] ArregloValores; // Se declara el Arreglo
        public void AgregarDatos(double Parametro, int Lista) //Agrega los datos dependiendo el ejercicio
        {   
            if(Lista==1) // Si lista es igual a 1
            {
                ArregloValores = new double[] { 11, 2, 3, 14, 18, 4, 5, -3, -1, 6, 9 }; // Arregla los valores del ejercicio 1 al arreglo
                goto Next; // Regresa a la etiqueta Next
            }

            if (Lista == 2) // Si lista es igual a 2
            {
                ArregloValores = new double[] { 1, 3, 5, 7, 8, 3, 9, .7071, 16.5664, 12, 0, 10 };  // Arregla los valores del ejercicio 2 al arreglo
                goto Next; // Regresa a la etiqueta Next
            }

            if (Lista == 3) // Si lista es igual a 3
            {
                ArregloValores = new double[] { 3, 7, 15, 1.3333, 155, 100, 15, 1.73, 20, 5, -5, 3, 2 };  // Arregla los valores del ejercicio 3 al arreglo
                goto Next; // Regresa a la etiqueta Next
            }

            if (Lista == 4) // Si lista es igual a 4
            {
                ArregloValores = new double[] { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };  // Arregla los valores del ejercicio 4 al arreglo
                goto Next; // Regresa a la etiqueta Next
            }
            Next: // Etiqueta Next
            QuickSort(ArregloValores, 0, Parametro - 1); // Manda LLamar el metodo QuickSort
            Imprimir(ArregloValores.Length); // Manda llamar el metodo imprimir con el tamaño del arreglo correspondiente al ejercicio
        }

        private void QuickSort(double[] ArregloValores, double Inicio, double Union) // MEtodo Quick Sort para acomodar los elementos del arreglo 
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
                   
                    double Temporal = ArregloValores[Indice]; //declara variable y se igual al ArregloValores en la posicion Indice
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
            Console.WriteLine("\n\nEl vector ordenado es: "); 
            for (int i = 0; i < TamañoArreglo; i++) // Ciclo for para desde la variable contador i 0 hasta menor que el tamaño del arreglo 
            {
                Console.Write(ArregloValores[i] + "   "); // Los valores del vector ya acomodado separado por 3 espacios
            }
        }
    }
}
