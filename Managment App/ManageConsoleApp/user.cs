using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ManageConsoleApp
{
    public class user
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public string Email {get; set;}
        public string textFilePath {get; set;}

        public user(string Name, int Age, string Email)
        {
            this.Name = Name;
            this.Age = Age;
            this.Email = Email;
            Console.WriteLine("Working");
        }

        public user(string v)
        {
        }
    }

}