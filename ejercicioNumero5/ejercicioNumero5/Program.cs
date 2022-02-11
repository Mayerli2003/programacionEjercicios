using System;

namespace ejercicioNumero5
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            Console.WriteLine("Ingrese un valor entero para X");
            X = int.Parse(Console.ReadLine());
            int Y;
            Console.WriteLine("Ingrese un valor entero para Y");
            Y = int.Parse(Console.ReadLine());
            double N;
            Console.WriteLine("Ingrese un valor  para N");
            N = double.Parse(Console.ReadLine());
            double M;
            Console.WriteLine("Ingrese un valor  para M");
            M = double.Parse(Console.ReadLine());

            Console.WriteLine("El valor de cada variable ");
            Console.WriteLine("Variable X " + X);
            Console.WriteLine("Variable Y " + Y);
            Console.WriteLine("Variable N " + N);
            Console.WriteLine("Variable M " + M);

            Console.WriteLine("La suma de  X + Y: " + X + " + " + Y + " = " + (X + Y));

            Console.WriteLine("La diferencia   X - Y: " + X + " - " + Y + " = " + (X - Y));

            Console.WriteLine("El producto  X * Y: " + X + " * " + Y + " = " + (X * Y));

            Console.WriteLine("El cociente X / Y: " + X + " / " + Y + " = " + (X / Y));

            Console.WriteLine("El resto de  X % Y: " + X + " % " + Y + " = " + (X % Y));

            Console.WriteLine("La suma de  N + M: " + N + " + " + M + " = " + (N + M));

            Console.WriteLine("La diferencia de  N - M: " + N + " - " + M + " = " + (N - M));

            Console.WriteLine("El producto de  N + M: " + N + " * " + M + " = " + (N * M));

            Console.WriteLine("El cociente  de  N / M: " + N + " / " + M + " = " + (N / M));

            Console.WriteLine("La suma de  X +  N: " + X + " + " + N + " = " + (X + N));

            Console.WriteLine("El cociente  de  Y / M: " + Y + " / " + M + " = " + (Y / M));

            Console.WriteLine("El resto de  Y % M: " + Y + " % " + M + " = " + (Y % M));

            Console.WriteLine("El doble de cada variable: ");

            Console.WriteLine("El doble de la variable X : " + X + " es " + (2 * X));

            Console.WriteLine("El doble de la variable Y : " + Y + " es " + (2 * Y));

            Console.WriteLine("El doble de la variable N : " + N + " es " + (2 * N));

            Console.WriteLine("El doble de la variable M : " + M + " es " + (2 * M));

            Console.WriteLine("La suma de todas las variables X + Y + N + M = " + (X + Y + N + M));

            Console.WriteLine("El producto de todas las variables X * Y * N * M = " + (X * Y * N * M));
        }
    }
}
