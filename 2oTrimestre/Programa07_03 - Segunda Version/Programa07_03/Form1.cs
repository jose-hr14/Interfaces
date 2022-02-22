using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if(ExisteDirectorio())
            {
                if(ExisteFichero())
                {
                    listaPersonas = LeerListaPersonas();
                }
                else
                {
                    File.Create("..\\..\\..\\DirListaPersonas\\FiListaPersonas.txt").Close();
                    listaPersonas = new List<Persona>();
                }
            }
            else
            {
                Directory.CreateDirectory("..\\..\\..\\DirListaPersonas");
                File.Create("..\\..\\..\\DirListaPersonas\\FiListaPersonas.txt").Close();
                listaPersonas = new List<Persona>();
            }            
            dataGridView.DataSource = null;
            dataGridView.DataSource = listaPersonas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if(!listaPersonas.Exists(p => p.DNI == txbDNI.Text))
            {
                if(txbDNI.Text != "" && txbNombre.Text != "" && lblApellido1.Text != "" && txbApellido2.Text != "" &&
                    txbEdad.Text != "")
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
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if(radioDNI.Checked == true)
            {
                listaPersonas = listaPersonas.OrderBy(p => p.DNI).ToList();
                //listaPersonas = listaPersonas.OrderByDescending(p => p.DNI).ToList();
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
                listaPersonas = listaPersonas.OrderBy(p => p.Apellido1).ThenBy(p => p.Apellido1).ToList();
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
        //Procedimiento para leer y escribir en fichero
        //File.AppendAllText(rutaFichero, campos)
        private bool ExisteFichero()
        {
            if (File.Exists("..\\..\\..\\DirListaPersonas\\FiListaPersonas.txt"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ExisteDirectorio()
        {
            if(Directory.Exists("..\\..\\..\\DirListaPersonas"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void GuardarPersonasEnFichero(List<Persona> listaPersonas)
        {
            File.WriteAllText("..\\..\\..\\DirListaPersonas\\FiListaPersonas.txt", "");
            foreach (Persona persona in listaPersonas)
            {
                File.AppendAllText("..\\..\\..\\DirListaPersonas\\FiListaPersonas.txt", persona.DNI + "\t" + persona.Nombre + "\t" + persona.Apellido1 + "\t" + persona.Apellido2 + "\t" +
                    persona.Edad + "\t\n");
            }
        }

        private List<Persona> LeerListaPersonas()
        {
            List<Persona> listaPersonas = new List<Persona>();
            Persona persona;
            foreach (String line in File.ReadLines("..\\..\\..\\DirListaPersonas\\FiListaPersonas.txt"))
            {
                string[] linea = line.Split('\t');
                persona = new Persona(linea[0], linea[1], linea[2], linea[3], Convert.ToInt32(linea[4]));
                listaPersonas.Add(persona);
            }            
            return listaPersonas;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarPersonasEnFichero(listaPersonas);
        }
        private void lecturaJaime()
        {
            FileInfo fichero;
            string registro;
            string[] campo;

            DirectoryInfo directorio = new DirectoryInfo("..\\..\\..\\DirListaPersonas");

            if(!directorio.Exists)
            {
                Directory.CreateDirectory("..\\..\\..\\DirListaPersonas\\FiListaPersonas.txt");
            }

            fichero = new FileInfo("..\\..\\..\\DirListaPersonas\\FiListaPersonas.txt");

            if(fichero.Exists)
            {
                StreamReader unaLinea = new StreamReader("..\\..\\..\\DirListaPersonas\\FiListaPersonas.txt");

                using(unaLinea)
                {
                    while(unaLinea.Peek() != -1)
                    {
                        Persona unaPersona = new Persona();

                        registro = unaLinea.ReadLine();

                        campo = Regex.Split(registro, "\t");

                        unaPersona.DNI = campo[0];
                        unaPersona.Nombre = campo[1];
                        unaPersona.Apellido1 = campo[2];
                        unaPersona.Apellido2 = campo[3];
                        unaPersona.Edad = Convert.ToInt32(campo[4]);
                        
                        listaPersonas.Add(unaPersona);
                    }
                }//El using cierra el streamreader al acabar
            }
        }
    }
}
