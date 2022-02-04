using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OleDbConnection conexionConLaBD;
            conexionConLaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\José\Documents\GitHub\Interfaces\Access\Access_DbPersonas.accdb");
            //Con la arroba, basta una slash y podemos ponerlo en dos días
            //Proyecto > propiedads de access > compilación > cpu destino > x64
            string cadenaSql = @"SELECT * 
                                FROM Access_TaPersonas 
                                ORDER BY Dni;";
            OleDbDataAdapter puenteConLaTabla = new OleDbDataAdapter(cadenaSql, conexionConLaBD);
            DataTable tablaDeLaBD = new DataTable();
            puenteConLaTabla.Fill(tablaDeLaBD);
            dtgvDatos.DataSource = tablaDeLaBD;
        }
    }
}
