using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Febrero03_AccessCon_WPF
{
    /// <summary>
    /// Lógica de interacción para WindowLibreria.xaml
    /// </summary>
    /// Para actualizar, inner join
    public partial class WindowLibreria : Window
    {
        MainWindow mainWindow;
        OleDbConnection conexionConLaBD;
        public WindowLibreria(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            //dtgLibros.canuseraddrows = false;
            // dtglibros.cansuserdeleterows = false;
            // dtg.libros.isreadonly = true;
            conexionConLaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\José\Documents\GitHub\Interfaces\Febrero03_AccessCon WPF\Access_DbLibros.accdb");
            RellenarDataGrid();
        }

        public void RellenarDataGrid()
        {
            string cadenaSql = @"
                SELECT Access_TaLibreria.Isbn, Access_TaLibros.Título, Cantidad, Precio
                FROM Access_TaLibreria, Access_TaLibros
                WHERE Access_TaLibreria.Isbn = Access_TaLibros.Isbn
                ORDER BY Access_TaLibreria.Isbn;";
            OleDbDataAdapter puenteConLaTabla = new OleDbDataAdapter(cadenaSql, conexionConLaBD);
            DataTable tablaDeLaBD = new DataTable();
            puenteConLaTabla.Fill(tablaDeLaBD);
            dtgLibreria.ItemsSource = tablaDeLaBD.DefaultView;
        }

        private void BuscarRegistro()
        {
            string cadenaSql = @"SELECT * FROM Access_TaLibreria WHERE Isbn = @Isbn";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Isbn", txbIsbn.Text);
            conexionConLaBD.Open();
            OleDbDataReader registro = instruccionesSql.ExecuteReader();
            if(registro.Read())
            {
                txbIsbn.Text = registro[0].ToString();
                txbCantidad.Text = registro[1].ToString();
                txbPrecio.Text = registro[2].ToString();
                txbIsbn.IsEnabled = false;
                txbIsbn.IsEnabled = false;
            }
            else
            {
                LimpiarCampos();
            }
            conexionConLaBD.Close();
        }

        private void ModificarRegistro()
        {
            string cadenaSql = @"
                                UPDATE Access_TaLibreria
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
            RellenarDataGrid();
        }

        private void LimpiarCampos()
        {
            txbIsbn.Text = "";
            txbIsbn.Text = "";
            txbCantidad.Text = "";
            txbPrecio.Text = "";
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if(txbIsbn.Text != "")
            {
                BuscarRegistro();
            }
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (!txbIsbn.IsEnabled)
            {
                ModificarRegistro();
                txbIsbn.IsEnabled = true;
                txbIsbn.IsEnabled = true;
                LimpiarCampos();
            }
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            txbIsbn.Text = "";
            txbCantidad.Text = "";
            txbPrecio.Text = "";
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txbIsbn.IsEnabled = true;
            txbIsbn.IsEnabled = true;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }
    }
}
