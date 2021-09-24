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
            if(num < 1 || num > 3999)
            {
                return "Numero incompatible";
            }
            string numConvertido = num.ToString();
            string numRomano = "";
            for(int i = 0; i < numConvertido.Length; i++)
            {
                if(i == 0 && numConvertido.Length == 4)
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
                if ((i == 1 && numConvertido.Length == 4) || (i == 0 && numConvertido.Length == 3))
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
                if ((i == 2 && numConvertido.Length == 4) || (i == 1 && numConvertido.Length == 3) || (i == 0 && numConvertido.Length == 2))
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
                if ((i == 3 && numConvertido.Length == 4) || (i == 2 && numConvertido.Length == 3) || (i == 1 && numConvertido.Length == 2) || (i == 0 && numConvertido.Length == 1))
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
        public static void Ej05aux()
        {
            //numeros romanos, bucle pidiendo numeros romanos hasta que metamos cero, entre 1 y 3999
            string num;
            string numRomano;
            do
            {
                Console.Write("Introduce un número: ");
                num = Console.ReadLine();
                if (int.TryParse(num, out int numConvertido))
                {
                    numRomano = Ej05(numConvertido);
                    Console.WriteLine(numRomano);
                }
                else
                {
                    Console.WriteLine("Tienes que introducir un número");
                }

            } while (num != "0");
        }
        public static void Ej05Solucion()
        {
            int indoarabigo, millares, centenas, decenas, unidades, restoMillares, restoCEntenas;
            string romanoMillares = "", romanoCentenas = "", romanoDecenas = "", romanoUnidades = "";
            do
            {
                Console.Write("Escriba un numero entero entre 1 y 3999 (0=finalizar)");
                int.TryParse(Console.ReadLine(), out indoarabigo);

                if(indoarabigo > 0 && indoarabigo < 4000)
                {
                    millares = indoarabigo / 1000;
                    restoMillares = indoarabigo % 1000;

                    centenas = restoMillares / 100;
                    restoCEntenas = restoMillares % 100;

                    decenas = restoCEntenas / 10;
                    unidades = restoCEntenas % 10;
                }
            } while (true);
        }
        public static void Ej06()
        {
            int num = 1;
            int total = 1;
            do
            {
                Console.Write("Introduce un número (1=finalizar): ");
                int.TryParse(Console.ReadLine(), out num);
                total *= num;
            } while (num != 1);
            Console.WriteLine("El resultado de multiplicar los números introducidos es: " + total);
        }
        static void Main()
        {
            //si par, divide entre dos, si impar, multiplica por 3 y se le suma 1
            int num;
            int serie;



            Console.Write("Introduce un número (0=finalizar): ");
            int.TryParse(Console.ReadLine(), out num);
            serie = num;
            do
            {
                
                if(num % 2 == 0)
                {
                    serie /= 2; 
                }
                else
                {
                    serie = (serie * 3) + 1;
                }
                Console.WriteLine(serie);
            } while (serie != 1 );
        }
    }
}
