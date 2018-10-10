using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseGerardoRamirez
{
    class Program
    {
        static void Main(string[] args)  // LOS METODOS ESTAN COMENTADOS EN LA CLASE CALIFICACIONES
        {
            Calificaciones Calificacion = new Calificaciones(); // Creacion de objeto
            List<string> ListaDeAlumnos = new List<string>();   // creacion de lista      
            List<int> ListaDeCalificaciones = new List<int>(); // Creacion de lista
            List<string> ListaDeMaterias = new List<string>(); // Creacion de lista
            Calificacion.Bienvenida(); 
            Calificacion.CapturaDeMaterias(ListaDeMaterias);
            Calificacion.CapturaDeAlumnos(ListaDeAlumnos);
            Calificacion.CapturaCalificaciones(ListaDeCalificaciones, ListaDeAlumnos, ListaDeMaterias);
            Console.Clear(); // borra pantalla
            Calificacion.ImprimirEncabezado();
            Calificacion.ImprimirAlumnos(ListaDeAlumnos, ListaDeMaterias);
            Calificacion.ImprimirMaterias(ListaDeMaterias, ListaDeAlumnos);                       
            Calificacion.ImprimirCalificaciones(ListaDeCalificaciones);
            Console.ReadKey();
        }
    }
}
