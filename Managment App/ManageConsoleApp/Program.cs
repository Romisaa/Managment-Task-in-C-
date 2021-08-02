using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Text;

namespace ManageConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool restart = true;
            FileStream newFile = new FileStream(@"R:\Romisaa\C#\Managment App", FileMode.OpenOrCreate);
            Queue<user> queueUser = new Queue<user>(3);

            if (queueUser.Count == 0)
            {
                Console.WriteLine("Please, Enter Your Name, Age, and Email: ");
                user User1 = new user(Console.ReadLine());
                Console.WriteLine("Please, Enter Your Name, Age, and Email: ");
                user User2 = new user(Console.ReadLine());
                Console.WriteLine("Please, Enter Your Name, Age, and Email: ");
                user User3 = new user(Console.ReadLine()); 

                // Enqueue Method
                queueUser.Enqueue(User1);
                queueUser.Enqueue(User2);
                queueUser.Enqueue(User3);
                Console.WriteLine(queueUser.Count);

            }else
            { 
                // Dequeue Method
                user usr1 = queueUser.Dequeue();
                Console.WriteLine("Items Left in the Queue is: " + queueUser.Count);
                user usr2 = queueUser.Dequeue();
                Console.WriteLine("Items Left in the Queue is: " + queueUser.Count);
                user usr3 = queueUser.Dequeue();
                Console.WriteLine("Items Left in the Queue is: " + queueUser.Count);

            }


            string textFilePath = @"R:\Romisaa\C#\Managment App\testFile1.txt";
            File.WriteAllLines(textFilePath, queueUser);

            foreach (string usr in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine(queueUser);
            }


        Console.ReadKey();
           
            


            



        }
    }
}
