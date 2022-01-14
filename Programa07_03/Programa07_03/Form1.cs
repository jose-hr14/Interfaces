using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa07_03
{
    public partial class Form1 : Form
    {
        List<Persona> listaPersonas;
        public Form1()
        {
            InitializeComponent();
            listaPersonas = new List<Persona>();
            dataGridView.DataSource = null;
            dataGridView.DataSource = listaPersonas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(txbDNI.Text, txbNombre.Text, txbApellido1.Text, txbApellido2.Text, Convert.ToInt32(txbEdad.Text));
            if(!listaPersonas.Exists(p => p.DNI == txbDNI.Text))
            {
                listaPersonas.Add(persona);
                listaPersonas = listaPersonas.OrderBy(p => p.DNI).ToList();
                dataGridView.DataSource = null;
                dataGridView.DataSource = listaPersonas;
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if(radioDNI.Checked == true)
            {
                listaPersonas = listaPersonas.OrderBy(p => p.DNI).ToList();
                dataGridView.DataSource = null;
                dataGridView.DataSource = listaPersonas;
            }
            if (radioNombre.Checked == true)
            {
                listaPersonas = listaPersonas.OrderBy(p => p.Nombre).ToList();
                dataGridView.DataSource = null;
                dataGridView.DataSource = listaPersonas;
            }
            if (radioApellido1.Checked == true)
            {
                listaPersonas = listaPersonas.OrderBy(p => p.Apellido1).ToList();
                dataGridView.DataSource = null;
                dataGridView.DataSource = listaPersonas;
            }
            if (radioApellido2.Checked == true)
            {
                listaPersonas = listaPersonas.OrderBy(p => p.Apellido2).ToList();
                dataGridView.DataSource = null;
                dataGridView.DataSource = listaPersonas;
            }
            if (radioEdad.Checked == true)
            {
                listaPersonas = listaPersonas.OrderBy(p => p.Edad).ToList();
                dataGridView.DataSource = null;
                dataGridView.DataSource = listaPersonas;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int index = listaPersonas.FindIndex(p => p.DNI == txbDNIBuscar.Text);
            dataGridView.ClearSelection();
            dataGridView.Rows[index].Cells[0].Selected = true;

        }
    }
}
