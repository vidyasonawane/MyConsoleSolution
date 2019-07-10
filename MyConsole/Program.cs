using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDll;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Vidya from myconsole.!!!");
            Class1 cls = new Class1();
            Console.WriteLine(cls.method());
        }
    }
}
