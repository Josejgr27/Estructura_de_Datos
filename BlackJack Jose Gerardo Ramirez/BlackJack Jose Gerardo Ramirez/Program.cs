using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Jose_Gerardo_Ramirez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; // Para que los simbolos de las cartas puedan funcionar en la consola
            Carta CartaPapa = new Carta(); // Se declara el objeto de la clase Carta
            CartaPapa.MainMenu(); // Se manda llamar el metodo MainMenu
        }
    }
}
