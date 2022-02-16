using System;

namespace ConsolaCalculadora
{

    internal class Program
    {

        private static double Suma(double a, double b)
        {
            return a + b;
        }

        private static double Resta(double a, double b)
        {
            return a - b;
        }

        private static double Multiplicacion(double a, double b)
        {
            return a * b;
        }

        private static double Division(double a, double b)
        {
            return a / b;
        }

        private static void Numeroprimo()
        {
            int n, i, c;
            c = 0;
            Console.WriteLine("INGRESE UN NUMERO");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    c = c + 1;
                }
            }

            if (c > 2)
            {
                Console.WriteLine("NO ES PRIMO__", n);
            }

            else
            {
                Console.WriteLine("ES PRIMO__", n);
            }

            Console.ReadLine();
        }

        private static void Palindromo()
        {
            Console.WriteLine("INGRESE UN NUMERO");
            int entrada = int.Parse(Console.ReadLine());
            int respaldo = entrada;
            int recordar, reversa = 0;

            while (entrada > 0)
            {
                recordar = entrada % 10;
                reversa = reversa * 10 + recordar;
                entrada = entrada / 10;
            }

            if (respaldo == reversa)
            {
                Console.WriteLine("EL NUMERO ES PALINDROMO");
            }

            else
            {
                Console.WriteLine("EL NUMNERO NO ES PALINDROMO");
            }

            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("---CALCULADORA---");
            Console.WriteLine("---------------------");
            Console.WriteLine("INTRODUZCA EL PRIMER NUMERO");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("INTRODUZCA EL SEGUNDO NUMERO");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ESCOGA UNA OPCION");
            Console.WriteLine("1.SUMA \n 2.RESTA \n 3.MULTIPLICACION \n 4.DIVISION \n 5.VERIFICACION NUMERO PRIMO \n 6.VERIFICACION NUMERO PALINDROMO ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine(Suma(a, b));
                    break;
                case 2:
                    Console.WriteLine(Resta(a, b));
                    break;
                case 3:
                    Console.WriteLine(Multiplicacion(a, b));
                    break;
                case 4:
                    Console.WriteLine(Division(a, b));
                    break;
                case 5:
                    Program.Numeroprimo();
                    break;
                case 6:
                    Program.Palindromo();
                    break;

                default:
                    Console.WriteLine("OPCION INVALIDA");
                    break;
            }

            Console.ReadLine();
        }
    }
}
