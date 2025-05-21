using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDeLibros
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Persona persona = new Persona("Marlon");
            Persona pablo = new Persona("Pablo"); 
            Console.WriteLine("el nombre de la persona es" + pablo.Nombre); 
        }
    }
}
