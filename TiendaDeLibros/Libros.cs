using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TiendaDeLibros
{
    class Libros
    {

        private string nombre, ISBN; private int precioCompra, precioVenta , cantidadActual; // 
        public Libros(string nombre, string ISBN, int precioCompra, int precioVenta , int cantidadActual)
        {
            this.Nombre = nombre;
            this.ISBN = ISBN;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
            this.cantidadActual = cantidadActual; 
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string ID1 { get => ISBN; set => ISBN = value; }
        public int PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public int PrecioVenta { get => precioVenta; set => precioVenta = value; }
    }
}
