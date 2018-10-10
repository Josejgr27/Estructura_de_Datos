using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseGerardoRamirez // Profesor comence el trabajo antes que diera el nombre de este, pero es el E3-1
{
    class Calificaciones
    {
        public void Bienvenida() //Este es un metodo donde solo damos la bienvenida al usuario
        {
            Console.WriteLine("Bienvenido al sistema de calificaciones del ITT");
            Console.WriteLine();
        }
        public void CapturaDeMaterias(List<string> ListaDeMaterias) // En este metodo capturamos las materias y las guardamos en una lista
        {
            Console.Write("Introduzca el numero de materias: ");
            int NumeroMaterias = int.Parse(Console.ReadLine());
            for (int Contador = 0; Contador < NumeroMaterias; Contador++)
            {
                Console.Write("\nIngrese la materia numero {0}: ", Contador + 1);
                string Materia = Console.ReadLine();
                ListaDeMaterias.Add(Materia); //aqui se agrega a la lista
            }
            Console.WriteLine();
        }

        public void CapturaDeAlumnos(List<string> ListaDeAlumnos)  // En este metodo capturamos los alumnos y las guardamos en una lista
        {
            Console.Write("Ingrese el numero de alumnos que va a calificar: ");
            int NumeroAlumnos = int.Parse(Console.ReadLine());
            for (int Contador = 0; Contador < NumeroAlumnos; Contador++)
            {
                Console.Write("\nIngrese el alumno numero {0}: ", Contador + 1);
                string Alumno = Console.ReadLine();
                ListaDeAlumnos.Add(Alumno); //aqui se agrega a la lista
            }
        }
        public void ImprimirEncabezado() // Este metodo lo hice con el fin de crear el encabezado de la tabla
        {
            Console.WriteLine("Alumno               Materia                   Calificacion");
        }

            public void ImprimirMaterias(List<string> ListaDeMaterias, List<string> ListaDeAlumnos) // metodo donde se imprimen las materias
        {
            int Contador = 1; // declare un contador para poder usarlo al mover el cursor de la consola
            foreach (var Alumno in ListaDeAlumnos) // anide dos foreach para que pudiera imprimir las veces de la cantidad de alumnos el numero de materias
            {
              foreach (var Materia in ListaDeMaterias)
              {
                Console.SetCursorPosition(21, Contador); // para acomodar las materias en la tabla
                Console.WriteLine(Materia); // escribe la materia
                Contador++;
              }
            }
            
        }

        public void ImprimirAlumnos(List<string> ListaDeAlumnos, List<string> ListaDeMaterias) // metodo donde se imprimen los alumnos
        {
            foreach (var Alumno in ListaDeAlumnos) // anide dos foreach para que pudiera imprimir el nombre del alumno dependiendo las materias que fueron ingresadas
            {
                foreach (var Materia in ListaDeMaterias)
                {
                Console.WriteLine(Alumno); // imprime el alumno
                }

            }
            
        }

        public void CapturaCalificaciones(List<int> ListaDeCalificaciones, List<string> ListaDeAlumnos, List<string> ListaDeMaterias) // Sirve para capturar las calificaciones
        {
            foreach (var Alumno in ListaDeAlumnos) // anide dos foreach con el fin de preguntar la calificacion que desa agregar a cada alumno en cada materia
            {
                foreach (var Materia in ListaDeMaterias)
                {
                    Console.Write("Introduzca la calificacion para el alumno {0} en la materia {1}:", Alumno,Materia);
                    int Calificacion = int.Parse(Console.ReadLine());
                    ListaDeCalificaciones.Add(Calificacion); // agrega la calificacion a la lista de calificaciones
                }
            }
        }
        public void ImprimirCalificaciones(List<int> ListaDeCalificaciones)
        {
            int Contador = 1; // Contador para acomodar la tabla
            foreach (var Calificacion in ListaDeCalificaciones) // foreach para imprimir la lista de calificaciones por cada calificacion en la lista
            {               
                Console.SetCursorPosition(52, Contador);
                Console.WriteLine(Calificacion); // se imprime la calificacion
                Contador++;
            }
        }
    }
}
