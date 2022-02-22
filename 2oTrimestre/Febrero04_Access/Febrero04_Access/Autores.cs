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
            conexionConLaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\José\Documents\GitHub\Interfaces\2oTrimestre\Febrero04_Access\Access_DbLibros.accdb");
            //conexionConLaBD = new OleDbConnection(@"Provider =Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hernandez21107\Documents\GitHub\Interfaces\Febrero04_Access\Access_DbLibros.accdb");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            RellenarTabla();
        }
        private void RellenarTabla()
        {
            string cadenaSql = @"SELECT * FROM Access_TaAutores";
            OleDbDataAdapter puenteConLaTabla = new OleDbDataAdapter(cadenaSql, conexionConLaBD);
            DataTable tablaDeLaBD = new DataTable();
            puenteConLaTabla.Fill(tablaDeLaBD);
            dataGridView1.DataSource = tablaDeLaBD;
        }
        private void AgregarRegistro()
        {
            string cadenaSql = @"INSERT INTO Access_TaAutores (Dni, Nombre, Apellido1, Apellido2) VALUES (@Dni, @Nombre, @Apellido1, @Apellido2)";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);
            instruccionesSql.Parameters.AddWithValue("@Nombre", txbNombre.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido1", txbApellido1.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido2", txbApellido2.Text);
            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            RellenarTabla();
            LimpiarCampos();
        }
        private void BuscarRegistro()
        {
            string cadenaSql = @"SELECT * FROM Access_TaAutores WHERE Dni = @Dni";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);
            conexionConLaBD.Open();
            OleDbDataReader registro = instruccionesSql.ExecuteReader();
            if (registro.Read())
            {
                txbDni.Enabled = false;
                btnAgregar.Enabled = false;
                txbNombre.Text = registro[1].ToString();
                txbApellido1.Text = registro[2].ToString();
                txbApellido2.Text = registro[3].ToString();
                conexionConLaBD.Close();
            }
            else
                conexionConLaBD.Close();
        }

        private void ModificarRegistro()
        {
            string cadenaSql = @"UPDATE Access_TaAutores 
            SET 
            Nombre = @Nombre, 
            Apellido1 = @Apellido1, 
            Apellido2 = @Apellido2 
            WHERE 
            Dni = @Dni";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Nombre", txbNombre.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido1", txbApellido1.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido2", txbApellido2.Text);
            instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);
            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            txbDni.Enabled = true;
            btnAgregar.Enabled = true;
            RellenarTabla();
            LimpiarCampos();
        }

        private void EliminarRegistro()
        {
            string cadenaSql = @"SELECT * FROM Access_TaLibros WHERE Dni = @Dni";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);
            conexionConLaBD.Open();
            OleDbDataReader registro = instruccionesSql.ExecuteReader();
            if (!registro.Read())
            {
                conexionConLaBD.Close();
                cadenaSql = @"DELETE FROM Access_TaAutores WHERE Dni = @Dni";
                instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
                instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);
                conexionConLaBD.Open();
                instruccionesSql.ExecuteNonQuery();
                conexionConLaBD.Close();
                LimpiarCampos();
                RellenarTabla();
                txbDni.Enabled = true;
                btnAgregar.Enabled = true;
            }
            else
            {
                conexionConLaBD.Close();
                LimpiarCampos();
                RellenarTabla();
                txbDni.Enabled = true;
                btnAgregar.Enabled = true;
            }                           
        }

        private void LimpiarCampos()
        {
            txbDni.Text = "";
            txbNombre.Text = "";
            txbApellido1.Text = "";
            txbApellido2.Text = "";
        }

        private void Autores_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarRegistro();
            }
            catch
            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistro();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(!txbDni.Enabled)
            {
                try
                {
                    ModificarRegistro();
                }
                catch
                {

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!txbDni.Enabled)
                EliminarRegistro();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
