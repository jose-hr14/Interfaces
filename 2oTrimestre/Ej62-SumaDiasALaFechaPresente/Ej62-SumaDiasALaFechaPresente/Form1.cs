using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej62_SumaDiasALaFechaPresente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblFechaResultado.Text = dptCalendario.Value.ToLongDateString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = dptCalendario.Value.AddDays(Convert.ToDouble(txbIntroducirFecha.Text));
                dptCalendario.Value = fecha;
                lblFechaResultado.Text = fecha.ToLongDateString();
            }
            catch(System.FormatException)
            {
                lblFechaResultado.Text = "No se ha introducido un número";
            }          
        }

        private void dptCalendario_ValueChanged(object sender, EventArgs e)
        {
            lblFechaResultado.Text = dptCalendario.Value.ToLongDateString();
        }
    }
}
