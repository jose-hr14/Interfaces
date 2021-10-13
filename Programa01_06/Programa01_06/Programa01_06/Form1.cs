using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //crear objeto de la clase dialog result
            DialogResult dialogResult = new DialogResult("Texto", "Titulo ventana", "botones que queremos", );
            //Ventana modal, no deba volver hasta que hayamos operado
            //Una ventana´no modal dejaría cerrar y volver
        }
    }
}
