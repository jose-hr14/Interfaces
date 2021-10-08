using System;
using System.Collections.Generic;
using System.Text;

namespace BuclesInterfaces
{
    class conversorEuroPeseta
    {
        double euros;
        double pesetas;

        public conversorEuroPeseta()
        {

        }
        public conversorEuroPeseta(double euros)
        {
            this.euros = euros;
            setPesetas();
        }

        public void setEuros()
        {
            bool convertido;
            double euros;
            do
            {
                Console.Write("Escribe una cantidad en euros: ");
                convertido = Double.TryParse(Console.ReadLine(), out euros);
            } while (!convertido);
            this.euros = euros;
        }
        public void setPesetas()
        {
            this.pesetas = this.euros * 166.386;
        }
        public double getEuros()
        {
            return this.euros;
        }
        public double getPesetas()
        {
            return this.pesetas;
        }
        public void leerEuros()
        {
            bool convertido;
            double euros;
            do
            {
                Console.Write("Escribe una cantidad en euros: ");
                convertido = Double.TryParse(Console.ReadLine(), out euros);
            } while (!convertido);
            this.euros = euros;
        }
        public void imprimirPesetas()
        {
            Console.WriteLine(this.euros + " euros son " + this.pesetas + " pesetas");
            Console.WriteLine();
        }
    }
}
