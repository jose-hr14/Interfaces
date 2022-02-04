using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa07_07_PanelesBueno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void btnIrPrimerPanel1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void btnIrSegundoPanel1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void btnIrFormularioPrincipal2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void btnIrSegundoPanel2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void btnIrPrimerPanel3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void btnIrFormularioPrincipal3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }
    }
}
