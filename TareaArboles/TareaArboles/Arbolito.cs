using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaArboles
{
    class Arbolito
    {
        int x = 0, y = 2, Altura = 0, Nivel = 0;
        public void AgregarNodo(Nodo nodo, string nombre, string[] nombres) // Metodo para agregar valores
        {
            if (nodo.Arreglo != null) // Si en el arreglo hay valor
            {
                foreach (Nodo item in nodo.Arreglo)//Por cada nodo en el arreglo del nodo 
                {
                    AgregarNodo(item, nombre, nombres); // Va mandar llamar el metodo agregar 
                }
            }
            else  //Si no tiene valor
            {
                if (nodo.Name == nombre) //Si el atributo name del nodo es igual al nombre que ingresamos en el metodo 
                {
                    nodo.Arreglo = new Nodo[nombres.Length]; // EL arreglo inicializado sera de tamaño
                    for (int i = 0; i < nombres.Length; i++)
                    {
                        nodo.Arreglo[i] = new Nodo(nombres[i]); //Y les creamos los nodos a las uniones con su nombre
                    }
                }
            }
        }      
        public void ImprimirNodo(Nodo nodo)//Imprime el Nodo
        {
            
            if (nodo.Arreglo != null) //Si en el arreglo no hay valor
            {
                Console.SetCursorPosition(x, y);
                Console.Write(nodo.Name); // imprime el nombre del nodo
                x = x + 5;
                ++y;
                for (int i = 0; i < nodo.Arreglo.Length; i++)// un ciclo for del 0 hasta el tamaño del arreglo
                {
                    ImprimirNodo(nodo.Arreglo[i]); // MAndamos llamar el metodo imprimir nodo con el Nodo y el indice i
                }
                x += 5;
            }
            else//Si hay valor
            {
                Console.SetCursorPosition(x, y);
                Console.Write(nodo.Name); // Imprimimos el atributo nombre del tipo nodo

                ++y; //Agregamos uno a y

            }
            Altura = (y - 2) / 2; // Altura es igual a la y-2 /2
            Nivel = Altura;//La altura es igual al nivel solo aqui
        }

        public void ArbolC()
        {
            Console.Clear();
            Console.SetCursorPosition(5, 0);
            Console.WriteLine("Arbol C)");
            Nodo NodoRaiz = new Nodo("K");//Creamos nuestro nodo raiz llamado NodoRaiz       
            AgregarNodo(NodoRaiz, "K", new string[] { "B", "A", "C", "D" });  //Mandamos llamar el metodo Agregar Nodo, EL nodo Avanza y ponemos el nodo en el que nos vamos ubicando
            AgregarNodo(NodoRaiz, "D", new string[] { "I    J", "E", }); //No pude mandar llamr el nodo J desde I
            AgregarNodo(NodoRaiz, "E", new string[] { "F", "G" });
            AgregarNodo(NodoRaiz, "G", new string[] { "H" });
            ImprimirNodo(NodoRaiz); // Mandamos llamar el metodo Impresion e imprimimos el NodoRaiz como valor 
            ImprimirDatosC(); //Mandamos llamar EL metodo ImprimirDatos
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        public void ArbolA()
        {
            Console.Clear();
            Console.SetCursorPosition(5, 0);
            Console.WriteLine("Arbol A)");
            Nodo NodoRaiz = new Nodo("G");//Creamos nuestro nodo raiz llamado NodoRaiz       
            AgregarNodo(NodoRaiz, "G", new string[] { "F", "A" });  //Mandamos llamar el metodo Agregar Nodo, EL nodo Avanza y ponemos el nodo en el que nos vamos ubicando
            AgregarNodo(NodoRaiz, "A", new string[] { "B", "C", "D" });
            ImprimirNodo(NodoRaiz); // Mandamos llamar el metodo Impresion e imprimimos el NodoRaiz como valor 
            ImprimirDatosA(); //Mandamos llamar EL metodo ImprimirDatosA
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        public void ArbolB()
        {
            Console.Clear();
            Console.SetCursorPosition(5, 0);
            Console.WriteLine("Arbol B)");
            Nodo NodoRaiz = new Nodo("C");//Creamos nuestro nodo raiz llamado NodoRaiz       
            AgregarNodo(NodoRaiz, "C", new string[] { "D","F", "G", "A" });  //Mandamos llamar el metodo Agregar Nodo, EL nodo Avanza y ponemos el nodo en el que nos vamos ubicando
            AgregarNodo(NodoRaiz, "A", new string[] { "B"});
            AgregarNodo(NodoRaiz, "B", new string[] { "E" });
            ImprimirNodo(NodoRaiz); // Mandamos llamar el metodo Impresion e imprimimos el NodoRaiz como valor 
            ImprimirDatosB(); //Mandamos llamar EL metodo ImprimirDatosA
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        public void ImprimirDatosC() // Imprime solo los datos del arbol C
        {
            Console.WriteLine("\n\n\nLa altura es: {0}", Altura-1);
            Console.WriteLine("La ruta desde K hasta H es: K->D->E->G->H");
            Console.WriteLine("El nivel es: {0}", Nivel-1);
            Console.WriteLine("La ruta desde K hasta C es: K->C");
            Console.WriteLine("La ruta desde K hasta H es: K->D->E->G->H");
            Console.WriteLine("La ruta desde K hasta J es: K->D->I->J");
        }

        public void ImprimirDatosB() // Imprime solo los datos del arbol A
        {
            Console.WriteLine("\n\n\nLa altura es: {0}", Altura);
            Console.WriteLine("La ruta desde C hasta E es: C->A->B->E");
            Console.WriteLine("El nivel es: {0}", Nivel);
            Console.WriteLine("La ruta desde C hasta C es: C");
            Console.WriteLine("La ruta desde C hasta H es: No existe H");
            Console.WriteLine("La ruta desde C hasta J es: No existe J");
        }

        public void ImprimirDatosA() // Imprime solo los datos del arbol A
        {
            Console.WriteLine("\n\n\nLa altura es: {0}", Altura - 1);
            Console.WriteLine("La ruta desde G hasta B, C o D es: G->A->B, C o D");
            Console.WriteLine("El nivel es: {0}", Nivel - 1);
            Console.WriteLine("La ruta desde G hasta C es: G->A->C");
            Console.WriteLine("La ruta desde G hasta H es: No existe H");
            Console.WriteLine("La ruta desde G hasta J es: No existe J");
        }

        public void MainMenu() // SOlo imprime el menu
        {
        Back:
            Console.Clear();
            Console.WriteLine("Introduzca el arbol que desea ver (Ingrese el numero o la letra): \n1. Arbol A)\n2. Arbol B)\n3. Arbol C)\n4. Salir");
            string Arbol = Console.ReadLine().ToUpper();
            if (Arbol == "1" || Arbol == "A")
            {
                ArbolA();
            }
            else if (Arbol == "2" || Arbol == "B")
            {
                ArbolB();
            }
            else if (Arbol == "3" || Arbol == "C")
            {
                ArbolC();
            }
            else if (Arbol == "4" || Arbol == "SALIR")
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Introduzca un valor valido.\nPresione una tecla para continuar...");
                Console.ReadKey();
                goto Back;
            }
        }
    }
}

