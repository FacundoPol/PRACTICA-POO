using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace gestor_de_tareas
{
    internal class Tareas:AdminTareas
    {
        public int NumeroTarea { get; set; }
        public DateTime FechaCrea { get; set; }
        public string Nombre { get; set; }
        public bool Hecho { get; set; }

    }
}
