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
    public partial class Libros : Form
    {
        //Adjuntar nombre y apellidos de autor, pero no el dni
        Form1 form1;
        OleDbConnection conexionConLaBD;
        public Libros(Form1 form1)
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            this.form1 = form1;
            conexionConLaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\José\Documents\GitHub\Interfaces\2oTrimestre\Febrero04_Access\Access_DbLibros.accdb");
            //conexionConLaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hernandez21107\Documents\GitHub\Interfaces\Febrero04_Access\Access_DbLibros.accdb");
            RellenarTabla();
            txbNombre.Enabled = false;
            txbApellido1.Enabled = false;
            txbApellido2.Enabled = false;
        }

        private void Libros_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void RellenarTabla()
        {
            string cadenaSql = @"
                SELECT Access_TaLibros.Isbn,
                Access_TaLibros.Título,
                Access_TaLibros.Editorial,
                Access_TaLibros.Dni,
                Access_TaAutores.Nombre,
                Access_TaAutores.Apellido1,
                Access_TaAutores.Apellido2
                FROM Access_TaLibros, Access_TaAutores
                WHERE Access_TaLibros.Dni = Access_TaAutores.Dni";
            OleDbDataAdapter puenteConLaTabla = new OleDbDataAdapter(cadenaSql, conexionConLaBD);
            DataTable tablaDeLaBD = new DataTable();
            puenteConLaTabla.Fill(tablaDeLaBD);
            dataGridView1.DataSource = tablaDeLaBD;
        }

        private void AgregarLibro()
        {
            string cadenaSql = $@"
                                 INSERT INTO Access_TaLibros
                                 (Isbn, Título, Editorial, Dni)
                                 VALUES
                                 (@Isbn, @Título, @Editorial, @Dni);";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Isbn", txbIsbn.Text);
            instruccionesSql.Parameters.AddWithValue("@Título", txbTitulo.Text);
            instruccionesSql.Parameters.AddWithValue("@Editorial", txbEditorial.Text);
            instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);

            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            RellenarTabla();

            cadenaSql = $@"
                            INSERT INTO Access_TaLibreria
                            (Isbn, Cantidad, Precio)
                            VALUES
                            (@Isbn, @Cantidad, @Precio);";
            instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Isbn", txbIsbn.Text);
            instruccionesSql.Parameters.AddWithValue("@Cantidad", "0");
            instruccionesSql.Parameters.AddWithValue("@Precio", "0");
            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            RellenarTabla();
        }

        private void BuscarRegistro()
        {
            string cadenaSql = @"SELECT * 
            FROM Access_TaLibros, Access_TaAutores 
            WHERE Isbn = @Isbn
            AND Access_TaLibros.Dni = Access_TaAutores.Dni";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Isbn", txbIsbn.Text);

            conexionConLaBD.Open();
            OleDbDataReader registro = instruccionesSql.ExecuteReader();
            if(registro.Read())
            {
                txbIsbn.Text = registro[0].ToString();
                txbTitulo.Text = registro[1].ToString();
                txbEditorial.Text = registro[2].ToString();
                txbDni.Text = registro[3].ToString();
                txbNombre.Text = registro[5].ToString();
                txbApellido1.Text = registro[6].ToString();
                txbApellido2.Text = registro[7].ToString();
            }
            conexionConLaBD.Close();
        }

        private void ModificarRegistro()
        {
            string cadenaSql = @"UPDATE Access_TaLibros 
                                SET 
                                Título = @Título, 
                                Editorial = @Editorial,
                                Dni = @Dni
                                WHERE Isbn = @Isbn";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Título", txbTitulo.Text);
            instruccionesSql.Parameters.AddWithValue("@Editorial", txbEditorial.Text);
            instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);
            instruccionesSql.Parameters.AddWithValue("@Isbn", txbIsbn.Text);
            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            RellenarTabla();
        }

        private void EliminarRegistro()
        {
            string cadenaSql = @"DELETE FROM Access_TaLibros WHERE Isbn = @Isbn";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Isbn", txbIsbn.Text);
            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            RellenarTabla();
            
        }

        private bool ExisteDni()
        {
            string cadenaSql = @"SELECT * FROM Access_TaAutores WHERE Dni = @Dni";
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarLibro();
                VaciarCampos();
            }
            catch
            {
                VaciarCampos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txbIsbn.Enabled)
                {
                    ModificarRegistro();
                    btnAgregar.Enabled = true;
                    txbIsbn.Enabled = true;
                    VaciarCampos();
                }
            }
            catch
            {
                VaciarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txbIsbn.Enabled)
                {
                    EliminarRegistro();
                    btnAgregar.Enabled = true;
                    txbIsbn.Enabled = true;
                    VaciarCampos();
                }
            }
            catch
            {
                VaciarCampos();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarRegistro();
                btnAgregar.Enabled = false;
                txbIsbn.Enabled = false;
            }
            catch
            {

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            txbIsbn.Enabled = true;
            VaciarCampos();
        }

        private void VaciarCampos()
        {
            txbIsbn.Text = "";
            txbTitulo.Text = "";
            txbEditorial.Text = "";
            txbDni.Text = "";
            txbNombre.Text = "";
            txbApellido1.Text = "";
            txbApellido2.Text = "";
        }
    }
}
