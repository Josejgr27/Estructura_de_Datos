using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3PE_Jose_Gerardo_U3
{
    class Operaciones
    {
        List<Vaca> AntesPuente = new List<Vaca>(); // Crea la lista Antes del puente
        List<Vaca> DespuesPuente = new List<Vaca>(); // Crea la lista Despues del puente
        Vaca Mazy = new Vaca("Mazy", 2); // Crea un objeto llamado Mazy con ayuda del constructor
        Vaca Daisy = new Vaca("Daisy", 4); // Crea un objeto llamado Daisy con ayuda del constructor
        Vaca Crazy = new Vaca("Crazy", 10); // Crea un objeto llamado Crazy con ayuda del constructor
        Vaca Lazy = new Vaca("Lazy", 20); // Crea un objeto llamado Lazy con ayuda del constructor
        public void AgregarDatos() // Agrega Los objetos a la lista antes del puente ( lista inicial)
        {  
            AntesPuente.Add(Mazy); // Agrega Mazy
            AntesPuente.Add(Daisy); // Agrega DAisy
            AntesPuente.Add(Crazy); // Agrega Crazy
            AntesPuente.Add(Lazy); // Agrega LAzy
        }
        public void Inicio() // Introduce el acertijo
        {
            Console.WriteLine("Acertijo:\nSupongamos que Bob tiene cuatro vacas que quiere cruzar por un puente, pero solo un yugo, que puede sostener hasta dos vacas, lado a lado, atadas al yugo. El yugo es demasiado pesado para que lo lleve a través del puente, pero puede atar (y desatar) vacas a él en muy poco tiempo. De sus cuatro vacas, Mazie puede cruzar el puente en 2 minutos, Daisy puede cruzarlo en 4 minutos, Crazy puede cruzarlo en 10 minutos y Lazy puede cruzar en 20 minutos. Por supuesto, cuando dos vacas están atadas al yugo, deben ir a la velocidad de la vaca más lenta. Describe cómo Bob puede conseguir que todas sus vacas crucen el puente en 34 minutos. ");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Presione para ver los pasos de la solucion...");
            Console.ReadKey();
            Console.Clear(); // Borra pantalla
        }
        public void AntesCruzarPuente() // Imprime la lista AntesPuente
        {
            foreach (var item in AntesPuente) // Por cada elemento item en AntesPuente
            {
                Console.WriteLine(item.Nombre); // imprime el atributo nombre del item
            }
            Console.SetCursorPosition(7, 0); // Cambia a posicion 7 en x y 0 en y
            Console.WriteLine("_____________________"); //Crea el puente
            Console.SetCursorPosition(7, 2);
            Console.WriteLine("_____________________"); // Crea el puente
        }
        public void DespuesCruzarPuente() // Imprime la lista AntesPuente
        {
            int Contador = 0; // Contador para cambiar de renglon
            foreach(var item in DespuesPuente) // Por cada elemento item en DEspuesPuente 
            {
                Console.SetCursorPosition(30,Contador); // EN la posicion 30 en x despues del puente 
                Console.WriteLine(item.Nombre); // Imprime el atributo nombre de item
                Contador++; // Se le suma uno al contador
            }
        }


        public void ImprimirAmbosLados() // Manda llamar los metodos AntesCruzarPuente y DepuesCruzarPuente
        {
            AntesCruzarPuente(); // Para imprimir ambos lados del puente
            DespuesCruzarPuente();
        }

        public void Paso1() // Paso 1 
        {
            DespuesPuente.Add(AntesPuente[0]); //agrega Mazy a la lista despues del puente
            DespuesPuente.Add(AntesPuente[1]); //agrega Daisy a la lista despues del puente
            AntesPuente.RemoveAt(0); //Remueve a Mazy de la lista AntesPuente con todo y espacio (deja 3 elementos)
            AntesPuente.RemoveAt(0); //DAisy queda en el lugar 0 y Remueve a Daisy de la lista AntesPuente con todo y espacio (deja 2 elementos)
            Console.Clear(); // Elimina lo que hay en la consola
            ImprimirAmbosLados(); // Manda llamar metodo donde imprime ambas listas
            Operacion1(); // MAnda llamar el metodo 1
        }
        public void Operacion1() // Imprime la operacion numero 1
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Operaciones: ");
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("Cruzan: Mazy (2min) + Daisy (4min) = 4 min");
        }
        public void Paso2() // Paso2
        {
            AntesPuente.Add(DespuesPuente[0]); // Regresa Mazy a antes del puente
            DespuesPuente.RemoveAt(0); // ELimina a mazy con todo y posicion de despues del puente
            Console.Clear(); // Borra consola
            ImprimirAmbosLados(); // Imprime ambos lados del puente y el puente
            Operacion1(); // ImprimeLA operacion1
            Operacion2(); // Imprime la operacion2
        }
        public void Operacion2() // Operacion 2 imprime la operacion 2
        {
            Console.SetCursorPosition(50, 3);
            Console.WriteLine("Regresa:                Mazy(2min) = 2 min");
        }

        public void Paso3() // Paso 3
        {
            DespuesPuente.Add(AntesPuente[0]); // Agrega a Crazya la lista despues del puente
            DespuesPuente.Add(AntesPuente[1]); // Agrega a Lazy a la lista antes del puente
            AntesPuente.RemoveAt(0); // REmueve a Crazy con todo y espacio en la lista antes puente
            AntesPuente.RemoveAt(0); // REmueve a LAzy con espacio en la lista antes puente
            Console.Clear(); // Elomina lo que hay en la consola
            ImprimirAmbosLados(); // Imprime ambos lados y puente
            Operacion1(); // imprime operacion 1
            Operacion2(); // imprime operacion 2
            Operacion3(); // Imprime operacion 3
        }
        public void Operacion3() // Imprime la operacion 3
        {
            Console.SetCursorPosition(50, 4);
            Console.WriteLine("Cruzan: Crazy(10min) + Lazy(20min) = 20 min");
        }
        public void Paso4() // PAso 4
        {
            AntesPuente.Add(DespuesPuente[0]); // Agrega a daisy en la lista antes del puente
            DespuesPuente.RemoveAt(0); // y remueve a daisy de la lista despues del puente
            Console.Clear(); // Borra consola
            ImprimirAmbosLados(); // imprime ambos lados
            Operacion1();  // manda llamar el metodo operacion 1 2 3 y 4
            Operacion2();
            Operacion3();
            Operacion4();
        }
        public void Operacion4() // imrprime la operacion 4
        {
            Console.SetCursorPosition(50, 5);
            Console.WriteLine("Regresa:               Daisy(4min) = 4 min");
        }
        public void Paso5()//PAso 5
        {
            DespuesPuente.Add(AntesPuente[0]); // agrega a Mazy a despues del puente
            DespuesPuente.Add(AntesPuente[1]); // Agrega a daisy a despues del puente
            AntesPuente.RemoveAt(0); // elimina a mazy con todo y espacio de la lista antes
            AntesPuente.RemoveAt(0); // elimina a daisy de la lista antes del puetne
            Console.Clear(); // Borra consola
            ImprimirAmbosLados(); // Imprime ambos lados del puente y el puente
            Operacion1(); // Imrpime todas la soperaciones asi como resultado al final de la operacion 5
            Operacion2();
            Operacion3();
            Operacion4();
            Operacion5();
        }
        public void Operacion5() // Imprime el paso 5 y el resultado de todas las vueltas que es igual a 34
        {
            Console.SetCursorPosition(50, 6);
            Console.WriteLine("Cruzan: Mazy (2min) + Daisy (4min) = 4 min\n");
            Console.SetCursorPosition(50, 7);
            Console.WriteLine("Tiempo total:                       34 min");
        }
        public void MetodoX() // Un simple metodo que sirve para que el usuario ingrese cualquier tecla y el programa siga corriendo
        {
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("Presione para ver el siguiente paso...");
            Console.ReadKey();
        }
        public void MainMenu() // PAra np tener nada en el main creamo un mini menu donde vamos llamando cada uno de los metodos
        {
            AgregarDatos();
            Inicio();
            AntesCruzarPuente();
            MetodoX();
            Paso1();
            MetodoX();
            Paso2();
            MetodoX();
            Paso3();
            MetodoX();
            Paso4();
            MetodoX();
            Paso5();
            Console.SetCursorPosition(30,15);
            Console.WriteLine("Fin del Acertijo"); // FIN DEL ACERTIJO
            Console.ReadKey();
        }
    }
}
