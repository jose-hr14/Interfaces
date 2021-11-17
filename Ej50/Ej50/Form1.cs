using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ListViewGroup coches = new ListViewGroup("Coches", HorizontalAlignment.Center);
            ListViewGroup motos = new ListViewGroup("Motos", HorizontalAlignment.Center);

            listView1.Groups.Add(coches);
            listView1.Items.Add(new ListViewItem("BMW", coches));
            listView1.Items.Add(new ListViewItem("Audi", coches));
            listView1.Items.Add(new ListViewItem("Dacia", coches));
            listView1.Items.Add(new ListViewItem("Ford", coches));
            listView1.Items.Add(new ListViewItem("Honda", coches));

            listView1.Groups.Add(motos);
            listView1.Items.Add(new ListViewItem("Aprilia", motos));
            listView1.Items.Add(new ListViewItem("Benelli", motos));
            listView1.Items.Add(new ListViewItem("Cagiva", motos));
            listView1.Items.Add(new ListViewItem("Ducati", motos));
            listView1.Items.Add(new ListViewItem("Gilera", motos));            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
