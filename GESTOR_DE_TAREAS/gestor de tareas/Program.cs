using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace gestor_de_tareas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salida = true;
            int i = 0;
            AdminTareas Adt = new AdminTareas();
            do
            {
                Console.WriteLine("--- OPCIONES ---");
                Console.WriteLine("-- |1| AGREGAR --");
                Console.WriteLine("-- |2| MARCAR COMO TERMINADA --");
                Console.WriteLine("-- |3| BORRAR --");
                Console.WriteLine("-- |4| MOSTRAR --");
                Console.WriteLine("-- |5| SALIR --");
                Console.Write(" --* INGRESE SU OPCION: ");
                int op = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (op)
                {
                    case 1:
                        Console.Write("Ingrese el nombre de la tarea: ");
                        string n = Console.ReadLine();
                        Tareas t = new Tareas();
                        Adt.AgregarT(t,n,i);
                        i++;
                        break;
                    case 2:
                        Console.Write("Ingrese el numero de la tarea que desea marcar como terminada: ");
                        int g = int.Parse(Console.ReadLine());
                        Adt.TerminadaT(g);
                        break;
                    case 3:
                        Console.Write("Ingrese el numero de la tarea que desea borrar: ");
                        int f = int.Parse(Console.ReadLine());
                        Adt.BorrarT(f);
                        break;
                    case 4:
                        Adt.MostrarT();
                        break;
                    case 5:
                        salida = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (salida == true);
        }
    }
}
