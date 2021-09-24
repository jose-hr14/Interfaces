using System;

namespace BuclesInterfaces
{
    class Program
    {
        public static void Ej01()
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
        public static void Ej02()
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
        public static void Ej03()
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
        public static void Ej04()
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
        public static string Ej05(int num)
        {
            if(num < 1 && num > 3999)
            {
                return "Numero incompatible";
            }
            string numConvertido = num.ToString();
            string numRomano = "";
            for(int i = 0; i < numConvertido.Length; i++)
            {
                if(i == 0)
                {
                    switch(numConvertido[i])
                    {
                        case '1':
                            numRomano += "M";
                            break;
                        case '2':
                            numRomano += "MM";
                            break;
                        case '3':
                            numRomano += "MMM";
                            break;

                    }
                }
                if (i == 1)
                {
                    switch (numConvertido[i])
                    {
                        case '1':
                            numRomano += "C";
                            break;
                        case '2':
                            numRomano += "CC";
                            break;
                        case '3':
                            numRomano += "CCC";
                            break;
                        case '4':
                            numRomano += "CD";
                            break;
                        case '5':
                            numRomano += "D";
                            break;
                        case '6':
                            numRomano += "DC";
                            break;
                        case '7':
                            numRomano += "DCC";
                            break;
                        case '8':
                            numRomano += "DCC";
                            break;
                        case '9':
                            numRomano += "CM";
                            break;


                    }
                }
                if (i == 2)
                {
                    switch (numConvertido[i])
                    {
                        case '1':
                            numRomano += "X";
                            break;
                        case '2':
                            numRomano += "XX";
                            break;
                        case '3':
                            numRomano += "XXX";
                            break;
                        case '4':
                            numRomano += "XL";
                            break;
                        case '5':
                            numRomano += "L";
                            break;
                        case '6':
                            numRomano += "LX";
                            break;
                        case '7':
                            numRomano += "LXX";
                            break;
                        case '8':
                            numRomano += "LXXX";
                            break;
                        case '9':
                            numRomano += "XC";
                            break;
                    }
                }
                if (i == 3)
                {
                    switch (numConvertido[i])
                    {
                        case '1':
                            numRomano += "I";
                            break;
                        case '2':
                            numRomano += "II";
                            break;
                        case '3':
                            numRomano += "III";
                            break;
                        case '4':
                            numRomano += "IV";
                            break;
                        case '5':
                            numRomano += "V";
                            break;
                        case '6':
                            numRomano += "VI";
                            break;
                        case '7':
                            numRomano += "VII";
                            break;
                        case '8':
                            numRomano += "VIII";
                            break;
                        case '9':
                            numRomano += "IX";
                            break;

                    }
                }                
            }
            return numRomano;
        }
        static void Main(string[] args)
        {
            //numeros romanos, bucle pidiendo numeros romanos hasta que metamos cero, en 1 y 3999

            string numRomano = Ej05(3555);
            Console.WriteLine(numRomano);
        }
    }
}
