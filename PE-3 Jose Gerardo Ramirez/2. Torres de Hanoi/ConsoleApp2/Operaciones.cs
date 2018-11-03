using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Operaciones
    {
        List<int> ListaNumeros = new List<int>(); // Crea la lista llamada Lista de numeros
        Stack<int> PilaOrdenada = new Stack<int>();// Crea la pila de numeros
        Stack<int> PilaIzquierda = new Stack<int>();
        Stack<int> PilaDerecha = new Stack<int>();
        public void LlenarPila(int NumeroAros) // Se crea un metodo llamado llenar pila
        {          
            for (int i = 0; i < NumeroAros; i++) //Agrega los numeros que el usuario pide
            {
                ñaña: //Etiqueta ñaña para regresar aqui
                Console.Write("\nIntroduzca el valor {0} de la torre: ", i+1);
                int Valor = int.Parse(Console.ReadLine()); // Guarda lo ingresado en la variable Valor
                if (false == ListaNumeros.Contains(Valor)) // Si Lista de numeros no contiene un valor igual regresa false, si false==false hace lo siguiente
                {
                    ListaNumeros.Add(Valor);// Agrega el elemento Valor a la lista
                    Console.WriteLine("Se ha ingresado su numero\n");
                }
                else if(true==ListaNumeros.Contains(Valor))// Si Lista de numeros contiene un valor igual regresa true, si true == true hace lo siguiente
                {
                    Console.WriteLine("Este valor ya se encuentra ingresado \nPresione cualquier tecla para continuar...");                  
                    Console.ReadKey();
                    goto ñaña; // Si se hace esta operacion regresa a la etiqueta ñaña a volver a pedir el numero
                }
            }
        }

        public void Bienvenida() // Solo da la bienvenida al programa
        {
            Console.WriteLine("Bienvenido al juego torres de Hanoi\n\nPresione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public void ImprimeListaNormal() // Imprimela lista de numeros ingresados
        {
            ListaNumeros.Sort(); // Ordena de menor a mayor la lista de numeros
            foreach (var item in ListaNumeros) // por cada elemento var en Lista de numeros
            {
                Console.WriteLine(item); // Imprime el elemento
            }      
        }
        
        public void OrdenarPila()//Pasa un dato aleatorio de la lista a la pila ordenados aleatoriamente 
        {          
            ListaNumeros.Sort(); // ORdena la pila
            ListaNumeros.Reverse(); // Invierte los elementos de la pila
            foreach (var item in ListaNumeros)// por cada elemento var en Lista de numeros
            {
                PilaOrdenada.Push(item);// Imprime el elemento
            }
        }

        public void ImprimirPilaNormal()
        {
            foreach (var item in PilaOrdenada)// por cada elemento var en pila desordenada
            {
                Console.WriteLine(item); // imprime el elemento
            }
        }
        public void ImprimirPilaOrdenada(int NumeroAros) // Imprime la pila de la izquierda la inicial
        {
            PilaOrdenada.Reverse(); // Ordena la pila de mayor a menor pues ya esta de menor a mayor
            int Contador = NumeroAros - 1; // un contador que inicieen el numero de aros menos 1
            foreach (var item in PilaOrdenada)
            {
                Console.SetCursorPosition(3, Contador); // Para cambiar la posiicion del cursor
                Console.WriteLine(item);
                Contador--;// De abajo hacia arriba
            }
        }

        public void ImprimirPilaCentral(int NumeroAros) // Imprime la pila del centro
        {
            int Contador = 0;
            foreach (var item in PilaIzquierda)
            {
                Console.SetCursorPosition(10, Contador);// Para cambiar la posiicion del cursor
                Console.WriteLine(item);
                Contador++;// De arriba haca abajo
            }
        }

        public void ImprimirPilaDerecha() // Imprime la pila de la derecha
        {
            int Contador = 0;
            foreach (var item in PilaDerecha)
            {
                Console.SetCursorPosition(20, Contador); // PAra la posicion del cursor
                Console.WriteLine(item);
                Contador++; // de arriba hacia abajo
            }
        }


        public void PasarIzquierdaCentro(int NumeroAros) // PAra pasar los datos de la pila de izquierda a la pila del centro
        {
            for (int i = 0; i < NumeroAros; i++)// hace ese ciclo el mismo numero de valores que hay en la pila 
            {
                PilaIzquierda.Push(PilaOrdenada.Pop()); // Pila ordenada(pila de la izquierda) saca el valor innicial y lo guarda en la pila de la izquierda que es la central
                Console.Clear();
                ImprimirPilaNormal(); // MAnda llamar el metodo
                ImprimirPilaCentral(NumeroAros);
                Console.SetCursorPosition(0,NumeroAros+2);// Mueve el cursor de posicion
                Console.WriteLine("Presione para continuar...");
                Console.ReadKey();
            }
                
        }

        public void PasarCentroDerecha(int NumeroAros) // hace exactamente el mismo proceso que el de izquierda al central pero este del centro a la derecha
        {
            for (int i = 0; i < NumeroAros; i++)
            {
                PilaDerecha.Push(PilaIzquierda.Pop()); // Pila de la derecha se le agrega pila de la izquierda que es la central el primer elemento
                Console.Clear();
                ImprimirPilaCentral(NumeroAros);
                ImprimirPilaDerecha();
                Console.SetCursorPosition(0, NumeroAros + 2);// Mueve el cursor de posicion
                Console.WriteLine("Presione para continuar...");
                Console.ReadKey();
            }

        }

        public void MainMenu() // Se crea un mini menu en metodo para no tener nada en el main
        {      
            Bienvenida(); // Se da la bienvenida
            Console.Write("Cuantos numeros desea tener en la torre: "); // Se pregunta cuantos datos quiere tener en la torre 
            int NumeroAros = int.Parse(Console.ReadLine()); // Guardamos en una variable numero de aros que se utilizara para dar parametros
            LlenarPila(NumeroAros); // Se madna llamar llenarpila con parametro numero de Aros
            Console.Clear();
            Console.WriteLine("Presione para ver las torres...");
            Console.ReadKey();
            Console.Clear();
            OrdenarPila();// Se manda llamar ordenar pila
            ImprimirPilaNormal();
            Console.WriteLine("Presione para continuar...");
            Console.ReadKey();
            Console.Clear();
            PasarIzquierdaCentro(NumeroAros);// Se mandaa llamar  PasarIzquierdaCentro con parametro numero de Aros
            PasarCentroDerecha(NumeroAros);// Se manda llamar PasarCentroDerechacon parametro numero de Aros
            Console.Clear();
            Console.WriteLine("Juego Terminado\nPresione cualquier tecla para Salir..."); // Indica que el juego termino
            Console.ReadLine();
        }
    }
}
