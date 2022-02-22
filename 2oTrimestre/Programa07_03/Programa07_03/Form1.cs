using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //StreamReader sr = new StreamReader(".\\DirListaPer\\FiListaPer.txt");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if(!listaPersonas.Exists(p => p.DNI == txbDNI.Text))
            {
                Persona persona;
                if (int.TryParse(txbEdad.Text, out int edadNum))
                {
                    persona = new Persona(txbDNI.Text, txbNombre.Text, txbApellido1.Text, txbApellido2.Text, edadNum);
                }                
                else
                {
                    persona = new Persona(txbDNI.Text, txbNombre.Text, txbApellido1.Text, txbApellido2.Text, 0);
                }
                listaPersonas.Add(persona);
                listaPersonas = listaPersonas.OrderBy(p => p.DNI).ToList();
                dataGridView.DataSource = null;
                dataGridView.DataSource = listaPersonas;

                txbDNI.Clear();
                txbNombre.Clear();
                txbApellido1.Clear();
                txbApellido2.Clear();
                txbEdad.Clear();

                txbDNI.Focus();
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
                listaPersonas.Reverse();
                dataGridView.DataSource = null;
                dataGridView.DataSource = listaPersonas;
            }
            txbDNI.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(listaPersonas.Exists(p => p.DNI == txbDNIBuscar.Text))
            {
                int index = listaPersonas.FindIndex(p => p.DNI == txbDNIBuscar.Text);
                dataGridView.ClearSelection();
                dataGridView.Rows[index].Cells[0].Selected = true;

                txbDNI.Text = dataGridView.Rows[index].Cells[0].Value.ToString();
                txbNombre.Text = dataGridView.Rows[index].Cells[1].Value.ToString();
                txbApellido1.Text = dataGridView.Rows[index].Cells[2].Value.ToString();
                txbApellido2.Text = dataGridView.Rows[index].Cells[3].Value.ToString();
                txbEdad.Text = dataGridView.Rows[index].Cells[4].Value.ToString();

                txbDNI.Focus();
            }            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listaPersonas.Exists(p => p.DNI == txbDNIBuscar.Text))
            {
                int index = listaPersonas.FindIndex(p => p.DNI == txbDNIBuscar.Text);
                Persona persona = listaPersonas[index];
                if (int.TryParse(txbEdad.Text, out int edadNum))
                {
                    persona.Edad = edadNum;
                }
                else
                {
                    persona.Edad = 0;
                }
                persona.DNI = txbDNI.Text;
                persona.Nombre = txbNombre.Text;
                persona.Apellido1 = txbApellido1.Text;
                persona.Apellido2 = txbApellido2.Text;

                listaPersonas = listaPersonas.OrderBy(p => p.DNI).ToList();
                dataGridView.DataSource = null;
                dataGridView.DataSource = listaPersonas;

                txbDNI.Clear();
                txbNombre.Clear();
                txbApellido1.Clear();
                txbApellido2.Clear();
                txbEdad.Clear();

                txbDNI.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listaPersonas.Exists(p => p.DNI == txbDNIBuscar.Text))
            {
                int index = listaPersonas.FindIndex(p => p.DNI == txbDNIBuscar.Text);
                listaPersonas.RemoveAt(index);
                listaPersonas = listaPersonas.OrderBy(p => p.DNI).ToList();
                dataGridView.DataSource = null;
                dataGridView.DataSource = listaPersonas;


                txbDNI.Clear();
                txbNombre.Clear();
                txbApellido1.Clear();
                txbApellido2.Clear();
                txbEdad.Clear();

                txbDNI.Focus();
            }
        }
    }
}
