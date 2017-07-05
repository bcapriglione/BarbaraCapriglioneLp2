using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Informe o valor de x");
            x = int.Parse(Console.ReadLine());


            mec obj = new mec();
            obj.y = x;
            obj.metodo();
            Console.ReadKey();
        }
    }
}
