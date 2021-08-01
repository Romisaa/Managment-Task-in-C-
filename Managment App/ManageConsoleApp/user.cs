using System;
using System.Collections.Generic;

namespace ManageConsoleApp
{
    class user
    {
        public int Head;
        public int Tail;
        public int count;
        public int[] arr;
        public queueArray(int size)
        {
            arr = new int[size];
            Head = Tail = count = 0;
        }

        public void enqueue(int value)
        {
            if(Tail == arr.Length)
            {
                Console.WriteLine("Queue is Full");
            }else{
                arr[Tail] = value;
                Tail++;
                count++;
            }
            

        }
        public int dequeue()
        {
            int value;
            
            if(count == 0)
            {
                Console.WriteLine("Empty");
            }else
            {
               value = arr[Head];
                Head++;
                count--; 
            }
            return value;
                    
        }
        public bool isempty()
        {
            if(count == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
}
}