using System;
using System.Text.RegularExpressions;

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
        public static void Ej07()
        {
            //si par, divide entre dos, si impar, multiplica por 3 y se le suma 1
            int num = 1;
            while (num != 0)
            {
                Console.Write("Introduce un número (0=finalizar): ");
                if(!int.TryParse(Console.ReadLine(), out num))
                {
                    num = 1;
                }

                if(num != 0)
                {
                    Console.WriteLine(num);
                }
                
                while (num > 1)
                {
                    if (num % 2 == 0)
                    {
                        num /= 2;
                    }
                    else
                    {
                        num = (num * 3) + 1;
                    }
                    Console.WriteLine(num);
                }
            }
        }
        public static int Ej08(int num)
        {
            int res;
            if(num == 1)
            {
                return 1;
            }
            else
            {
                res = num * Ej08(num - 1);
            }
            return res;
        }
        public static int Ej09(int num)
        {
            int res;
            if(num == 0)
            {
                res = 0;
            }
            if(num == 1)
            {
                res = 1;
            }
            else
            {
                res = Ej09(num - 1) + Ej09(num - 2);
            }
            return res;
        }
        public static int Ej09Solucion(int num)
        {
            int res;
            if (num == 0)
            {
                res = 0;
            }
            if(num == 1)
            {
                res = 1;
            }                
            else
            {
                res = Ej09Solucion(num - 1) + Ej09Solucion(num - 2);
            }            
            return res;
        }
        public static void Ej09Aux()
        {
            int num = 1;
            do
            {
                do
                {
                    Console.Write("Dime un número (0 para salir): ");
                } while (!int.TryParse(Console.ReadLine(), out num));

                if (num != 0)
                {
                    int res = Ej09Solucion(num);
                    Console.WriteLine(res);
                }
            } while (num != 0);
        }
        public static void Ej09Aux02()
        {
            //Ej07();
            //int num = Ej08(6);
            //int num = Ej09(3);
            //escribir una fecha en dd-mm-1997, 29-02-1900 no es valido

            Ej09Solucion(8);

            //Ej10();
            int num = 1;
            do
            {
                do
                {
                    Console.Write("Dime un número (0 para salir): ");
                } while (!int.TryParse(Console.ReadLine(), out num));

                if (num != 0)
                {
                    int res = Ej09Solucion(num);
                    Console.WriteLine(res);
                }
            } while (num != 0);
        }
        public static void Ej10()
        {

            //Regex expRegFecha = new Regex("^[0-9]{2}-[0-9]{2}-[0-9]{4}$");
            while (true)
            {
                Console.Write("Introduce una fecha en el formato dd-mm-aaaa: ");
                string fecha = Console.ReadLine();

                if (fecha == "0")
                {
                    return;
                }

                bool fechaValida = true;

                if (fecha[2] != '-' || fecha[5] != '-')
                {
                    fechaValida = false;
                }

                string dia = "";
                string mes = "";
                string año = "";

                try
                {
                    dia = fecha[0].ToString() + fecha[1].ToString();
                    mes = fecha[3].ToString() + fecha[4].ToString();
                    año = fecha[6].ToString() + fecha[7].ToString() + fecha[8].ToString() + fecha[9].ToString();
                }
                catch
                {
                    fechaValida = false;
                }

                int diaNum = 0;
                int mesNum = 0;
                int añoNum = 0;

                if (!int.TryParse(dia, out diaNum) || !int.TryParse(mes, out mesNum) || !int.TryParse(año, out añoNum))
                {
                    fechaValida = false;
                }

                if (diaNum < 1 || diaNum > 31 || mesNum < 1 || mesNum > 12)
                {
                    fechaValida = false;
                }

                switch (esBisiesto(añoNum))
                {
                    case true:
                        {
                            if (mesNum == 2 && diaNum > 29)
                            {
                                fechaValida = false;
                            }
                            break;
                        }

                    case false:
                        {
                            if (mesNum == 2 && diaNum > 28)
                            {
                                fechaValida = false;
                            }
                            break;
                        }
                }
                if (fechaValida)
                {
                    Console.WriteLine("Fecha válida");
                }
                else if (!fechaValida)
                {
                    Console.WriteLine("Fecha inválida");
                }

            }


        }
        public static bool esBisiesto(int año)
        {
            if(año % 4 == 0)
            {
                if(año % 100 == 0)
                {
                    if(año % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public static void Ej11()
        {
            //Comprobar carné de identidad, metes los números y da la letra
            //8 letras

            char[] dniRestos = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            char letra = ' ';
            int dniNum = 0;
            bool salir = false;

            do
            {
                Console.Write("Introduce las cifras del DNI, escriba 0 para limpiar: ");
                string dni = Console.ReadLine();

                if (dni == "0")
                {
                    salir = true;
                }

                if (dni.Length == 8 && int.TryParse(dni, out dniNum) && !salir)
                {
                    int resto = dniNum % 23;
                    if (resto >= 0 || resto <= 23)
                    {
                        letra = dniRestos[resto];
                        Console.WriteLine(dni + letra);
                    }
                }

            } while (!salir);
        }
        public static void Ej12()
        {
            //MMMCMXCIX
            //sumas a pelo, si suma iv saldría 6, pero si le restas dos, haces la diferencia y sale correcto, sale 4
            Console.Write("Introduce un número romano: ");
            string numRomano = Console.ReadLine();
            int numeroArabigo = 0;


            //Regex expRegFecha = new Regex("^[0-9]{2}-[0-9]{2}-[0-9]{4}$");            
            Regex numRomanos = new Regex("^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");

            bool esRomano = numRomanos.IsMatch(numRomano);

            if(esRomano)
            {
                for(int i = 0; i < numRomano.Length; i++)
                {
                    switch(numRomano[i])
                    {
                        case 'M':
                            numeroArabigo += 1000;
                            break;
                        case 'D':
                            numeroArabigo += 500;
                            break;
                        case 'C':
                            numeroArabigo += 100;
                            break;
                        case 'L':
                            numeroArabigo += 50;
                            break;
                        case 'X':
                            numeroArabigo += 10;
                            break;
                        case 'V':
                            numeroArabigo += 5;
                            break;
                        case 'I':
                            numeroArabigo += 1;
                            break;
                    }
                }
                if(numRomano.Contains("IV"))
                {
                    numeroArabigo -= 2;
                }
                if (numRomano.Contains("IX"))
                {
                    numeroArabigo -= 2;
                }
                if (numRomano.Contains("XL"))
                {
                    numeroArabigo -= 20;
                }
                if (numRomano.Contains("XC"))
                {
                    numeroArabigo -= 20;
                }
                if (numRomano.Contains("CM"))
                {
                    numeroArabigo -= 200;
                }
                if (numRomano.Contains("CD"))
                {
                    numeroArabigo -= 200;
                }
                Console.WriteLine(numeroArabigo);

            }

            //Regex millares = new Regex("^[D]{0,1}[C]{0,3}");
            //Regex centenas = new Regex("^[D]{0,1}[C]{0,3}");
            //Regex decenas = new Regex("^[M]{0,3}");
            //Regex unidades = new Regex("^[M]{0,3}");
            //A pelo, procedimientos y funciones, con objetos, 13, 14, 15
            //C
            //porcentajes 21%
            //los procedimientos anteriores se meterán en la clase
        }
        public static void Ej13()
        {
            int impuesto = 0;            
            string impuestoCadena = "";
            string precioCadena = "";
            bool convertido = false;
            int precio = 0;

            do
            {
                Console.Write("Introduce un impuesto: 4%, 10%, 21%: ");
                impuestoCadena = Console.ReadLine();
                convertido = int.TryParse(impuestoCadena, out impuesto);
            } while (!convertido || (impuesto != 4 && impuesto != 10 && impuesto != 21));

            do
            {
                Console.Write("Introduce un precio: ");
                precioCadena = Console.ReadLine();
                convertido = int.TryParse(precioCadena, out precio);
            } while (!convertido || precio < 1);
          
            precio += (precio * impuesto) / 100;
            Console.WriteLine("Un producto de " + precioCadena +" euros con un impuesto del " + impuestoCadena + "%  es " + precio + " euros");                        
        }
        public static void Ej14()
        {
            int impuesto = 0;
            int precio = 0;
            double precioCalculado = 0;

            impuesto = leerIva();
            precio = leerPrecio();            
            precioCalculado = calcularPrecio(precio, impuesto);

            imprimirPrecioCalculado(precio, impuesto, precioCalculado);

            static int leerPrecio()
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
                return precio;
            }
            static int leerIva()
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
                return impuesto;
            }
            static double calcularPrecio(int precio, int impuesto)
            {
                precio += (precio * impuesto) / 100;
                return precio;
            }
            static void imprimirPrecioCalculado(int precio, int impuesto, double precioCalculado)
            {
                Console.WriteLine("Un producto de " + precio + " euros con un impuesto del " + impuesto + "%  es " + precioCalculado + " euros");
            }
        }
        public static void Ej15()
        {
            productoIVA producto = new productoIVA();
            producto.imprimirPrecioTotal();

        }
        public static void Ej16()
        {
            Console.WriteLine("Convertidor de euros a pesetas con programación 'secuencial'");

            double pesetas = 166.386;
            bool convertido = false;
            double euros = 0;

            do
            {
                Console.Write("Escribe una cantidad en euros: ");                
                convertido = Double.TryParse(Console.ReadLine(), out euros);
            } while (!convertido);

            pesetas *= euros;

            Console.WriteLine(euros + " euros son " + pesetas + " pesetas");
            Console.WriteLine();
        }
        public static void Ej17()
        {
            Console.WriteLine("Convertidor de euros a pesetas con programación 'secuencial'");
            double pesetas;
            double euros;

            euros = leerEuros();
            pesetas = conversionPesetas(euros);
            imprimirConversionPesetas(euros, pesetas);


            static double leerEuros()
            {
                bool convertido;
                double euros;
                do
                {
                    Console.Write("Escribe una cantidad en euros: ");
                    convertido = Double.TryParse(Console.ReadLine(), out euros);
                } while (!convertido);
                return euros;
            }
            static double conversionPesetas(double euros)
            {
                return euros * 166.386;
            }
            static void imprimirConversionPesetas(double euros, double pesetas)
            {
                Console.WriteLine(euros + " euros son " + pesetas + " pesetas");
                Console.WriteLine();
            }
        }
        static void Ej18()
        {
            conversorEuroPeseta nuevaconversion = new conversorEuroPeseta();
            nuevaconversion.setEuros();
            nuevaconversion.setPesetas();
            nuevaconversion.imprimirPesetas();
        }
        static void Main()
        {
            //De euros a pesetas
            //Ej16();
            //Ej17();
            //Ej18();
            Ej12();
            //mostrar con diversas cifras decimales, float f, double sin nada, decimal con m, rollo 4.14f o 3.14m

        }
    }
}
