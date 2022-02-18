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
    public partial class Libreria : Form
    {
        OleDbConnection conexionConLaBD;
        Form1 form1;
        public Libreria(Form1 form1)
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            this.form1 = form1;
            conexionConLaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\José\Documents\GitHub\Interfaces\Febrero04_Access\Access_DbLibros.accdb");
            conexionConLaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hernandez21107\Documents\GitHub\Interfaces\Febrero04_Access\Access_DbLibros.accdb");
            RellenarTabla();
        }

        private void Libreria_Load(object sender, EventArgs e)
        {

        }

        private void RellenarTabla()
        {
            string cadenaSql = @"SELECT 
            Access_TaLibreria.Isbn, 
            Access_TaLibros.Título,
            Access_TaLibreria.Cantidad, 
            Access_TaLibreria.Precio
            FROM Access_TaLibreria, Access_TaLibros 
            WHERE Access_TaLibreria.Isbn = Access_TaLibros.Isbn";
            OleDbDataAdapter puenteConLaTabla = new OleDbDataAdapter(cadenaSql, conexionConLaBD);
            DataTable tablaDeLaBD = new DataTable();
            puenteConLaTabla.Fill(tablaDeLaBD);
            dataGridView1.DataSource = tablaDeLaBD;
        }

        private void ModificarRegistro()
        {
            string cadenaSql = @"UPDATE Access_TaLibreria 
            SET
            Cantidad = @Cantidad,
            Precio = @Precio
            WHERE Isbn = @Isbn";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Cantidad", txbCantidad.Text);
            instruccionesSql.Parameters.AddWithValue("@Precio", txbPrecio.Text);
            instruccionesSql.Parameters.AddWithValue("@Isbn", txbIsbn.Text);
            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            txbIsbn.Enabled = true;
            RellenarTabla();
        }

        private void BuscarRegistro()
        {
            string cadenaSql = @"SELECT *
            FROM Access_TaLibreria 
            WHERE Isbn = @Isbn";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Isbn", txbIsbn.Text);
            conexionConLaBD.Open();
            OleDbDataReader registro = instruccionesSql.ExecuteReader();
            if (registro.Read())
            {
                txbCantidad.Text = registro[1].ToString();
                txbPrecio.Text = registro[2].ToString();
                txbIsbn.Enabled = false;
            }
            conexionConLaBD.Close();
        }

        private void VaciarCampos()
        {
            txbIsbn.Text = "";
            txbCantidad.Text = "";
            txbPrecio.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistro();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        private void Libreria_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
    }
}
