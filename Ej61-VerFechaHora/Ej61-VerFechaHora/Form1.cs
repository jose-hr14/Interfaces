using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej61_VerFechaHora
{
    public partial class Form1 : Form
    {
        DateTime dateTime;
        public Form1()
        {
            InitializeComponent();
            lblFecha.Visible = false;
            lblHora.Visible = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = new DateTimePicker();
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
            //lblFecha.Text = DateTime.Now.DayOfWeek + ", " + DateTime.Now.Day + " de " + DateTime.Now.Month + " de " + DateTime.Now.Year;
            //lblHora.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        private void btnVerFechaHora_Click(object sender, EventArgs e)
        {
            lblFecha.Visible = true;
            lblHora.Visible = true;
        }
    }
}
