using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Singleton
{
    public class Singleton
    {
        //create an object of SingleObject
        private static readonly Singleton instance = new Singleton();

        //make the constructor private so that this class cannot be instantiated
        private Singleton() { }

        //Get the only object available
        public static Singleton GetInstance()
        {
            return instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
