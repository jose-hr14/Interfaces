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
using System.Text.RegularExpressions;
// Data grid view de solo lectura, quitar la columna izquierda y la fila de abajo
// Que no se pued ainteractuar con él, solo mirar.
// Si tecleamos dni y le damos a buscar, carga sus datos en el resto de textbox, si queremos
// modificar algo, modificamos el campo que queramos tras haberlo buscado y le damos al botón modificar
// Para eliminar igual, lo buscamos y le damos a eliminar
// Declarar objeto personas y conexion
//autores
//En access, en la clave, requerido y sin duplicados, y no permitir longitud cero
namespace Febrero01_Access
{
    public partial class Form1 : Form
    {
        OleDbConnection conexionConLaBD;
        bool buscado;
        public Form1()
        {
            InitializeComponent();
            Regex.IsMatch("", "^[0-9]+([,][0-9]+)?$");
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.StartPosition = FormStartPosition.CenterScreen;
            conexionConLaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\José\Documents\GitHub\Interfaces\Febrero01_Access\Access_DbPersonas2.accdb");
            rellenarDataGridView();
            buscado = false;
        }

        private void rellenarDataGridView()
        {
            string cadenaSql = @"
                SELECT *
                FROM Access_TaPersonas
                ORDER BY Dni;";
            OleDbDataAdapter puenteConLaTabla = new OleDbDataAdapter(cadenaSql, conexionConLaBD);
            DataTable tablaDeLaBD = new DataTable();
            puenteConLaTabla.Fill(tablaDeLaBD);
            dataGridView1.DataSource = tablaDeLaBD;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbEdad.Text, out int edad))
            {
                agregarRegistro();
                buscado = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(buscado && int.TryParse(txbEdad.Text, out int edad))
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
                                 DELETE FROM Access_TaPersonas
                                 WHERE Dni = @Dni;";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);
            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            buscado = false;
            rellenarDataGridView();
            vaciarCampos();
        }
        private void buscarRegistro()
        {
            txbDni.Enabled = false;
            string cadenaSql = @"
                         SELECT *
                         FROM Access_TaPersonas
                         WHERE Dni = @Dni;";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);

            conexionConLaBD.Open();
            OleDbDataReader registro = instruccionesSql.ExecuteReader();
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
                                 INSERT INTO Access_TaPersonas
                                 (Dni, Nombre, Apellido1, Apellido2, Edad)
                                 VALUES
                                 (@Dni, @Nombre, @Apellido1, @Apellido2, @Edad);";
                OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
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
                        UPDATE Access_TaPersonas
                        SET
                        Dni = @Dni,
                        Nombre = @Nombre,
                        Apellido1 = @Apellido1,
                        Apellido2 = @Apellido2,
                        Edad = @Edad
                        WHERE Dni = @Dni;";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
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
            txbDni.Enabled = true;
        }

        private void vaciarCampos()
        {
            txbDni.Clear();
            txbNombre.Clear();
            txbApellido1.Clear();
            txbApellido2.Clear();
            txbEdad.Clear();
            txbDni.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscado = false;
            txbDni.Enabled = true;
            vaciarCampos();
        }
        private bool existeDni()
        {
            string cadenaSql = @"
                         SELECT *
                         FROM Access_TaPersonas
                         WHERE Dni = @Dni;";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);
            conexionConLaBD.Open();
            OleDbDataReader registro = instruccionesSql.ExecuteReader();
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
