using System;

namespace _01._Singleton
{
    /// <summary>
    /// The singleton pattern is a design pattern that restricts the instantiation of a class to one object.
    /// </summary>
    class StartUp
    {
        static void Main(string[] args)
        {
            //illegal construct
            //Compile Time Error: The constructor SingleObject() is not visible
            //Singleton newIstance = new Singleton();

            //Get the only object available
           // _Singleton singleton = Singleton.GetInstance();

            //show the message
            //singleton.ShowMessage();
        }
    }
}
