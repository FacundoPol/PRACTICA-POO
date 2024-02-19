using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Pedido
    {
        public string NombreCliente { get; set; }

        public string NombreProducto { get; set; }

        public string DireccionCliente { get; set; }

        private double PrecioProducto;

        public double PrecioP
        {
            get { return PrecioProducto; }
            set { PrecioProducto = value; }
        }

        public DateTime FechaCompra { get; set; }
    }
}
