using System;

namespace _01._Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //illegal construct
            //Compile Time Error: The constructor SingleObject() is not visible
            //Singleton newIstance = new Singleton();

            //Get the only object available
            Singleton singleton = Singleton.GetInstance();

            //show the message
            singleton.ShowMessage();
        }
    }
}
