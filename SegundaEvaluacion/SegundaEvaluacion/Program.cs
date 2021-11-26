using System;
using System.Collections.Generic;

namespace SegundaEvaluacion
{
    class Program
    {
        public static void ListaSinDelegadosNiLambda()
        {
            List<int> lista = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine("Todos los números de la lista");
            foreach(int numero in lista)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Todos los números pares de la lista");
            foreach (int numero in lista)
            {
                if (numero % 2 == 0)
                    Console.Write(numero + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Todos los números de la lista entre 3 y 7");
            foreach (int numero in lista)
            {
                if (numero > 2 && numero < 8)
                    Console.Write(numero + " ");
            }
            Console.WriteLine();
        }
        //public static void Ej55()
        //{
        //    List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    Console.WriteLine("Todos los números pares de la lista");
        //    foreach (int numero in lista)
        //    {
        //        if(numero % 2 == 0)
        //            Console.Write(numero + " ");
        //    }
        //    Console.WriteLine();
        //}
        //public static void Ej56()
        //{
        //    List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    Console.WriteLine("Todos los números de la lista entre 3 y 7");
        //    foreach (int numero in lista)
        //    {
        //        if (numero > 2 && numero < 8)
        //            Console.Write(numero + " ");
        //    }
        //    Console.WriteLine();
        //}
        static bool EsPar(int n)
        {
            bool esPar;
            if (n % 2 == 0)
                esPar = true;
            else
                esPar = false;
            return esPar;
        }
        static bool EsRango(int n)
        {
            bool esRango;
            if (n > 2 && n < 8)
                esRango = true;
            else
                esRango = false;
            return esRango;
        }
        static void DelegadosGenericos() //examen
        {
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Todos los números de la lista");
            foreach (int numero in lista)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            Predicate<int> delegadoPar = new Predicate<int>(EsPar);
            List<int> listaPares = lista.FindAll(delegadoPar);
            Console.WriteLine("Todos los números pares de la lista");
            foreach (int numero in listaPares)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            Predicate<int> delegadoRango = new Predicate<int>(EsRango);
            List<int> listaRango = lista.FindAll(delegadoRango);
            Console.WriteLine("Todos los números de la lista entre 3 y 7");
            foreach (int numero in listaRango)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }
        static void Lambda1() //examen
        {
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Todos los números de la lista");
            foreach (int numero in lista)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            List<int> listaPares = lista.FindAll(numero => EsPar(numero));
            Console.WriteLine("Todos los números pares de la lista");
            foreach (int numero in listaPares)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            List<int> listaRango = lista.FindAll(numero => EsRango(numero));
            Console.WriteLine("Todos los números de la lista entre 3 y 7");
            foreach (int numero in listaRango)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }
        static void lambda2()
        {
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };            
            Console.WriteLine("Todos los números de la lista");
            foreach (int numero in lista)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
            
            List<int> listaPares = lista.FindAll(numero =>
            {
                bool esPar;
                if (numero % 2 == 0)
                    esPar = true;
                else
                    esPar = false;
                return esPar;
            });
            Console.WriteLine("Todos los números pares de la lista");
            foreach (int numero in listaPares)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            List<int> listaRango = lista.FindAll(numero =>
            {
                bool esRango;
                if (numero > 2 && numero < 8)
                    esRango = true;
                else
                    esRango = false;
                return esRango;
            });
            Console.WriteLine("Todos los números de la lista entre 3 y 7");
            foreach (int numero in listaRango)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }
        static void Lambda3()
        {
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Todos los números de la lista");
            foreach (int numero in lista)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            List<int> listaPares = lista.FindAll(numero => (numero % 2) == 0);
            Console.WriteLine("Todos los números pares de la lista");
            foreach (int numero in listaPares)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            List<int> listaRango = lista.FindAll(numero => (numero > 2 && numero < 8));
            Console.WriteLine("Todos los números de la lista entre 3 y 7");
            foreach (int numero in listaRango)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Lambda3();
        }
    }
}
