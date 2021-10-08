using System;
using System.Collections.Generic;
using System.Text;

namespace BuclesInterfaces
{
    class productoIVA
    {
        int precio;
        int impuesto;
        double precioIVA;

        public productoIVA()
        {
            setImpuesto();
            setPrecio();            
            setPrecioIVA(this.precio, this.impuesto);
        }

        public void setPrecio()
        {
            int precio = 0;
            string precioCadena = "";
            bool convertido = false;
            do
            {
                Console.Write("Introduce un precio: ");
                precioCadena = Console.ReadLine();
                convertido = int.TryParse(precioCadena, out precio);
            } while (!convertido || precio < 1);
            this.precio = precio;

        }

        public void setImpuesto()
        {
            string impuestoCadena = "";
            bool convertido = false;
            int impuesto = 0;
            do
            {
                Console.Write("Introduce un impuesto: 4%, 10%, 21%: ");
                impuestoCadena = Console.ReadLine();
                convertido = int.TryParse(impuestoCadena, out impuesto);
            } while (!convertido || (impuesto != 4 && impuesto != 10 && impuesto != 21));
            this.impuesto = impuesto;
        }

        public void setPrecioIVA(int precio, int impuesto)
        {
            precio += (precio * impuesto) / 100;
            this.precioIVA = precio;
        }

        public int getPrecio()
        {
            return this.precio;
        }

        public int getImpuesto()
        {
            return this.impuesto;
        }

        public double getPrecioIVA()
        {
            return this.precioIVA;
        }

        public void imprimirPrecioTotal()
        {
            Console.WriteLine("Un producto de " + precio + " euros con un impuesto del " + impuesto + "%  es " + getPrecioIVA() + " euros");
        }

        
    }
}
