using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE._3_Jose_Gerardo_Ramirez
{
   public class Operaciones
    {
        List<Tarea> Pendientes = new List<Tarea>(); // Crea la lista de tipo tareas de tareas pendientes
        List<Tarea> Terminadas = new List<Tarea>(); // Crea la lsta de tipo Tareas de terminadas
        List<Tarea> Proceso = new List<Tarea>(); // crea la lista de tipo tareas de nombre proceso

        public void Ver_Tareas() // Despliega la opcion de ver tareas con un  menu 
        {
        VerTareas:// Etiqueta para regresar 
            Console.Clear(); // Borra la pantalla
            Console.WriteLine("Seleccione la lista que desea desplegar: \n");
            Console.WriteLine("1. Todas las tareas");
            Console.WriteLine("2. Tareas Pendientes");
            Console.WriteLine("3. Tareas en Proceso");
            Console.WriteLine("4. Tareas Terminadas");
            Console.WriteLine("5. Volver al Menu");
            string Seleccion = Console.ReadLine().ToUpper(); // Lee el valor ingresado y lo hace MAYUSCULAS
            if (Seleccion == "1" || Seleccion == "TODAS LAS TAREAS" || Seleccion == "1. TODAS LAS TAREAS") // si Seleccion es igual al alguna de esas opciones despliega todas las tareas
            {
                Console.Clear();
                Console.WriteLine("ID/Nombre/Descripcion/Fecha Inicio/Status/Fecha Fin/Descripcion del status");
                foreach (var item in Pendientes)
                {
                    Console.WriteLine(item.ID + "/ " + item.Nombre + "/ " + item.Descripcion + "/ " + item.FechaInicio);
                }
                foreach (var item in Proceso)
                {
                    Console.WriteLine(item.ID + "/ " + item.Nombre + "/ " + item.Descripcion + "/ " + item.FechaInicio + "/ " + item.Status+"/ Aun no se termina /" + item.DescricionStatus);
                }
                foreach (var item in Terminadas)
                {
                    Console.WriteLine(item.ID + "/ " + item.Nombre + "/ " + item.Descripcion + "/ " + item.FechaInicio + "/ " + item.Status + "/ "+item.FechaFin + "/ " + item.DescricionStatus);
                }
                Console.WriteLine("\nPresione cualquier tecla para salir...");
                Console.ReadKey();
                goto VerTareas; // regresa a la etiqueta
            }
            else if (Seleccion == "2" || Seleccion == "TAREAS PENDIENTES" || Seleccion == "2. TAREAS PENDIENTES") // si Seleccion es igual al alguna de esas opciones despliega las tareas pendientes
            {
                Console.Clear();
                Console.WriteLine("ID/Nombre/Descripcion/Fecha Inicio/Fecha Fin/Status");
                foreach (var item in Pendientes)
                {
                    Console.WriteLine(item.ID + "/ " + item.Nombre + "/ " + item.Descripcion + "/ " + item.FechaInicio);
                }
                Console.WriteLine("\nPresione cualquier tecla para salir...");
                Console.ReadKey();
                goto VerTareas; // regresa a la etiqueta
            }
            else if (Seleccion == "3" || Seleccion == "TAREAS EN PROCESO" || Seleccion == "3. TAREAS EN PROCESO") // si Seleccion es igual al alguna de esas opciones despliega tareas en proceso
            {
                Console.Clear();
                Console.WriteLine("ID/Nombre/Descripcion/Fecha Inicio/Fecha Fin/Status/Descripcion del status");
                foreach (var item in Proceso)
                {
                    Console.WriteLine(item.ID + "/ " + item.Nombre + "/ " + item.Descripcion + "/ " + item.FechaInicio + "/ " + item.FechaFin + "/ " + item.Status + "/ " + item.DescricionStatus);
                }
                Console.WriteLine("\nPresione cualquier tecla para salir...");
                Console.ReadKey();
                goto VerTareas; // Regresa a la etiqueta
            }
            else if (Seleccion == "4" || Seleccion == "TAREAS TERMINADAS" || Seleccion == "4. TAREAS TERMINADAS") // Si seleccion es igual a alguna de esas opciones imprime las tareas terminadas
            {
                Console.Clear();
                Console.WriteLine("ID/Nombre/Descripcion/Fecha Inicio/Status/Fecha Fin/Descripcion del status");
                foreach (var item in Terminadas)
                {
                    Console.WriteLine(item.ID + "/ " + item.Nombre + "/ " + item.Descripcion + "/ " + item.FechaInicio + "/ " + item.Status + "/ " + item.FechaFin + "/ " + item.DescricionStatus);
                }
                Console.WriteLine("\nPresione cualquier tecla para salir...");
                Console.ReadKey();
                goto VerTareas; // Regresa a la etiqueta
            }
            else if (Seleccion == "5" || Seleccion == "VOLVER AL MENU" || Seleccion == "5. VOLVER AL MENU") // Si es igual a alguna de esas opciones
            {
                MainMenu(); // Manda llamar el metodo menu que es como si regresara
            }
            else // Si no es ninguna de las anteriores
            {
                Console.WriteLine("Introduzca una opcion valida.");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                goto VerTareas; // Regresa a ver tareas
            }

        }

        public void AgregarTarea() // Agrega valores a los atributos de una tarea
        {
            Tarea Tarea = new Tarea(); // Crea el objeto
            Random papa = new Random(); // Crea una variable Random
            int Variable = papa.Next(0, 9), Variable1 = papa.Next(0, 9), Variable2 = papa.Next(0, 9); // crea 3 Variables enteras Random del (0,9)
            Console.Write("Introduce el numero de tarea: ");
            Tarea.ID = Variable.ToString() + Variable1.ToString() + Variable2.ToString() + Console.ReadLine(); // Se le asigna las 3 variables random + su numero de tarea y ese es su ID
            Console.Write("Introduce el nombre de la tarea: ");
            Tarea.Nombre = Console.ReadLine();
            Console.Write("Introduce la descripcion de la tarea: ");
            Tarea.Descripcion = Console.ReadLine();
            Console.Write("Introduce la fecha de inicio de la tarea: ");
            Tarea.FechaInicio = Console.ReadLine();
            Pendientes.Add(Tarea); // Se agrega la tarea con los atributos ingresados a la Lista de Pendientes
            Console.WriteLine("Se ha agregado su tarea.");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }



        public void MenuEditarStatus() // Sirve para editar el status de la tarea
        {

        Ver:
            Console.Clear();
            Console.WriteLine("Seleccione la lista de la tarea que desea editar: "); //Este es un menu para apoyo
            Console.WriteLine("1. Tareas Pendientes");
            Console.WriteLine("2. Tareas en Proceso");
            Console.WriteLine("3. Tareas Terminadas");
            Console.WriteLine("4. Volver al Menu");
            string Seleccion = Console.ReadLine().ToUpper(); // Hace el string leido en mayusculas
            if (Seleccion == "1" || Seleccion == "TAREAS PENDIENTES" || Seleccion == "1. TAREAS PENDIENTES") // si seleccion es igual a alguno de eso
            {
            Pendientes:
                Console.Clear();
                Console.WriteLine(" ID     Nombre");
                foreach (var item in Pendientes)// Imprime las tareas que tiene la lista de pendientes
                {
                    Console.WriteLine(item.ID + "  " + item.Nombre);
                }
                
                Console.WriteLine("\nIntroduzca el ID de la tarea que desea editar: ");//Despliega otro menu
                string Editor = Console.ReadLine();
                int Contador = -1; // Inicia el contador en -1 para poder comparar la posicion 0

                foreach (var item in Pendientes)
                {
                    Contador++; // contador se le agrega 1
                    if (Editor == item.ID) // Si EDitor (ID) es igual al ID
                    {
                    Fak:
                        Console.Clear(); // Borra la consola
                        Console.WriteLine("Introduzca el Status de la Tarea (Proceso / Terminado): ");
                        string Determina = Console.ReadLine().ToUpper();//Guarda la variable determina para compararla con el status que desea y la hace mayusculas
                        if (Determina == "PROCESO") // Si determina es igual a PROCESO hace lo siguiente
                        {
                            item.Status = "Proceso"; // Cambia el status del objeto a Proceso
                            Console.WriteLine("Introduce una descripcion del status:"); // Pide agregar una descrpcion
                            item.DescricionStatus = Console.ReadLine();  // guarda la descripcion en el  atributo descrpcionstatus del objeto
                            Proceso.Add(item); // Agrega el objeto a la lista de proceso
                            Pendientes.RemoveAt(Contador); // y remueve el ligar del contador en la lista de pendientes que es la misma la que agregamos a la lista pendientes
                            Console.WriteLine("Presione una tecla para volver al menu...");
                            Console.ReadKey();
                            goto Ver;
                        }
                        else if (Determina == "TERMINADO") // Si determina es igual a TERMINADO
                        {
                            item.Status = "Terminado"; // El status cambia a terminado
                            Console.Write("Introduce la fecha que terminaste el trabajo: "); // Pregunta la fecha que termino el trabajo
                            item.FechaFin = Console.ReadLine(); // Lo guarda en el atributo fecha fin del objeto
                            Console.WriteLine("Introduce una descripcion del status:"); // Pregunta la decrpcion del status en este caso que termino el trabajo
                            item.DescricionStatus = Console.ReadLine();
                            Terminadas.Add(item); // Guarda el objeto de la lista de termiandas
                            Pendientes.RemoveAt(Contador); // REmueve el objeto situado en la posiciom contador que es el mismo que agregamos a la otra lista
                            Console.WriteLine("Presione una tecla para volver al menu...");
                            Console.ReadKey();
                            goto Ver;
                        }
                        else
                        {
                            Console.WriteLine("Introduzca una opcion valida.");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                            goto Fak;
                        }

                    }
                }
                Console.Clear();
                Console.WriteLine("EL ID QUE INTRODUJO NO SE ENCUENTRA EN LA LISTA\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                goto Pendientes;
            }
            else if (Seleccion == "2" || Seleccion == "TAREAS EN PROCESO" || Seleccion == "2. TAREAS EN PROCESO") //Si del menu selecciona alguna de estas opciones
            {
            Proceso:
                Console.Clear();// Borra la pantall            
                Console.WriteLine(" ID     Nombre"); // Hace una tipo tabla 
                foreach (var item in Proceso) //imprime todos los elementos de la lista proceso
                {
                    Console.WriteLine(item.ID + "  " + item.Nombre);
                } 
                
                Console.WriteLine("\nIntroduzca el ID de la tarea que desea editar: ");
                string Editor = Console.ReadLine(); // Guarda el Id introducido
                int Contador = -1;
            
                foreach (var item in Proceso) // comparar el id introducido con todos los que estan en la lista proceso
                {
                    Contador++;
                    if (Editor == item.ID) // Si editor es igual a algun id que este en la lista proceso
                    {
                        item.Status = "Terminado"; // agrega termindo al status del objeto
                        Console.Write("Introduce la fecha que terminaste el trabajo: "); // pide fecha en que se termmino el trabajo
                        item.FechaFin = Console.ReadLine(); //  guarda en el atributo fecha fin
                        Console.WriteLine("Introduce una descripcion del status:");
                        item.DescricionStatus = Console.ReadLine();
                        Terminadas.Add(item); // agrega el objeto a la lista de terminas
                        Proceso.RemoveAt(Contador); // remueve ese objeto de la lista proceso con ayuda del contador
                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        goto Ver;
                    }
                
                }
                Console.Clear();
                Console.WriteLine("EL ID QUE INTRODUJO NO SE ENCUENTRA EN LA LISTA\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                goto Proceso;
            }
            
            else if (Seleccion == "3" || Seleccion == "TAREAS TERMINADAS" || Seleccion == "3. TAREAS TERMINADAS") // Si introduce lguna de esas opciones
            {
                Terminadas:
                Console.Clear(); // Borra la pantalla
                Console.WriteLine(" ID     Nombre");// Introduce la parte de arriba de la tabla
                foreach (var item in Terminadas) // Imprime los objetos de la lista terminadas
                {
                    Console.WriteLine(item.ID + "  " + item.Nombre);
                }
                Console.WriteLine("\nIntroduzca el ID de la tarea que desea editar: "); // Introduce ID
                string Editor = Console.ReadLine();//Lo pone en el editor
                int Contador = -1;
           
                foreach (var item in Terminadas) // Compara los id con todos los de la lista terminadas
                {
                    Contador++;
                    if (Editor == item.ID) // Si alguno coincide
                    {
                        item.Status = "Proceso"; // Le cambia el status a proceso
                        item.FechaFin = " ";
                        Console.WriteLine("Introduce una descripcion del status:"); // Introduce descriocion
                        item.DescricionStatus = Console.ReadLine(); // Lo guarda
                        Proceso.Add(item); // Agrega el objeto a la lista de proceso
                        Terminadas.RemoveAt(Contador); // Lo remueve de la lista terminadas
                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        goto Ver;
                    }
                }
                Console.Clear();
                Console.WriteLine("EL ID QUE INTRODUJO NO SE ENCUENTRA EN LA LISTA\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                goto Terminadas;
            }
            else if (Seleccion == "4" || Seleccion == "VOLVER AL MENU" || Seleccion == "4. VOLVER AL MENU") // si selecciona volver al menu
            {
                MainMenu(); // MAnda llamar el metodo mainmenu
            }
        }
        public void MainMenu() // EL MainMenu despliega un menu donde seleccionas la opcion y te manda a ese metodo
        {   
        Inicio:
            Console.Clear(); // Borra la pantalla
            Console.WriteLine("Bienvenido al la Agenda de Tareas: \n");
            Console.WriteLine("1. Ver Tareas");
            Console.WriteLine("2. Agregar Tareas");
            Console.WriteLine("3. Editar Status");
            Console.WriteLine("4. Salir");
            string Menu = Console.ReadLine().ToUpper();
            if (Menu == "1" || Menu == "VER TAREAS") // Si quiere ver tareas
            {
                Ver_Tareas();// manda llamar el metodo ver tareaas
            }
            else if (Menu == "2" || Menu == "AGREGAR TAREAS") // Si selecciona agregar tareas
            {
                Console.Clear();// Borra la pantalla
                AgregarTarea(); // haceel metodo agregar tarea
                goto Inicio;// te regresa al menu
            }
            else if (Menu == "3" || Menu == "EDITAR STATUS") // Si quiere editar el status
            {
                MenuEditarStatus(); // Te manda al menu editr status el metodo
            }
 
            else if (Menu == "4" || Menu == "SALIR")// Si selecciona salir
            {
                Console.ReadKey();// Termina el programa
            }
            else // Si introduce un valor diferente a eos
            {
                Console.WriteLine("Introduzca una opcion valida.");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                goto Inicio;// Regresa al inicio del menu
            }
        }
    }
}
