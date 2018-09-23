using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Examen_08
{
    class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            double Numero;
            string NumeroInvertido = "", Lector; 
            Console.Write("Ingrese un numero de 5 digitos: ");
            Numero = double.Parse(Console.ReadLine());
            string NumeroString = Numero.ToString();
            int NumeroLetras = NumeroString.Length;
            if (NumeroString.Length==5)
            {
                for (int Contador = NumeroLetras - 1; Contador >= 0; Contador--)
                {
                    Lector = NumeroString.Substring(Contador, 1);
                    NumeroInvertido = NumeroInvertido + Lector;
                }
                if (NumeroString.Equals(NumeroInvertido))
                {
                    Console.WriteLine("\nEs palindromo");
                }
                else
                {
                    Console.WriteLine("\nNo es palindromo");
                }
            }
            else
            {
                Console.WriteLine("\n¡ERROR!\nNo es digito de 5 letras\n");
                goto Inicio;
            }
            
            Console.ReadKey();
        }
    }
}
