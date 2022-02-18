using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Febrero04_Access
{
    public partial class Autores : Form
    {
        OleDbConnection conexionConLaBD;
        Form1 form1;
        public Autores(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void RellenarTabla()
        {
            string cadenaSql = @"SELECT * FROM Access_TaAutores";
        }
    }
}
