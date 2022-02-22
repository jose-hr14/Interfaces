using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa07_03
{
    class Persona
    {
        private string dni;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private int edad;

        public Persona()
        {

        }

        public Persona(string dni, string nombre, string apellido1, string apellido2, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.edad = edad;
        }

        public string DNI
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellido1
        {
            get
            {
                return apellido1;
            }
            set
            {
                apellido1 = value;
            }
        }
        public string Apellido2
        {
            get
            {
                return apellido2;
            }
            set
            {
                apellido2 = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
    }
}
