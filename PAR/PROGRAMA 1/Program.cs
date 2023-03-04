using System;

class Program
{

    static void Main()
    {
        int N, suma = 0;

        Console.Write("Por favor ingrese un numero entero positivo mayor que 0. ");
        N = Convert.ToInt32(Console.ReadLine());

        //utlizamos for para incrementar N y calcular la suma de los primeros N numeros enteros positivos.
        for (int i = 1; i <= N; i++)
        {
            suma += i;
        }

        Console.WriteLine("Los numeros positivos menores o iguales a {0} son:", N);


        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine("{0} ", i);
        }
        Console.WriteLine();

        Console.WriteLine("Los numeros enteros impares menores o iguales que {0} son: ", N);

        for (int i = 1; i <= N; i += 2)
        {
            Console.WriteLine("{0} ", i);
        }
        Console.WriteLine();

        Console.WriteLine("Tabla de multiplicar del numero {0}", N);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} * {1} = {2}", N, i, N * i);

            int j = N;
            while (j <= 20)
            {
                Console.WriteLine("{0} ", j);
                j += 2;
            }
        }
        Console.WriteLine();

        Console.WriteLine("La suma de los primeros {0} numeros enteros positivos es: {1}", N, suma);

        Console.WriteLine();
    }
}
