using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace objnoplano
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int A = 600, L = 800;

            Console.WriteLine("informe a posição inicial de x");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("informe a posição inicial de y");
            y = int.Parse(Console.ReadLine());

            while (true)
            {
                obj2d obj = new obj2d();
                obj.x = x;
                obj.y = y;
                Console.WriteLine("escreva o comando");
                ConsoleKey comando = Console.ReadKey().Key;

                if (comando == ConsoleKey.RightArrow)
                {
                   obj.soma();
                   Console.WriteLine(obj.parord());
                }
                
            }


        }
    }
}
