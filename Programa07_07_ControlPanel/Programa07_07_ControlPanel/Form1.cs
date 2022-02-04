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
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void btnFormularioPrincipal1_Click(object sender, EventArgs e)
        {
            //panel1.Dock = DockStyle.None;
            //panel2.Dock = DockStyle.None;
            //lblFormularioPrincipal.Show();
            //btnIrPrimerPanel.Show();
            //btnIrSegundoPanel1.Show();
            panel1.Visible = false;
            panel2.Visible = false;

        }

        private void btnIrSegundoPanel_Click(object sender, EventArgs e)
        {
            //panel1.Dock = DockStyle.None;
            //panel2.Visible = true;
            //this.Dock = DockStyle.None;
            //lblFormularioPrincipal.Hide();
            //btnIrPrimerPanel.Hide();
            //btnIrSegundoPanel1.Hide();
            panel1.Visible = true;
            panel2.Visible = true;

        }

        private void btnIrPrimerPanel2_Click(object sender, EventArgs e)
        {
            //panel1.Dock = DockStyle.Fill;
            //panel2.Dock = DockStyle.None;
            //this.Dock = DockStyle.None;
            //lblFormularioPrincipal.Hide();
            //btnIrPrimerPanel.Hide();
            //btnIrSegundoPanel1.Hide();
            panel1.Visible = true;
          
        }
    }
}
