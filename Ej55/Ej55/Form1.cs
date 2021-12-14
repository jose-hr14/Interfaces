using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej55
{
    public partial class Form1 : Form
    {
        List<string> lista;
        public Form1()
        {
            InitializeComponent();

            lista = new List<string>();
            lista.Add("uno");
            lista.Add("dos");
            lista.Add("tres");
            var nuevaLista = lista.Select(nombre => new { Nombre = nombre }).ToList();
            dgvNumeros.DataSource = null;
            dgvNumeros.DataSource = nuevaLista;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*
             * chars int32
             * length
             * lista con grid view solo conecta la longitud de los strings
             * podemos encapsular el string en una clase usando lambda
             */
            if(txbNuevoNombre.Text.Length > 0)
            {
                lista.Add(txbNuevoNombre.Text);
                var nuevaLista = lista.Select(nombre => new { Nombre = nombre }).ToList();
                dgvNumeros.DataSource = null;
                dgvNumeros.DataSource = nuevaLista;
            }            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = lista.IndexOf(txbNombreProcesar.Text);
            if(indice > -1)
            {
                lista[indice] = txbNuevoNombre.Text;
                var nuevaLista = lista.Select(nombre => new { Nombre = nombre }).ToList();
                dgvNumeros.DataSource = null;
                dgvNumeros.DataSource = nuevaLista;
            }
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int indice = lista.IndexOf(txbNombreProcesar.Text);
            if (indice > -1)
            {
                lista.RemoveAt(indice);
                var nuevaLista = lista.Select(nombre => new { Nombre = nombre }).ToList();
                dgvNumeros.DataSource = null;
                dgvNumeros.DataSource = nuevaLista;
            }
        }
    }
}
