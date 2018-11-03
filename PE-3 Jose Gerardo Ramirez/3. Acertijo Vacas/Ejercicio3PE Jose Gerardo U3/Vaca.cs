using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3PE_Jose_Gerardo_U3
{
    class Vaca
    {
       

        public string Nombre { get; set; }
        public int TiempoMinutos { get; set; }
        public Vaca(string Name, int Time)
        {
            Nombre = Name;
            TiempoMinutos = Time;
        }

    }
}
