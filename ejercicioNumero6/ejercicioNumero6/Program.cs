using System;

namespace ejercicioNumero6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int A;
            Console.WriteLine("Ingrese un valor entero para A");
            A = int.Parse(Console.ReadLine());

            int B ;
            Console.WriteLine("Ingrese un valor entero para B");
            B = int.Parse(Console.ReadLine());

            int C ;
            Console.WriteLine("Ingrese un valor entero para C");
            C = int.Parse(Console.ReadLine());

            int D ;
            Console.WriteLine("Ingrese un valor entero para D");
            D = int.Parse(Console.ReadLine());

            Console.WriteLine("Valores iniciales");

            Console.WriteLine("A=" + A);
            Console.WriteLine("B=" + B);
            Console.WriteLine("C=" + C);
            Console.WriteLine("D=" + D);

            Console.WriteLine("Valores finales");

            Console.WriteLine(" B toma el valor de C → B=" + C);
            Console.WriteLine(" C toma el valor de A → C=" + A);
            Console.WriteLine(" A toma el valor de D → A=" + D);
            Console.WriteLine(" D toma el valor de B → D=" + B);
        }
        
    }
}
