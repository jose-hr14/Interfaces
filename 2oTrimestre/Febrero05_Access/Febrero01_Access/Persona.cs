using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Febrero01_Access
{
    internal class Persona
    {
        OleDbConnection conexionConLaBD;
        bool buscado;
        string dni;
        string nombre;
        string apellido1;
        string apellido2;
        string edad;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }

        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public Persona()
        {
            conexionConLaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\José\Documents\GitHub\Interfaces\2oTrimestre\Febrero05_Access\Access_DbPersonas2.accdb");
        }

        public Persona(string dni, string nombre, string apellido1, string apellido2, string edad)
        {
            conexionConLaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\José\Documents\GitHub\Interfaces\2oTrimestre\Febrero05_Access\Access_DbPersonas2.accdb");
            this.dni = dni;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.edad = edad;
        }



        public void BorrarRegistro()
        {
            string cadenaSql = @"
                                 DELETE FROM Access_TaPersonas
                                 WHERE Dni = @Dni;";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", dni);
            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            buscado = false;
        }
        public void BuscarRegistro()
        {
            string cadenaSql = @"
                         SELECT *
                         FROM Access_TaPersonas
                         WHERE Dni = @Dni;";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", dni);

            conexionConLaBD.Open();
            OleDbDataReader registro = instruccionesSql.ExecuteReader();
            if (registro.Read())
            {
                dni = registro[0].ToString();
                nombre = registro[1].ToString();
                apellido1 = registro[2].ToString();
                apellido2 = registro[3].ToString();
                edad = registro[4].ToString();
            }
            conexionConLaBD.Close();
        }
        public void AgregarRegistro()
        {
            if (!ExisteDni())
            {
                string cadenaSql = $@"
                                 INSERT INTO Access_TaPersonas
                                 (Dni, Nombre, Apellido1, Apellido2, Edad)
                                 VALUES
                                 (@Dni, @Nombre, @Apellido1, @Apellido2, @Edad);";
                OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
                instruccionesSql.Parameters.AddWithValue("@Dni", dni);
                instruccionesSql.Parameters.AddWithValue("@Nombre", nombre);
                instruccionesSql.Parameters.AddWithValue("@Apellido1", apellido1);
                instruccionesSql.Parameters.AddWithValue("@Apellido2", apellido2);
                instruccionesSql.Parameters.AddWithValue("@Edad", edad);

                conexionConLaBD.Open();
                instruccionesSql.ExecuteNonQuery();
                conexionConLaBD.Close();

            }
        }
        public void ModificarRegistro()
        {
            string cadenaSql = @"
                        UPDATE Access_TaPersonas
                        SET
                        Nombre = @Nombre,
                        Apellido1 = @Apellido1,
                        Apellido2 = @Apellido2,
                        Edad = @Edad
                        WHERE Dni = @Dni;";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Nombre", nombre);
            instruccionesSql.Parameters.AddWithValue("@Apellido1", apellido1);
            instruccionesSql.Parameters.AddWithValue("@Apellido2", apellido2);
            instruccionesSql.Parameters.AddWithValue("@Edad", edad);
            instruccionesSql.Parameters.AddWithValue("@Dni", dni);

            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
        }

        public bool ExisteDni()
        {
            string cadenaSql = @"
                         SELECT *
                         FROM Access_TaPersonas
                         WHERE Dni = @Dni;";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", dni);
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

        public  void LimpiarCampos()
        {
            dni = null;
            nombre = null;
            apellido1 = null;
            apellido2 = null;
            edad = null;
        }
    }
}
