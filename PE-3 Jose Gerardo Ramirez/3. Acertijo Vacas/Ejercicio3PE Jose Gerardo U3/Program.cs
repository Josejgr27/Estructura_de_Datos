using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3PE_Jose_Gerardo_U3
{
    class Program
    {
        //Supongamos que Bob tiene cuatro vacas que quiere cruzar por un puente, pero solo un yugo, que puede sostener hasta dos vacas, 
        //lado a lado, atadas al yugo. El yugo es demasiado pesado para que lo lleve a través del puente, pero puede atar (y desatar) 
        //vacas a él en muy poco tiempo. De sus cuatro vacas, Mazie puede cruzar el puente en 2 minutos, Daisy puede cruzarlo en 4 minutos, 
        //Crazy puede cruzarlo en 10 minutos y Lazy puede cruzar en 20 minutos. Por supuesto, cuando dos vacas están atadas al yugo, 
        //deben ir a la velocidad de la vaca más lenta. Describe cómo Bob puede conseguir que todas sus vacas crucen el puente en 34 minutos.
        static void Main(string[] args)
        {
            Operaciones Cruzar = new Operaciones();
            Cruzar.MainMenu();
        }
    }
}
