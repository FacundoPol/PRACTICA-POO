using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pedido p1 = new Pedido();

            Console.Write("Ingrese su nombre: ");
            p1.NombreCliente = Console.ReadLine();

            Console.Write("Ingrese el nombre del producto: ");
            p1.NombreProducto = Console.ReadLine();

            Console.Write("Ingrese su direccion: ");
            p1.DireccionCliente = Console.ReadLine();

            p1.PrecioP = 9.99;

            Ticket t1 = new Ticket(p1);
            Console.WriteLine(t1.ImprimirDatos());

            Console.ReadKey();
        }
    }
}
