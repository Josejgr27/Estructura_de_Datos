using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria
{
    class Operaciones
    {
        private int[] Vector = {1,5,4,7,10,3,2,77,32,19 }; // Valor inicializado ya con valores


        public void Busqueda(int ValorBuscar) // Busqueda con caso base de internet para tener dos estructuras
        {
            int Inicial = 0, Final = 9;
            int Contador = 0;                     // Se declaran variables
            bool Verificar = false;

            while (Inicial <= Final && Verificar == false) // Mientras inicial sea menor o iguala  final y tambien verificar igual falso
            {
                Contador = (Inicial + Final) / 2; // El contador es igual a inicial mas final sobre 2
                if (Vector[Contador] == ValorBuscar) // Si el vector en el contador es igual al valor a buscar 
                {
                    Verificar = true; // Verificar se cambia a true
                }

                if (Vector[Contador] > ValorBuscar) // si el vector en el valor contador es mayor al valor a buscar 
                {
                    Final = Contador - 1; // final es igual a contador - 1
                }

                else
                {
                    Inicial = Contador + 1; // si el vector en el valor contador es menor al valor a buscar 
                }

            }
            if (Verificar == false)  //Si verificar esta en false
            {
                Console.Write("\nEl elemento {0} no se encuentra en el arreglo.", ValorBuscar);                
            }
            else
            {
                Console.Write("\n\nEl elemento {0} se encuentra en la posicion {1} del arreglo (Comenzando desde el 0).", ValorBuscar, Contador);
            }
        }

        public void Imprimir(int[] Arreglo) // Se imprime el arreglo que se le da en el parametro
        {
            Console.WriteLine("Su vector es: \n");
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.Write(Arreglo[i] + "  ");
            }
        }

        public void Ejercicio2() // Se hace una funcion del ejercicio 2
        {
            Console.Clear();
            Array.Sort(Vector);
            Imprimir(Vector);
            Console.Write("\n\nIntroduzca el elemento a buscar: ");
            int Valor = int.Parse(Console.ReadLine());
            Busqueda(Valor);
            Console.ReadKey();
            Console.WriteLine("Presione cualquier tecla para volver al menu...");
            Console.ReadKey();
            MainMenu();
        }



        public void Ejercicio1() // Metodo donde se llama el ejercicio 1
        {
        Tamaño:
            Console.Clear();
            Console.Write("Introduzca el tamaño del vector: ");
            int Tamaño = int.Parse(Console.ReadLine());
            if (Tamaño == 1)
            {
                Console.WriteLine("\n\nEl vector debe ser mayor a 1\n\n\nPresione para continuar...");
                Console.ReadKey();
                goto Tamaño;
            }
            else
            {
                int[] Valores = new int[Tamaño];               
                BusquedaBinaria(Valores, AgregarElementos(Valores));
            }
            Console.WriteLine("Presione cualquier tecla para volver al menu...");
            Console.ReadKey();
            MainMenu();
        }
        public int AgregarElementos(int[] Arreglo)
        {
            List<int> ListaApoyo = new List<int>();
            for (int i = 0; i < Arreglo.Length; i++)
            {
            Back:
                Console.Write("Introduzca el valor {0} del arreglo: ", i + 1);
                int Valorcito = int.Parse(Console.ReadLine());
                if (ListaApoyo.Contains(Valorcito) == false)
                {
                    Arreglo[i] = Valorcito;
                    ListaApoyo.Add(Valorcito);
                }
                else
                {
                    Console.WriteLine("Usted ya ha ingresado ese valor...\n\n\nPresione para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    goto Back;
                }
            }
            Array.Sort(Arreglo);
            Console.Write("\n¿Cual es el valor que desea buscar?  ");
            int Valor = int.Parse(Console.ReadLine());
            return Valor;
        }

        public void BusquedaBinaria(int[] Arreglo, int ValorABuscar) // en este metodo es casi como el metodo bsuqueda, pero en este tiene una estructura diferente
        {
            int Valorinicial = 1;
            int ValorFinal = Arreglo.Length;
            int ValorIntermedio = (Valorinicial + ValorFinal) / 2;
            int[] ArregloTemporal = new int[ValorIntermedio];           
            if (ValorABuscar < Arreglo[ValorIntermedio])
            {
                for (int i = 0; i < ValorIntermedio; i++)
                {
                    ArregloTemporal[i] = Arreglo[i];
                }
                BusquedaBinaria(ArregloTemporal, ValorABuscar);
            }
            else if (ValorABuscar > Arreglo[ValorIntermedio])
            {
                int Contador = 0;
                for (int i = ValorIntermedio; i < Arreglo.Length; i++)
                {
                    ArregloTemporal[Contador] = Arreglo[i];
                    Contador++;
                }
                BusquedaBinaria(ArregloTemporal, ValorABuscar);
            }
            else
            {
                Console.WriteLine("\n\nEl valor {0} se encuentra en la posicion {1} del arreglo (Comenzando desde el 0)", ValorABuscar, ValorIntermedio);
            }
            Console.WriteLine("Presione cualquier tecla para volver al menu...");
            Console.ReadKey();
            MainMenu();
        }


        public void MainMenu() // Menu donde se implementan todos os metodos que se mandaran llamar, para solo llamar este metodo en el main menu
        {          
        Back:
            Console.Clear();
            Console.WriteLine("Busqueda Binaria\n\n");
            Console.WriteLine("Seleccione el ejercicio que desea mirar: \n\n1) Ejercicio 1 (Ingresando valores en el vector)\n2) Ejercicio 2 (Valores ya definidos en el vector)\n3) Salir");
            int Problema = int.Parse(Console.ReadLine());
            if (Problema == 1) { Ejercicio1(); }
            else if (Problema == 2) { Ejercicio2(); }
            else if (Problema == 3) { }
            else
            {
                Console.WriteLine("Introduzca un numero valido.");
                Console.Write("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                goto Back;
            }
        }
    }
}
