using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_tareas
{
    internal class AdminTareas
    {
        public List<Tareas> ListaTareas = new List<Tareas>();
        public void AgregarT(Tareas t, string n, int i)
        {
            t.Nombre = n;
            t.FechaCrea = DateTime.Now;
            t.NumeroTarea = i + 1;
            t.Hecho = false;
            ListaTareas.Add(t);
        }

        public void BorrarT(int f)
        {
            int h = 0;
            while (ListaTareas[h].NumeroTarea != f)
            {
                h++;
            }
            Tareas bt = ListaTareas[h];
            ListaTareas.Remove(bt);
        }
        public void TerminadaT(int g)
        {
            int h = 0;
            while (ListaTareas[h].NumeroTarea != g)
            {
                h++;
            }
            ListaTareas[h].Hecho = true;
        }
        public void MostrarT()
        {
            for (int k = 0; k < ListaTareas.Count; k++)
            {
                Console.WriteLine();
                Console.WriteLine("Tarea: " + ListaTareas[k].Nombre);
                Console.WriteLine("Fecha: " + ListaTareas[k].FechaCrea);
                Console.WriteLine("Numero Tarea: " + ListaTareas[k].NumeroTarea);
                if (ListaTareas[k].Hecho == true)
                {
                    Console.WriteLine("Tarea Terminada");
                }
                else
                {
                    Console.WriteLine("Tarea NO Terminada ");
                }
                
            }
        }
    }
}
