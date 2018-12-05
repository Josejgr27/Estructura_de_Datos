using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad5
{
    class Operaciones
    {
        public void MainMenu()
        {
        Back:
            Console.Clear();
            Console.WriteLine("Seleccione el ejercicio que desea mirar: \n\n1) Bubble Sort\n2) Radix Sort\n3) Shell Sort\n4) Quick Sort\n5) Salir");
            int Problema = int.Parse(Console.ReadLine());
            if (Problema == 1) { Ejercicio1(); }
            else if (Problema == 2) { Ejercicio2(); }
            else if (Problema == 3) { Ejercicio3(); }
            else if (Problema == 4) { Ejercicio4(); }
            else if (Problema == 5) { }
            else
            {
                Console.WriteLine("Introduzca un numero valido.");
                Console.Write("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                goto Back;
            }



        }
        public void Ejercicio4()
        {
            Quick_Sort Mama = new Quick_Sort();
            Mama.AgregarDatos();
            Console.WriteLine("\n\nPresione cualquier tecla para volver al menu...");
            Console.ReadKey();
            MainMenu();
        }

        public void Ejercicio1()
        {
            BubbleSort E1 = new BubbleSort();
            E1.Menu();
            Console.WriteLine("\n\nPresione cualquier tecla para volver al menu...");
            Console.ReadKey();
            MainMenu();
        }

        public void Ejercicio3()
        {
            Console.Clear();
            Shell_Sort Prueba = new Shell_Sort();
            Prueba.Cargar();
            Prueba.Shell();
            Prueba.Imprimir();
            Console.WriteLine("\n\nPresione cualquier tecla para volver al menu...");
            Console.ReadKey();
            MainMenu();
        }


        public void Ejercicio2()
        {
            Radix Metodo = new Radix();
            Console.Clear();
            Random R = new Random();
            List<int> NumerosAleatorios = new List<int>();
            int[] ArregloNumeros = new int[80];
            for (int i = 0; i < 80; i++)
            {
            Rellenar:
                int Valor = R.Next(0, 999);
                if (NumerosAleatorios.Contains(Valor) == false)
                {
                    NumerosAleatorios.Add(Valor);
                }
                else
                {
                    goto Rellenar;
                }
            }
            Console.WriteLine("Sus numeros aleatorios son: \n");
            int contador = 1;
            foreach (var item in NumerosAleatorios)
            {
                Console.Write("{0}.[" + item + "]   ", contador);
                if (contador % 10 == 0)
                {
                    Console.WriteLine();
                }
                contador++;
            }
            Console.WriteLine("\n\nPresione cualquier tecla para ordenarlos...");
            Console.ReadKey();
            Console.Clear();
            int Contador = 0;
            foreach (var item in NumerosAleatorios)
            {
                ArregloNumeros[Contador] = item;
                Contador++;
            }
            Metodo.RadixSort(ArregloNumeros);
            Console.WriteLine("\n\nPresione cualquier tecla para volver al menu...");
            Console.ReadKey();
            MainMenu();
        }


    }
}


