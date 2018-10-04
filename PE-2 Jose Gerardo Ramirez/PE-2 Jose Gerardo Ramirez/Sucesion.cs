using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2_Jose_Gerardo_Ramirez
{
    class Sucesion
    {
      public void GuardarDatos( int[] Sucesion, int TamañoArreglo)
        {
            int Contador = 0;
            while (Contador < TamañoArreglo)
            {
               Sucesion[Contador] = int.Parse(Console.ReadLine());
                Contador++;
            }
        }

        public int InvertirNumero(int [] Sucesion, int Posicion)
        {
            if (Posicion==0)
            {
                Console.Write(Sucesion[Posicion]);
                return 1;
            }
            else
            {
                Console.Write("{0}", Sucesion[Posicion-1]);
                return InvertirNumero(Sucesion, Posicion - 1);
            }
        }

        public int EncontrarElMinimo(int[] Sucesion, int NumeroDatos, int Posicion)
        {
           if(NumeroDatos==Sucesion.Length)
            {
                return Posicion;
            }

           if(Sucesion[NumeroDatos]<Posicion)
            {
                Posicion = Sucesion[NumeroDatos];             
            }
            return EncontrarElMinimo(Sucesion, ++NumeroDatos, Posicion);
        }

        public int EncontrarElMaximo(int[] Sucesion, int NumeroDatos, int Posicion)
        {
            if (NumeroDatos == Sucesion.Length)
            {
                return Posicion;
            }

            if (Sucesion[NumeroDatos] > Posicion)
            {
                Posicion = Sucesion[NumeroDatos];
            }
            return EncontrarElMaximo(Sucesion, ++NumeroDatos, Posicion);
        }
    }
}

