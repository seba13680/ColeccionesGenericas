using System;
using System.Collections.Generic;

namespace ColeccionesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilaEnteros = new Stack<int>();

            pilaEnteros.Push(1);
            pilaEnteros.Push(2);
            pilaEnteros.Push(3);
            pilaEnteros.Push(4);
            pilaEnteros.Push(5);
            pilaEnteros.Push(6);
            pilaEnteros.Push(7);
            pilaEnteros.Push(8);
            pilaEnteros.Push(9);
            pilaEnteros.Push(10);

            foreach (Object item in pilaEnteros)
            {
                Console.WriteLine(item);
            }
            
            Queue<int> colaEnteros = new Queue<int>();

            colaEnteros.Enqueue(1);
            colaEnteros.Enqueue(2);
            colaEnteros.Enqueue(3);
            colaEnteros.Enqueue(4);
            colaEnteros.Enqueue(5);
            colaEnteros.Enqueue(6);
            colaEnteros.Enqueue(7);
            colaEnteros.Enqueue(8);
            colaEnteros.Enqueue(9);
            colaEnteros.Enqueue(10);

            foreach (Object items in colaEnteros)
            {
                Console.WriteLine(items);
            }
                        
            Stack<string> pilaCadena = new Stack<string>();
            pilaCadena.Push("1- Ada");
            pilaCadena.Push("2- Eva");
            pilaCadena.Push("3- Ines");
            pilaCadena.Push("4- Juliana");
            pilaCadena.Push("5- Carolina");
            pilaCadena.Push("6- Maria");
            pilaCadena.Push("7- Camila");
            pilaCadena.Push("8- Verónica");
            pilaCadena.Push("9- Anabel");
            pilaCadena.Push("10- Ludmila");

            foreach (Object itemCadena in pilaCadena)
            {
                Console.WriteLine(itemCadena);
            }

            Queue<string> colaCadena = new Queue<string>();
            colaCadena.Enqueue("1- Aldo");
            colaCadena.Enqueue("2- Cristian");
            colaCadena.Enqueue("3- Marcos");
            colaCadena.Enqueue("4- Facundo");
            colaCadena.Enqueue("5- Mariano");
            colaCadena.Enqueue("6- Lucas");
            colaCadena.Enqueue("7- Leonardo");
            colaCadena.Enqueue("8- Marcelo");
            colaCadena.Enqueue("9- Pablo");
            colaCadena.Enqueue("10- Daniel");

            foreach (Object item in colaCadena)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
