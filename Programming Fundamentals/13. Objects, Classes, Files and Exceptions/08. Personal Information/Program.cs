using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;



class Program
{
    static void Main()
    {


        int n = int.Parse(Console.ReadLine());
        while (true)
        {
            try 
            {
                MyPersonalException(n);
                Console.WriteLine(n);
            }
            catch
            {
                Console.WriteLine("My first exception is awesome!!!");
            }
            n = int.Parse(Console.ReadLine());
        }
       
        
    }

    static void MyPersonalException(int n)
    {
        if (n < 0)
        {
            throw new System.ArgumentException("My first exception is awesome!!!");
        }

    }
}

