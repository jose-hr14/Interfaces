using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ej54
{
    public partial class Form1 : Form
    {
        List<string> lista = new List<string>();
        public Form1()
        {
            InitializeComponent();
            lista.Add("uno");
            lista.Add("dos");
            lista.Add("tres");
            listBox1.DataSource = null;
            listBox1.DataSource = lista;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lista.Add(txbNuevoNombre.Text);
            listBox1.DataSource = null;
            listBox1.DataSource = lista;
            txbNuevoNombre.Text = "";
            txbNombreProcesar.Text = "";
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(lista.Count > 0)
            {
                lista.RemoveAt(lista.IndexOf(txbNombreProcesar.Text));
                listBox1.DataSource = null;
                listBox1.DataSource = lista;
                txbNuevoNombre.Text = "";
                txbNombreProcesar.Text = "";
            }            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string palabra = txbNombreProcesar.Text;
            //for(int i = 0; i < lista.Count; i++)
            //{
            //    if (txbNombreProcesar.Text == lista[i])
            //    {
            //        lista[i] = txbNuevoNombre.Text;
            //        lista.RemoveAt(i);
            //        lista.Insert(i, txbNuevoNombre.Text);
            //    }              
            //}            
            //foreach(String elemento in lista)
            //{
            //    if(elemento == txbNombreProcesar.Text)
            //    {
            //        lista[lista.IndexOf(elemento)] = txbNuevoNombre.Text;
            //        break;
            //    }
            //}

            //int indice = -1;
            //foreach (String elemento in lista)
            //{
            //    indice++;
            //    if(elemento == txbNombreProcesar.Text)
            //    {
            //        lista.RemoveAt(indice);
            //        lista.Insert(indice, txbNuevoNombre.Text);
            //        break;
            //    }
            //}
            //el return sale del if, y el break rompe el buce
            //lista[lista.IndexOf(txbNombreProcesar.Text)] = txbNuevoNombre.Text;
            int indice = lista.FindIndex(nombre => nombre.Contains(txbNombreProcesar.Text));
            lista[indice] = txbNuevoNombre.Text;

            listBox1.DataSource = null;
            listBox1.DataSource = lista;
            txbNuevoNombre.Text = "";
            txbNombreProcesar.Text = "";
        }
    }
}
