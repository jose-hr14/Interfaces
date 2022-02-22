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

namespace PracticaExamen
{
    public partial class Form1 : Form
    {
        OleDbConnection conexionConLaBD;
        public Form1()
        {
            conexionConLaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\José\Documents\GitHub\Interfaces\PracticaExamen\Juegos.accdb");
            RellenarTabla();
        }

        private void RellenarTabla()
        {
            string cadenaSql = @"SELECT * FROM Access_TaJuegos";
            OleDbDataAdapter puenteConLaTabla = new OleDbDataAdapter(cadenaSql, conexionConLaBD);
            DataTable tablaDeLaBD = new DataTable();
            puenteConLaTabla.Fill(tablaDeLaBD);
            dataGridView1.DataSource = tablaDeLaBD;
        }

        private void AgregarRegistro()
        {
         
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
        }

        private void BuscarRegistro()
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistro();
        }

        private void BorrarRegistro()
        {
      
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarRegistro();
        }

        private void ModificarRegistro()
        {
 

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }
    }
}
