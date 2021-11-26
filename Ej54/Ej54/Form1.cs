using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Add(textBox1.Text);
            listBox1.DataSource = null;
            listBox1.DataSource = lista;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(lista.Count > 0)
            {
                lista.Remove(textBox2.Text);
                listBox1.DataSource = null;
                listBox1.DataSource = lista;
            }            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string palabra = textBox2.Text;
            for(int i = 0; i < lista.Count; i++)
            {
                if (textBox2.Text == lista[i])
                {
                    lista[i] = textBox1.Text;
                    //lista.RemoveAt(i);
                    //lista.Insert(i, textBox1.Text);
                }
                    
            }
            listBox1.DataSource = null;
            listBox1.DataSource = lista;
        }
    }
}
