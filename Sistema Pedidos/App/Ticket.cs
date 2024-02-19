using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Ticket
    {
        private Pedido pedidos;

        public Ticket(Pedido pedidoss)
        {
            this.pedidos = pedidoss;
        }

        public string ImprimirDatos()
        {
            return $"El nombre del cliente: {pedidos.NombreCliente}, Direccion: {pedidos.DireccionCliente}" +
                $"Nombre del producto: {pedidos.NombreProducto}, Costo: {pedidos.PrecioP} Fecha de Compra: " +
                $"{pedidos.FechaCompra=DateTime.Now}";
        }
    }
}
