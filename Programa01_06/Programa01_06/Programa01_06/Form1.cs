using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblBoton.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //crear objeto de la clase dialog result
            //anular reintentar omitir
            //DialogResult dialogResult = new DialogResult("Texto", "Titulo ventana", "botones que queremos", );            
            //Ventana modal, no deba volver hasta que hayamos operado
            //Una ventana´no modal dejaría cerrar y volver

            MessageBoxButtons messageBoxButtons = MessageBoxButtons.AbortRetryIgnore;
            
            DialogResult dialogResult = MessageBox.Show("Mi texto de mensaje", "Mi titulo de ventana", messageBoxButtons);
            if (dialogResult == DialogResult.Abort)
            {
                lblBoton.Text = "Anular";
            }
            else if(dialogResult == DialogResult.Retry)
            {
                lblBoton.Text = "Reintentar";
            }
            else if(dialogResult == DialogResult.Ignore)
            {
                lblBoton.Text = "Ignorar";
            }

        }
    }
}
