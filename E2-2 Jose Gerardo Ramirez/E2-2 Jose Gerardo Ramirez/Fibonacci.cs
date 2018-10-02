using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_2_Jose_Gerardo_Ramirez
{
    class Fibonacci
    {
        public void Iterativo(int Numero)
        {
            int Base1 = 0;
            int Base2 = 1;
            Console.WriteLine("1");
            for (int Contador = 0; Contador < Numero-1; Contador++)
            {
                int Resultado = Base1;
                Base1 = Base2;
                Base2 = Resultado + Base2;
                Console.WriteLine(Base2);
            }
        }

        public void ConversionASegundos(DateTime Inicio, DateTime Final)
        {
            TimeSpan Duracion = Final - Inicio;
            double SegundosTotales = Duracion.TotalSeconds;
            Console.WriteLine("El programa tiene una duracion de {0} segundos", SegundosTotales);
        }
        public int Recursividad(int Resultado)
        {
            if (Resultado < 2)
            {
                return Resultado;
            }
            else
            {
                return Recursividad(Resultado - 1) + Recursividad(Resultado - 2);
            }
        }
    }
}
