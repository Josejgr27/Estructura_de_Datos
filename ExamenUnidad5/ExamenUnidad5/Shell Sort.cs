using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad5
{
    class Shell_Sort
    {
        private int[] Vector;
        public void Cargar()
        {
            Console.WriteLine("Metodo de Shell Sort\n");
            Console.Write("Cuantos numeros va agregar:");
            string Linea;
            Linea = Console.ReadLine();
            int Cantidad;
            Cantidad = int.Parse(Linea);
            Vector = new int[Cantidad];
            for (int f = 0; f < Vector.Length; f++)
            {
                Console.Write("Ingrese elemento {0}: ", f + 1);
                Linea = Console.ReadLine();
                Vector[f] = int.Parse(Linea);
            }
        }

        public void Shell()
        {
            int Salto = 0, Apoyo = 0, Auxiliar = 0, Contador = 0;
            Salto = Vector.Length / 2;
            while (Salto > 0)
            {
                Apoyo = 1;
                while (Apoyo != 0)
                {
                    Apoyo = 0;
                    Contador = 1;
                    while (Contador <= (Vector.Length - Salto))
                    {
                        if (Vector[Contador - 1] > Vector[(Contador - 1) + Salto])
                        {
                            Auxiliar = Vector[(Contador - 1) + Salto];
                            Vector[(Contador - 1) + Salto] = Vector[Contador - 1];
                            Vector[(Contador - 1)] = Auxiliar;
                            Apoyo = 1;
                        }
                        Contador++;
                    }
                }
                Salto = Salto / 2;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("\n\nSus numeros ordenados de mayor a menor son:");
            int Contador = 1;
            for (int f = Vector.Length-1; f >= 0; f--)
            {
                Console.Write("{0}.[{1}]   ",Contador, Vector[f]);
                Contador++;
            }
        }
    }
}
