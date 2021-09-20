using System;

namespace BuclesInterfaces
{
    class Program
    {
        public void Ej01()
        {
            int contador = 1;
            Console.WriteLine("Bucle PARA");
            for (contador = 1; contador <= 5; contador++)
            {
                Console.WriteLine(contador);
            }

            contador = 1;
            Console.WriteLine("Bucle MIENTRAS");
            while (contador <= 5)
            {
                Console.WriteLine(contador);
                contador++;
            }

            contador = 1;
            Console.WriteLine("Bucle REPETIR HASTA");
            do
            {
                Console.WriteLine(contador);
                contador++;
            } while (contador <= 5);
        }
        public void Ej02()
        {
            Console.Write("Introduce un número: ");
            string multiplicando = Console.ReadLine();

            if (!int.TryParse(multiplicando, out int multiplicandoConvertido))
                multiplicandoConvertido = 0;

            for (int i = 0; i <= 10; i++)
                Console.WriteLine(multiplicandoConvertido + " * " + i + " = " + multiplicandoConvertido * i);

            Console.Write("Pulsa una tecla para terminar: ");
            Console.ReadLine();
        }
        public void Ej03()
        {
            /*
            string palabra;
            do
            {
                Console.Write("Escriba la palabra hola: ");
                palabra = Console.ReadLine();
            } while (palabra != "hola");
            */
            string palabra = "";
            while (palabra != "hola")
            {
                Console.Write("Escriba la palabra hola: ");
                palabra = Console.ReadLine();
            }
        }
        public void Ej04()
        {
            string palabra;
            do
            {
                Console.Write("Escriba cualquier palabra (0=finalizar): ");
                palabra = Console.ReadLine();
                if (palabra != "0")
                {
                    Console.WriteLine("Usted ha escrito la palabra: " + palabra);
                }
            } while (palabra != "0");
            Console.Write("Pulse cualquier tecla para terminar: ");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //numeros romanos, bucle pidiendo numeros romanos hasta que metamos cero, en 1 y 3999

            
        }
    }
}
