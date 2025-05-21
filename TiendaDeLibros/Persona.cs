using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDeLibros
{
    internal class Persona
    {
        private string nombre;
        private string Rol; //no sé si sea necesario. 


        public Persona(string nombre)
        {
            this.Nombre = nombre; 
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
