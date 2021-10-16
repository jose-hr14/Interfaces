using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMonitor.Text = "";
            lblTeclado.Text = "";
            lblRaton.Text = "";            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (chkMonitor.Checked)
                total += 250;
            if (chkTeclado.Checked)
                total += 15;
            if (chkRaton.Checked)
                total += 20;
            
            MessageBox.Show("El precio total es " + total);            
        }

        private void chkMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonitor.Checked)
                lblMonitor.Text = "Monitor";
            else
                lblMonitor.Text = "";
        }

        private void chkTeclado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTeclado.Checked)
                lblTeclado.Text = "Teclado";
            else
                lblTeclado.Text = "";
        }

        private void chkRaton_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRaton.Checked)
                lblRaton.Text = "Ratón";
            else
                lblRaton.Text = "";
        }
    }
}
