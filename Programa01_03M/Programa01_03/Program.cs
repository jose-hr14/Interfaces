using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_03M
{
    //Calculadora en consola, con dos textBox, que detrás tienen A: B: para cada numero
    //Un botón para cada operacion, +, -, *, /
    //Controlar la división entre 0 con un label
    //Si falta un numero, un label que avise que no se han escrito numeros válidos, con las letras igual
    //Filtramos division por cero, o que metemos letras
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

        }
    }
}
