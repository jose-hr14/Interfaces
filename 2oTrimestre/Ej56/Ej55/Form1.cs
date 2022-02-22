using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ej55
{
    public partial class Form1 : Form
    {
        List<ClaseNombre> lista;
        public Form1()
        {
            InitializeComponent();

            lista = new List<ClaseNombre>();
            lista.Add(new ClaseNombre("uno"));
            lista.Add(new ClaseNombre("dos"));
            lista.Add(new ClaseNombre("tres"));           
            dgvNumeros.DataSource = null;
            dgvNumeros.DataSource = lista;
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
                lista.Add(new ClaseNombre(txbNuevoNombre.Text));
                dgvNumeros.DataSource = null;
                dgvNumeros.DataSource = lista;
            }            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //int indice = lista.FindIndex(nombre => nombre.Nombre == txbNombreProcesar.Text);
            int indice = lista.FindIndex(nombre => nombre.Nombre.Contains(txbNombreProcesar.Text));
            if (indice > -1)
            {
                lista[indice] = new ClaseNombre(txbNuevoNombre.Text);                
                dgvNumeros.DataSource = null;
                dgvNumeros.DataSource = lista;
            }
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int indice = lista.FindIndex(nombre => nombre.Nombre == txbNombreProcesar.Text);
            if (indice > -1)
            {
                lista.RemoveAt(indice);                
                dgvNumeros.DataSource = null;
                dgvNumeros.DataSource = lista;
            }
        }
        public class ClaseNombre
        {
            string nombre;

            public ClaseNombre(string nombre)
            {
                this.nombre = nombre;
            }

            public string Nombre
            {
                get
                {
                    return nombre;
                }
                set
                {
                    nombre = value;
                }
            }
        }
    }
}
