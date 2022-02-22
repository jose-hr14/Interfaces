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

namespace PracticaExamen2
{
    public partial class Form1 : Form
    {
        OleDbConnection conecionConLaBD;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            conecionConLaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\José\Documents\GitHub\Interfaces\PracticaExamen\Juegos.accdb");
            RellenarTabla();
        }

        public void RellenarTabla()
        {
            string cadenaSql = @"SELECT * FROM Access_TaJuegos";
            OleDbDataAdapter puenteConLaTabla = new OleDbDataAdapter(cadenaSql, conecionConLaBD);
            DataTable tablaDeLaBD = new DataTable();
            puenteConLaTabla.Fill(tablaDeLaBD);
            dataGridView1.DataSource = tablaDeLaBD;
        }

        public void AgregarRegistro()
        {
            string cadenaSql = @"INSERT INTO Access_TaJuegos VALUES (@Id, @Nombre, @Género, @Plataforma)";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conecionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Id", txbId.Text);
            instruccionesSql.Parameters.AddWithValue("@Nombre", txbNombre.Text);
            instruccionesSql.Parameters.AddWithValue("@Género", txbGénero.Text);
            instruccionesSql.Parameters.AddWithValue("@Plataforma", txbPlataforma.Text);
            conecionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conecionConLaBD.Close();
            RellenarTabla();
        }

        public void BorrarRegistro()
        {
            string cadenaSql = @"DELETE FROM Access_TaJuegos WHERE Id = @Id";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conecionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Id", txbId.Text);
            conecionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conecionConLaBD.Close();
            RellenarTabla();

        }

        public void BuscarRegistro()
        {
            string cadenaSql = @"SELECT * FROM Access_TaJuegos WHERE Id = @Id";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conecionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Id", txbId.Text);
            conecionConLaBD.Open();
            OleDbDataReader registro = instruccionesSql.ExecuteReader();
            if(registro.Read())
            {
                txbNombre.Text = registro[1].ToString();
                txbGénero.Text = registro[2].ToString();
                txbPlataforma.Text = registro[3].ToString();
                conecionConLaBD.Close();
            }
        }

        public void ModificarRegistro()
        {
            string cadenaSql = @"UPDATE Access_TaJuegos
SET
Nombre = @Nombre,
Género = @Género,
Plataforma = @Plataforma
WHERE
Id = @Id";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conecionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Nombre", txbNombre.Text);
            instruccionesSql.Parameters.AddWithValue("@Género", txbGénero.Text);
            instruccionesSql.Parameters.AddWithValue("@Plataforma", txbPlataforma.Text);
            instruccionesSql.Parameters.AddWithValue("@Id", txbId.Text);
            conecionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conecionConLaBD.Close();
            RellenarTabla();
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
            ModificarRegistro();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarRegistro();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
