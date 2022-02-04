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
using System.Data.SqlClient;
// Data grid view de solo lectura, quitar la columna izquierda y la fila de abajo
// Que no se pued ainteractuar con él, solo mirar.
// Si tecleamos dni y le damos a buscar, carga sus datos en el resto de textbox, si queremos
// modificar algo, modificamos el campo que queramos tras haberlo buscado y le damos al botón modificar
// Para eliminar igual, lo buscamos y le damos a eliminar
namespace Febrero02_Sql
{
    public partial class Form1 : Form
    {
        SqlConnection conexionConLaBD;
        bool buscado;
        public Form1()
        {
            InitializeComponent();
            conexionConLaBD = new SqlConnection(@"server=LAPTOP-UI4BPKQL;
            database=SqlS_DbPersonas; integrated security = true");
            rellenarDataGridView();
            buscado = false;

            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.AutoResizeRows();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void rellenarDataGridView()
        {
            string cadenaSql = @"
                SELECT *
                FROM dbo.SqlS_TaPersonas
                ORDER BY Dni;";
            SqlDataAdapter puenteConLaTabla = new SqlDataAdapter(cadenaSql, conexionConLaBD);
            DataTable tablaDeLaBD = new DataTable();
            puenteConLaTabla.Fill(tablaDeLaBD);
            dataGridView1.DataSource = tablaDeLaBD;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarRegistro();
            buscado = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(buscado)
            {
                modificarRegistro();
                rellenarDataGridView();
                buscado = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarRegistro();
            buscado = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (buscado)
            {
                borrarRegistro();
            }
        }
        private void borrarRegistro()
        {
            string cadenaSql = @"
                                 DELETE FROM dbo.SqlS_TaPersonas
                                 WHERE Dni = @Dni;";
            SqlCommand instruccionesSql = new SqlCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", txtDniBuscar.Text);
            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            buscado = false;
            rellenarDataGridView();
            vaciarCampos();
        }
        private void buscarRegistro()
        {
            string cadenaSql = @"
                         SELECT *
                         FROM dbo.SqlS_TaPersonas
                         WHERE Dni = @Dni;";
            SqlCommand instruccionesSql = new SqlCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", txtDniBuscar.Text);

            conexionConLaBD.Open();
            SqlDataReader registro = instruccionesSql.ExecuteReader();
            if (registro.Read())
            {
                txbDni.Text = registro[0].ToString();
                txbNombre.Text = registro[1].ToString();
                txbApellido1.Text = registro[2].ToString();
                txbApellido2.Text = registro[3].ToString();
                txbEdad.Text = registro[4].ToString();
            }
            conexionConLaBD.Close();
            rellenarDataGridView();
        }
        private void agregarRegistro()
        {
            if(!existeDni())
            {
                string cadenaSql = $@"
                                 INSERT INTO dbo.SqlS_TaPersonas
                                 (Dni, Nombre, Apellido1, Apellido2, Edad)
                                 VALUES
                                 (@Dni, @Nombre, @Apellido1, @Apellido2, @Edad);";
                SqlCommand instruccionesSql = new SqlCommand(cadenaSql, conexionConLaBD);
                instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);
                instruccionesSql.Parameters.AddWithValue("@Nombre", txbNombre.Text);
                instruccionesSql.Parameters.AddWithValue("@Apellido1", txbApellido1.Text);
                instruccionesSql.Parameters.AddWithValue("@Apellido2", txbApellido2.Text);
                instruccionesSql.Parameters.AddWithValue("@Edad", txbEdad.Text);

                conexionConLaBD.Open();
                instruccionesSql.ExecuteNonQuery();
                conexionConLaBD.Close();
                rellenarDataGridView();
                vaciarCampos();
            }
        }
        private void modificarRegistro()
        {
            string cadenaSql = @"
                         UPDATE dbo.SqlS_TaPersonas
                         SET
                         Dni = @Dni,
                         Nombre = @Nombre,
                         Apellido1 = @Apellido1,
                         Apellido2 = @Apellido2,
                         Edad = @Edad
                         WHERE Dni = @Dni;";
            SqlCommand instruccionesSql = new SqlCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);
            instruccionesSql.Parameters.AddWithValue("@Nombre", txbNombre.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido1", txbApellido1.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido2", txbApellido2.Text);
            instruccionesSql.Parameters.AddWithValue("@Edad", txbEdad.Text);

            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            rellenarDataGridView();
            vaciarCampos();
        }

        private void vaciarCampos()
        {
            txbDni.Clear();
            txbNombre.Clear();
            txbApellido1.Clear();
            txbApellido2.Clear();
            txbEdad.Clear();
            txtDniBuscar.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscado = false;
            vaciarCampos();
        }
        private bool existeDni()
        {
            string cadenaSql = @"
                         SELECT *
                         FROM dbo.SqlS_TaPersonas
                         WHERE Dni = @Dni;";
            SqlCommand instruccionesSql = new SqlCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);
            conexionConLaBD.Open();
            SqlDataReader registro = instruccionesSql.ExecuteReader();
            if (registro.Read())
            {
                conexionConLaBD.Close();
                return true;
            }
            else
            {
                conexionConLaBD.Close();
                return false;
            }
        }
    }
}
