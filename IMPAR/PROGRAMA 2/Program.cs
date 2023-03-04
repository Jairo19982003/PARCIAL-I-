using System;

namespace Parcial_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Favor de ingresar un numero entero positivo mayor que cero. ");
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;
            for(int i = 1; i <= n; i++)
            {
                factorial *= 1;
            }

            Console.WriteLine("El factorial de {0} es {1}", n, factorial);

            Console.WriteLine("Los numeros enteros menores o iguales a {0} y divisibles entre 3 son: ", n);
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Los Numeros enteros menores o iguales a {0} y divisibles entre 5 son: ", n);
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Secuencia de numeros aumentandolos de 2  en dos hasta llegar a {0} es: ", n);

            int j = 1;
            while ( j <= n)
            {
                Console.WriteLine("{0} ", j);
                j += 2;
            }
            Console.WriteLine();

            Console.WriteLine("El factorial de {0} es {1}", n, factorial);
        }
    }
}