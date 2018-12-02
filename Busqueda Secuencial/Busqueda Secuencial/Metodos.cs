using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Secuencial
{
    class Metodos
    {
        public int Posicion { get; set; } // Atributo de posicion

        public void RegistrosUsuarios() // Metodo para registrar usuarios y determianr si este existe o no
        {
            Console.Clear(); // Borra pantalla
            Metodos Gerardo = new Metodos(); // Creo el objeto
            List<string> Usuarios = new List<string>() { "jose27", "javiercito13", "angela54", "marco1", "Juan1", "Alejandro4" }; // Se crea la lista y se agrega elementos
        SiExiste:
            Console.Clear(); // Borra pantalla
            Console.Write("Introduce tu nombre de usuario (introduce salir para salir): "); 
            string NombreUsuario = Console.ReadLine().ToLower(); // Guarda el valor y lo hace en minusculas
            if (NombreUsuario == "salir") //si nombre de usuario es igual a salir
            { MainMenu(); } // Llama el metodo MainMenu para salir del programa 
            else // Si es diferente a salir
            {
              if (BusquedaSecuencialString(Usuarios,NombreUsuario) == true) // Si el metodo busquedasecuencialstring regresa un valor true 
              {
                Console.Clear(); // Borra pantalla
                Console.WriteLine("El usuario ya existe\n\nPresione cualquier tecla para introducir otro nombre de usuario...");
                Console.ReadKey();
                goto SiExiste; // Regresa a si existe
              }          
              else // Si el metodo es igual a false
              {
                Usuarios.Add(NombreUsuario); // Agrega el nombre de usuario a la lista
                Console.WriteLine("Se ha registrado su nombre de usuario correctamente\n\nPresione cualquier tecla para volver al menu");
                Console.ReadKey();
                goto SiExiste; // Regresa a si existe
              }           
            }
            
        }

        public bool BusquedaSecuencialString(List<string> Vector, string NombreUsuario) // Funcion que regresa el valor true o false dependiendo si esta o no
        {
            int Contador = 0; // Contador para evaluar todas las posiciones de la lista
            bool Esta = false; // Variable apra saber si se encuentra en la lista o no
            while (Esta == false && Contador < Vector.Count) // Mientras la variable Esta sea igual a false y tambien el contador sea menor al tamaño de la lista
            {
                if (NombreUsuario == Vector[Contador]) // si el nombre de usuario es igual a la posicion que se encuentre en el contador 
                {
                    Esta = true; // esta se cambia a true
                    Posicion = Contador; // posicion es igual al contador
                }
                Contador++; // Contador se suma 1
            }
            return Esta; // Regresa esta dependiendo la variable que se encuentre
        }

 
        public bool BusquedaSecuencialEntera(int [] Vector, int Numero) // Busqueda secuencial entera
        {
            int Contador = 0; // Contador para evaluar todas las posiciones de la lista
            bool Esta = false; // Variable apra saber si se encuentra en la lista o no
            while (Esta == false && Contador < Vector.Length) // Mientras la variable Esta sea igual a false y tambien el contador sea menor al tamaño del arreglo
            {
                if (Numero == Vector[Contador]) // si el nombre de usuario es igual a la posicion que se encuentre en el contador 
                {
                    Esta = true; // esta se cambia a true
                    Posicion = Contador; // posicion es igual al contador
                }
                Contador++; // Contador se suma 1
            }
            return Esta;  // Regresa esta dependiendo la variable que se encuentre
        }

        public void ImprimirLineUp(string [] Jugadores, int[]  Numeros) // Imprime los 9 jugadores del equipo ya inicializados y sus numeros
        {
            Console.WriteLine("Nombre(Posicion): Numero\n");
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("{0}: {1}", Jugadores[i], Numeros[i]);
            }
        }

        public void EquipoBeisbol() // Metodo en el que agregas el numero a un jugador y si este ya lo tiene te lo avisa
        {
            Console.Clear();
            Metodos Jose = new Metodos(); // Objeto jose para poder utilizar el atributo
            Console.WriteLine("Eres un entrenador de beisbol, tu equipo es de 9 jugadores, tu le vas a poner el numero que tu consideres sea bueno para el, recuerda que solo puedes poner el numero una sola vez.\n\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            string[] Jugadores = { "Miguel Paez (CF)", "Martin Paez (3B)", "Jose Gerardo (SS)", "Alex Villagrana (C)", "Julio Castro (2B)", "Roy Ruiz (1B)", "Omar Castro (LF)", "Omar Gomez (RF)", "Gil Buenrostro (P)" };
            int[] Numeros = new int[9]; // se crea el arreglo de tamaño 9
            for (int i = 0; i < Jugadores.Length; i++) // para todos los jugadores
            {
            Volver: // etiqueta para volver aqui
                Console.Clear();
                Jose.ImprimirLineUp(Jugadores, Numeros); // Manda llamar la funcion imprimir
                Console.SetCursorPosition(0, 12); // Coloca el cursor en x = 0, Y= 12
                Console.WriteLine("Introduzca el numero para el jugador {0}: ", Jugadores[i]);
                int Numero = int.Parse(Console.ReadLine()); // lee y guarda en variable
                if (Jose.BusquedaSecuencialEntera(Numeros, Numero) == true) // manda llamar el Metodo Busqueda secuencial entera y si este es igual a true es que si se encuentra
                {
                    Console.Clear();
                    Console.WriteLine("El numero {1} ya lo tiene el jugador {0} del equipo, Introduzca otro.\n\nPresione cualquier tecla para introducirle otro numero al jugador...", Jugadores[Jose.Posicion], Numero);
                    Console.ReadKey();
                    goto Volver;
                }
                else // si es igual a false es que no se encuentra y si pudee agregar ese numero al jugador
                {
                    Numeros[i] = Numero; // Guarda el numero para el jugador en la posicion i
                }
            }
            Console.Clear(); // BOrra pantalla
            Console.WriteLine("Se han agregado los numeros de cada jugador con exito.\n\nPresione cualquier tecla para salir...");
            Console.ReadKey();
            MainMenu(); //Regresa al menu principal
        }


        public void MainMenu() // MEnu para seleccionar el programa solamente
        {
            Console.Clear();
            Console.WriteLine("Seleccione el programa de Busqueda Secuencial que desea ver\n1. Equipo de Beisbol\n2. Registro de nombre de usuario\n3.Salir");
            int Programa = int.Parse(Console.ReadLine());
            if (Programa == 1) // Si programa es igual a 1
            {
                EquipoBeisbol(); // Llama la el metodo EquipoBeisol
            }
            else if (Programa == 2) // Si programa es igual a 2
            {
                RegistrosUsuarios(); // llama el metodo Registro usuarios
            }
            else if (Programa == 3) { } // Si programa es igual a 3 Sale del programa
            else // Si no es ninguna de las 3 anteriores pide que ingreses uno de llos 3 anteriores
            {
                Console.WriteLine("Introduce un numero valido solo 1, 2 o 3.\n\nPresiona cualquier tecla para volver al menu...");
                Console.ReadKey();
            }
        }

    }
}
