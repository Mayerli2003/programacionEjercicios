using System;

namespace ejercicioNumero7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("Ingrese un valor entero para A");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("El valor : " + A + (A % 2 == 0 ? " es par ": "es impar "));
        }
    }
}
