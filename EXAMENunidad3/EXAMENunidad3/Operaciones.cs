using System;
using System. Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EXAMENunidad3
{
    public class Operaciones
    {
        
        public void Ejercicio1()
        {
            Stack Lista = new Stack();
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,

            foreach (var item in Lista)//si se ejecutan en una pila inicialmente vacía ?
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Lista.Push(5);
            Lista.Push(3);
            Lista.Pop();
            Lista.Push(2);
            Lista.Push(8);
            foreach (var item in Lista)
            {
                Console.WriteLine(item); //push(5), push(3), pop(), push(2), push(8),
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Lista.Pop();
            Lista.Pop();
            Lista.Push(9);
            Lista.Push(1);
            Lista.Pop();
            Lista.Push(7);
            Lista.Push(6);
            Lista.Pop();
            Lista.Pop();
            Lista.Push(4);

            foreach (var item in Lista)
            {
                Console.WriteLine(item);   //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Lista.Pop();
            Lista.Pop();
            foreach (var item in Lista)
            {
                Console.WriteLine(item); //pop(), pop()
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        List<string> PalabrasReservadas = new List<string>();
        public void LLenarListaPalabrasReservadas()
        {
            PalabrasReservadas.Add("ABSTRACT");
            PalabrasReservadas.Add("AS");
            PalabrasReservadas.Add("BASE");
            PalabrasReservadas.Add("BOOL");
            PalabrasReservadas.Add("BREAK");
            PalabrasReservadas.Add("BYTE");
            PalabrasReservadas.Add("CASE");
            PalabrasReservadas.Add("CATCH");
            PalabrasReservadas.Add("CHAR");
            PalabrasReservadas.Add("CHECKED");
            PalabrasReservadas.Add("CLASS");
            PalabrasReservadas.Add("CONST");
            PalabrasReservadas.Add("CONTINUE");
            PalabrasReservadas.Add("DECIMAL");
            PalabrasReservadas.Add("DEFAULT");
            PalabrasReservadas.Add("DELEGATE");
            PalabrasReservadas.Add("DO");
            PalabrasReservadas.Add("DOUBLE");
            PalabrasReservadas.Add("ELSE");
            PalabrasReservadas.Add("ENUM");
            PalabrasReservadas.Add("EVENT");
            PalabrasReservadas.Add("EXPLICIT");
            PalabrasReservadas.Add("EXTERN");
            PalabrasReservadas.Add("FALSE");
            PalabrasReservadas.Add("FINALLY");
            PalabrasReservadas.Add("FIXED");
            PalabrasReservadas.Add("FLOAT");
            PalabrasReservadas.Add("FOR");
            PalabrasReservadas.Add("FOREACH");
            PalabrasReservadas.Add("GOTO");
            PalabrasReservadas.Add("IF");
            PalabrasReservadas.Add("IMPLICIT");
            PalabrasReservadas.Add("IN");
            PalabrasReservadas.Add("INT");
            PalabrasReservadas.Add("INTERFACE");
            PalabrasReservadas.Add("INTERNALE");
            PalabrasReservadas.Add("IS");
            PalabrasReservadas.Add("LOCK");
            PalabrasReservadas.Add("LONG");
            PalabrasReservadas.Add("NAMESPACE");
            PalabrasReservadas.Add("NEW");
            PalabrasReservadas.Add("NULL");
            PalabrasReservadas.Add("OBJECT");
            PalabrasReservadas.Add("OPERATOR");
            PalabrasReservadas.Add("OUT");
            PalabrasReservadas.Add("OVERRIDE");
            PalabrasReservadas.Add("PARAMS");
            PalabrasReservadas.Add("PRIVATE");
            PalabrasReservadas.Add("PROTECTED");
            PalabrasReservadas.Add("PUBLIC");
            PalabrasReservadas.Add("READONLY");
            PalabrasReservadas.Add("REF");
            PalabrasReservadas.Add("RETURN");
            PalabrasReservadas.Add("SBYTE");
            PalabrasReservadas.Add("SEALED");
            PalabrasReservadas.Add("SHORT");
            PalabrasReservadas.Add("SIZEOF");
            PalabrasReservadas.Add("STACKALLOC");
            PalabrasReservadas.Add("STATIC");
            PalabrasReservadas.Add("STRING");
            PalabrasReservadas.Add("STRUCT");
            PalabrasReservadas.Add("SWITCH");
            PalabrasReservadas.Add("THIS");
            PalabrasReservadas.Add("THROW");
            PalabrasReservadas.Add("TRUE");
            PalabrasReservadas.Add("TRY");
            PalabrasReservadas.Add("TYPEOF");
            PalabrasReservadas.Add("UINT");
            PalabrasReservadas.Add("ULONG");
            PalabrasReservadas.Add("UCHECKED");
            PalabrasReservadas.Add("UNSAFE");
            PalabrasReservadas.Add("USHORT");
            PalabrasReservadas.Add("USING");
            PalabrasReservadas.Add("VIRTUAL");
            PalabrasReservadas.Add("VOID");
            PalabrasReservadas.Add("WHILE");
        }
        LinkedList<string> OtrasPalabras = new LinkedList<string>();
        public void Ejercicio2()
        {
            Console.Clear();
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            LLenarListaPalabrasReservadas();
            LinkedList<String> PReservadas = new LinkedList<string>(); //e identificadores y literales en Otra lista enlazada.
            string Sino = "";
            do
            {
                Console.Write("Introduzca lo deseado: ");
                string Palabra = Console.ReadLine().ToUpper();
                if (true == PalabrasReservadas.Contains(Palabra))
                {
                    PReservadas.AddLast(Palabra);
                }
                else
                {
                    OtrasPalabras.AddLast(Palabra);
                }
                Console.WriteLine("Quiere seguir ingresando palabras? (Solo ingrese Si o No)");
                Sino = Console.ReadLine().ToUpper();
            } while (Sino == "SI");
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine("Lista de palabras reservadas ingresadas: ");
            foreach (var item in PReservadas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nLista de palabras Literales e Identificadores1 ingresadas: ");
            foreach (var item in OtrasPalabras)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();


            //Cuando el programa haya terminado de leer la entrada, mostrar


            //Los contenidos de cada lista enlazada.

            //Revise que es un Identificador y que es un literal
        }

        public void Ejercicio3()
        {
            Console.Clear();
            LinkedList<int> ListaLigada = new LinkedList<int>();//mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            List<int> ListaNormal = new List<int>();
            Stopwatch tiempo = Stopwatch.StartNew();
            for (int i = 0; i < 9876; i++)
            {
                ListaNormal.Add(i);
            }
            Console.Write("TIEMPO DE LA LISTA NORMAL: " + tiempo.Elapsed.TotalMilliseconds.ToString()+"\n");
            Stopwatch tiempo2 = Stopwatch.StartNew();
            for (int i = 0; i < 9876; i++)
            {
               ListaLigada.AddLast(i);
            }
            Console.Write("TIEMPO DE LA LISTA LIGADA: " + tiempo2.Elapsed.TotalMilliseconds.ToString());
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        

     public void Ejercicio4()
        {
            Console.Clear();
            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones

            // en un solo curso.Incluir métodos que calculen la nota media, la

            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.

            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
            AgregarAlumnosCalficaciones();
            NotaMedia();
            CalificacionAltaBaja();
        }

        List<Alumno> Alumnos = new List<Alumno>();
        List<int> Calificaciones = new List<int>();
        public void AgregarAlumnosCalficaciones()
        {
            Clase Clase = new Clase();                    
            Console.Write("Bienvenido profesor\ncual es su nombre: ");
            Clase.Maestro = Console.ReadLine();
            Console.Write("\nCual es la materia que imparte: ");
            Clase.NombreClase = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Excelente vamos a calificar a los alumnos");
            for (int i = 0; i < 30; i++)
            {
                Alumno Alumno1 = new Alumno();
                Console.Write("\nIntroduzca el nombre del alumno {0}: ", i+1);
                Alumno1.Nombre = Console.ReadLine();
                Console.Write("Introduzca la calificacion del alumno {0}: ", i+1);
                Alumno1.Calificacion = int.Parse(Console.ReadLine());
                Alumnos.Add(Alumno1);
            }        
        }
        double SumaCalificaciones = 0;
        double Promedio = 0;

        public void NotaMedia()
        {
            foreach (var item in Alumnos)
            {
                SumaCalificaciones = SumaCalificaciones + item.Calificacion;
                Promedio = SumaCalificaciones / Alumnos.Count();
            }
            Console.WriteLine("El promedio de los alumnos es de: {0}", Promedio);
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        public void CalificacionAltaBaja()
        {
            foreach (var item in Alumnos)
            {
                Calificaciones.Add(item.Calificacion);         
            }
            Calificaciones.Sort();
            Console.WriteLine("La calificacion mas alta es: " + Calificaciones[29]);
            Console.WriteLine("La calificacion mas baja es: " + Calificaciones[0]);
            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }

        
    }
}