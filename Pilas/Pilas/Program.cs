using System;
using System.Collections.Generic;

namespace Pilas
{
    class Program
    {
         
        
            //-------------------------------Ejercicio de pilas--------------------------------//

            //Nombres de personas el ultimo ingresado es el mas accesible 
            //Push es para poder añadir o apilar nuevos elementos
            public static void Main()
            {
                Stack<string> nombre = new Stack<string>();
                nombre.Push("Judith");
                nombre.Push("Azucena");
                nombre.Push("Ingrid");
                nombre.Push("Jarleza");
                nombre.Push("Isabel");
                nombre.Push("Julia");
                nombre.Push("Elena ");
                nombre.Push("Damaris");
                nombre.Push("Marbely");


                // El Foreach es para poder imprimir los nombres ingresados con un console.WriteLine

                foreach (string nombres in nombre)
                {
                    Console.WriteLine(nombres);
                }

                //Pop es para eliminar el elemento superior de la pila 

                //Peek 

                Console.WriteLine("\nPopping/ Eliminando '{0}'", nombre.Pop());

                Console.WriteLine("Peek/viendo en el siguiente item a desapilar: {0}",
                    nombre.Peek());

                Console.WriteLine("\nPopping/ Eliminando '{0}'", nombre.Pop());

                Console.WriteLine("Peek/viendo en el siguiente item a desapilar: {0}",
                    nombre.Peek());

                Console.WriteLine("\nPopping/ Eliminando '{0}'", nombre.Pop());

                Console.WriteLine("Peek/viendo en el siguiente item a desapilar: {0}",
                    nombre.Peek());

                Console.WriteLine("\nPopping/ Eliminando '{0}'", nombre.Pop());


                // Creamos una de la pila stack, usando el método ToArray y el
                // el constructor que acepta el acceso a IEnumerable<T>.

                Stack<string> stack2 = new Stack<string>(nombre.ToArray());

                Console.WriteLine("\nContenido de la primer copia:");
                foreach (string nombres in stack2)
                {
                    Console.WriteLine(nombres);
                }

                // Crea una matriz o arreglo dos veces el tamaño de la pila y copie el
                // elementos de la pila, comenzando en la mitad de la
                //  formación.

                string[] array2 = new string[nombre.Count * 2];
                nombre.CopyTo(array2, nombre.Count);

                // Crea una segunda pila, usando el constructor que acepta un
                // IEnumerable(Of T).

                Stack<string> stack3 = new Stack<string>(array2);

                Console.WriteLine("\nContenido de la segunda copia, con duplicados y nulos:");
                foreach (string nombres in stack3)
                {
                    Console.WriteLine(nombres);
                }

                Console.WriteLine("Verificando si contiene la pila2 el elemento Marbely");
                Console.WriteLine("\nstack2.Contains/ la pila2 contiene (\"Marbely\") = {0}",
                    stack2.Contains("\nMarbely"));

                Console.WriteLine("\nVerificando si contiene la pila2 el elemento Judith");
                Console.WriteLine("\nstack2.Contains/ la pila2 contiene (\"Judith\") = {0}",
                    stack2.Contains("Judith"));

                Console.WriteLine("\nVerificando si contiene la pila2 el elemento Azucena");
                Console.WriteLine("\nstack2.Contains/ la pila2 contiene (\"Azucena\") = {0}",
                    stack2.Contains("Azucena"));

                Console.WriteLine("\nLimpiando la pila2");

                Console.WriteLine("\nstack2.Clear()");
                stack2.Clear();

                Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
            }
    }
}
 