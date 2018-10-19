using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Jose_Gerardo_Ramirez
{
    class Carta
    {
        public void Bienvenida() // Da la bienvenida al juego
        {
            Console.WriteLine("Bienvenido al juego BlackJack");
            Console.WriteLine();
            Console.Write("Introduce tu nombre de usuario: ");
            string Usuario = Console.ReadLine(); // Guarda el nombre del usuario para 
            Console.Clear(); // Borra la consola 
            Console.WriteLine("Comencemos {0}", Usuario);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine();
        }
        public void LLenarCartas(ArrayList Numero, ArrayList Simbolo) //Rellena de cartas Las array list
        {
            for (int i = 0; i < 4; i++) //Un for para agregar las letras A,K,Q,J 4 veces cada una
            {
                Numero.Add("A");
                Numero.Add("K");
                Numero.Add("Q");
                Numero.Add("J");
                for (int p = 2; p < 11; p++)
                {
                    Numero.Add(p); // Agrega los numeros del 2 al 10 4 veces cada uno
                }
            }
            for (int i = 0; i < 4; i++) // Un cliclo for para agregar las figuras 13 veces cada figura
            {
                string Figura = "";
                if (i == 0) // Si el valor de i es igual a 0
                {
                    Figura = "♠"; // Figura va a ser igual a la figura Picas
                }
                if (i == 1) // Si el valor de i es igual a 1
                {
                    Figura = "♣"; // Figura va a ser igual a la figura Trebol
                }
                if (i == 2) // Si el valor de i es igual a 2
                {
                    Figura = "♦"; // Figura va a ser igual a la figura Rombos
                }
                if (i == 3) // Si el valor de i es igual a 3
                {
                    Figura = "♥"; // Figura va a ser igual a la figura Corazon
                }
                for (int p = 0; p < 13; p++) // Agrega cada figura correspondiente 13 veces
                {
                    Simbolo.Add(Figura); //Agregara el valor de simbolo a la lista simbolo
                }
            }
        }

        public void Barajar(ArrayList Numero, ArrayList Simbolo, Stack Mazo, Stack MazoNumeros, Random Aleatorio) //Pasa un dato aleatorio de la lista 
        {                                                                                               // A la pila ordenados aleatoriamente y los va eliminando de la lista hasta que no quede ninguno
            for (int i = 0; i < 52; i++) 
            {
                int Variable = Aleatorio.Next(0, Numero.Count);
                Mazo.Push(Simbolo[Variable]); // Push agrega elementos a la pila, en este caso un simbolo de la lista con posicion aleatoria
                MazoNumeros.Push(Numero[Variable]); // Push agrega elementos a la pila, en este caso un nuemro de la lista con posicion aleatoria
                Numero.RemoveAt(Variable); //Elimina el numero de la lista (El agregado a la pila)
                Simbolo.RemoveAt(Variable); // Elimina  el simbolo de la lista (Agregado a la pila)
            }
        }

        public void Repartir_Cartas(Stack Mazo, Stack MazoNumeros, Stack Jugador, Stack Ganados, Stack Perdidos) // Reparte Cartas y las va sumando 
        {
            object Carta1 = MazoNumeros.Pop(); //Guarda el valor del primer elemento en la pila y lo saca con el Pop
            object Carta2 = MazoNumeros.Pop();
            Console.WriteLine("Aqui tienes tus dos cartas: \n");
            Console.Write (Mazo.Pop() + "" + Carta1); // Te imprime tus primeras cartas de manera aleatoria
            Console.WriteLine("    " + Mazo.Pop() + "" + Carta2);
            Jugador.Push(Carta1); // La carta que te dio la mete a una pila donde las ira sumando
            Jugador.Push(Carta2);  // La carta que te dio las metera a una pila para poderlas sumar

            int Resultado = 0; // inicia suma de cartas
            List<int> Sumando = new List<int>(); // Se crea una lista
            for (int i = 0; i < 2; i++) // hace dos veces esa actividad
            {
                var Numerito = Jugador.Peek(); // agrego una variable de tipo var con el valor del primer element de la pila pero no lo saca de la pila
                if (Numerito.ToString() == "K"|| Numerito.ToString()=="Q" || Numerito.ToString() =="J") // Si valor de Numerito es igual a K, Q o J. Numerito valdra 10
               {
                    Numerito = 10;                  // se le da el valor de 10 a numerito
               }
                if(Numerito.ToString() == "A") // Si numerito es igual a un A se le preguntara a numerito si quiere que su carta valga 1 u 11
                {
                    As:
                    Console.WriteLine("Desea que el A´s valga 1 u 11 (Introduzca solo el numero): ");
                    int Valor = int.Parse(Console.ReadLine());
                    if (Valor== 1) // Si responde 1 
                    {
                        Numerito = 1; // Numerito vale 1
                    }
                    else if (Valor == 11) // Si responde 11
                    {
                        Numerito = 11; // Numerito vale 11
                    }
                    else // Si no es ninguna de esas dos
                    {
                        Console.WriteLine("Introduzca un numero valido"); // Debe introducir un numero valido
                        goto As; // Te regresa a la etiqueta As
                    }
                }
                Sumando.Add(Convert.ToInt32(Numerito)); // Se agrega Numerito a una lista que se sumara mas adelante
                Jugador.Pop(); // Saca la carta de jugador
            }

            foreach (var item in Sumando) // Por cada elemento de cualquier tipo en Sumando 
            {
                Resultado = item + Resultado; // se sumara y se agregara el valor a resultado
            }
            Console.WriteLine("El resultado de sus cartas es de: " + Resultado); // El resultado de tus cartas es de n
        ComeBack:
            if(Resultado<21) // Si el resultado es menor a 21
            {
                Console.WriteLine("Presione cualquier tecla para entregar la siguiente carta..."); // Se te entrega otra carta si no igual pierdes
                Console.ReadKey();
                var Carta3 = MazoNumeros.Pop(); // Guarda la carta en una variable var 
                Console.WriteLine(Mazo.Pop() + ""+ Carta3); // Escribe tu carta con la ayuda de las de ambas pilas
                // Declarando para usar en el ciclo
                Jugador.Push(Carta3); // Con la ayuda del Push saca la carta del arreglo
                var Numerito = Jugador.Peek(); // Agrega una carta de la pial de numeros a la variable numerito
                if (Numerito.ToString() == "K" || Numerito.ToString() == "Q" || Numerito.ToString() == "J") // Si valor de Numerito es igual a K, Q o J. Numerito valdra 10
                {
                    Numerito = 10; // Numerito guarda el valor de 10
                }
                if (Numerito.ToString() == "A") // Si numertio es igual a A
                {
                As:
                    Console.WriteLine("Desea que el A´s valga 1 u 11 (Introduzca solo el numero): "); // se pregunta el valor del As
                    int Valor = int.Parse(Console.ReadLine());
                    if (Valor == 1) // Si selecciona el 1
                    {
                        Numerito = 1; // Numerito es igual a 1
                    }
                    else if (Valor == 11)// Si selecciona el 11
                    {
                        Numerito = 11; // Numerito es igual a 11
                    }
                    else // Si selecciona un valor diferente
                    {
                        Console.WriteLine("Introduzca un numero valido"); // Introduzca un valor invalido
                        goto As;// nREgresa a la etiqueta As
                    }
                }
                Sumando.Add(Convert.ToInt32(Numerito));// Agrega numerito a la lista Sumando
                Resultado = Resultado + Sumando.Last();
                Console.WriteLine("El resultado de sus cartas es de: "+Resultado);     // Imprime el resutado de la suma           
                goto ComeBack; // Regresa a la etqueta come back
            }
            if(Resultado==21) // Si resultado es igual a 21 ganas
            {
                Console.WriteLine("\n¡Felicidades haz ganado el juego!");
                Console.WriteLine("Presione cualquier tecla para el siguiente juego");
                Console.ReadKey();
                Ganados.Push(1);              // Se agrega el elemento uno a la pila
            }

            if (Resultado> 21) // Si resultado es igual a 21 ganas
            {
                Console.WriteLine("\nPerdiste el juego"); 
                Console.WriteLine("Presione cualquier tecla para el siguiente juego");
                Console.ReadKey();
                Perdidos.Push(2);  // Se agrega el elemento uno a la pila
            }

        }
            public void Ganados_Perdidos(Stack Ganados, Stack Perdidos, int Iniciar) // PAra ver los ganados y perdidos
        {
            Console.Clear(); // Borra la pantalla
            Console.WriteLine("Usted gano {0} juegos de {1} jugados", Ganados.Count, Iniciar); // Usted gano n(el numero de elementos en la pila)
            Console.WriteLine("Usted perdio {0} juegos de {1} jugados", Perdidos.Count, Iniciar); // De n juegos jugados 
        }
        public void MainMenu()
        {
            Carta Baraja = new Carta(); // Se crea el objeto de tipo Carta
            int iniciar = 0;// Creo la variable para despues usarlo al ver cuantas veces se jugara
            Stack Ganados = new Stack(); // Se crea la pila de juegos ganados
            Stack Perdidos = new Stack(); // Se crea la pila de juegos perdidos
            Baraja.Bienvenida(); // Se manda llamar el metodo Bienvenida
            Console.Clear();   // Borra lo de la consola para un nuevo juego
        Jugar:
            Console.Clear();
            Stack Jugador = new Stack(); // Se crea la pila de jugador 
            List<int> Numeritos = new List<int>(); // Se crea la lista numeritos
            Stack Mazo = new Stack(); // Se crea la pila de mazo
            Stack MazoNumeros = new Stack(); // Se crea la pila mazo de numeros
            ArrayList Numero = new ArrayList(); // Se crea un ArrayList de numeros
            ArrayList Simbolo = new ArrayList(); // Se crea un ArrayList de simbolos
            Random Aleatorio = new Random(); // Se crea una variable Random           
            Baraja.LLenarCartas(Numero, Simbolo);        // LLena de cartas las listas Numero y simbolo        
            Baraja.Barajar(Numero, Simbolo, Mazo, MazoNumeros, Aleatorio); // Barajea las cartas de la lista metiendolas una pila nueva
            Baraja.Repartir_Cartas(Mazo, MazoNumeros, Jugador, Ganados, Perdidos); // Entrega las cartas y las va eliminando de la pila asi como va entregando el resultado
        VolveraJugar:
            Console.WriteLine("¿Desea Volver a jugar? Si/No"); // Se le agrega uno a sumar (Se lleva un juego de 5)
            string p = Console.ReadLine().ToUpper();
            if (p == "SI")
            {
                iniciar = iniciar + 1;
                goto Jugar;
            }
            else if (p == "NO")
            {
                iniciar = iniciar + 1;
                Baraja.Ganados_Perdidos(Ganados, Perdidos, iniciar); //Al final de los 5 juegos imprime cuantos ganaste y cuantos perdiste
                Console.ReadKey();
            }
            else
            {
                Console.Write("Introduzca un valor correcto; Si o No solamente.");
                goto VolveraJugar;
            }
        }
    }
}
