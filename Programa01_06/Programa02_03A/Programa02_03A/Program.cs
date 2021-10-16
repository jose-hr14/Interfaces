using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_03A
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
            //dos cuadros de texto, le das al boton enviar y lo manda al segundo formulario y lo pone en dos label
            //para el paso de variables dos formas
            //una seria con propiedades, y otra cuando llamamos al constructor, pasarle como parámetros lo que queremos
            //para la primera, A, para la segunda, B
        }
    }
}
