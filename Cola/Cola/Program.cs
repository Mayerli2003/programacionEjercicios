using System;
using System.Collections;


namespace Cola
{
    class Program
    {//------------------------------Ejercicio de cola-------------------------------//
         public static void Main()
        {
            // Creando e inicializando una Queue.
            Queue numero = new Queue();
            numero.Enqueue("1");
            numero.Enqueue("2");
            numero.Enqueue("3");
            numero.Enqueue("4");
            numero.Enqueue("5");
            numero.Enqueue("6");
            numero.Enqueue("7");

            //Mostrando las propiedades y valores de Queue.
            Console.WriteLine("\n Elementos guardados en la cola numero: ");
            
            Console.WriteLine("\n Conteo de la cantidad de elementos en la cola : {0}", numero.Count);
            Console.Write("\nValores dentro de la cola:");
            PrintValues(numero);
            Console.WriteLine("\n Mostrando primer elemento sin remover (Peek)   : {0}", numero.Peek());

            // Removiendo un elemento de Queue.
            Console.WriteLine("\n Removiendo un elemento (Dequeue) : {0}", numero.Dequeue());

            // Mostrando elementos de la Queue.
            Console.Write("\n Mostrando la actualización de valores Queue :");
            PrintValues(numero);
            Console.WriteLine("\n Conteo de la cantidad de elementos en la cola : {0}", numero.Count);

            // Removiendo otro elemento de la Queue.
            Console.WriteLine("\n Removiendo otro elemento (Dequeue) : {0}", numero.Dequeue());

            // Mostrando la Queue.
            Console.Write("\n Mostrando la actualización de  valores Queue:");
            PrintValues(numero);

            Console.WriteLine("\n Conteo de la cantidad de elementos en la cola : {0}", numero.Count);

            //Viendo el primer elemento de la Queue pero sin removerlo.
            Console.WriteLine("\n Mostrando primer elemento sin remover (Peek) : {0}", numero.Peek());

            //Removiendo otro elemento
            Console.WriteLine("\n Removiendo un elemento (Dequeue) : {0}", numero.Dequeue());

            //Mostrando la  Queue.
            Console.Write("\n Mostrando la actualización de  valores Queue:");
            PrintValues(numero);

            // Limpiando los valores en la Queue.
            numero.Clear();

            // Mostrado los valores en la Queue.
            Console.WriteLine("\n Después de limpiar");
            Console.WriteLine("\n Count/ Conteo de los valores    : {0}", numero.Count);
            Console.Write("\n Valores en la cola:");
            PrintValues(numero);
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("\t {0}", obj);
            Console.WriteLine();
        }

    }
}

