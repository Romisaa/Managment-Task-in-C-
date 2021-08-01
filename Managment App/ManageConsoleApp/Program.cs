using System;
using System.Collections.Generic;

namespace ManageConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            queueArray obj = new queueArray(6);
            obj.enqueue(Console.ReadLine());
            obj.enqueue(Console.ReadLine());
            obj.enqueue(Console.ReadLine());
            obj.enqueue(Console.ReadLine());
            obj.enqueue(Console.ReadLine());
            obj.enqueue(Console.ReadLine());

            Console.WriteLine(obj.dequeue());
            Console.WriteLine(obj.dequeue());
            Console.WriteLine(obj.dequeue());

            Console.WriteLine(obj.isempty());







        }
    }
}
