using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa07_07_ControlPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFormularioPrincipal1_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.None;
        }

        private void btnIrSegundoPanel_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.None;
            panel2.Dock = DockStyle.Fill;
        }
    }
}
