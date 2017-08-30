using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___CodigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int iniciar;                
                mensagem txt = new mensagem();
                txt.txt = Console.ReadLine();
                string[] exibir = new string[txt.txt.Length];
                iniciar = Convert.ToInt32(Console.ReadLine());
                if (iniciar == 1)
                {
                    exibir = txt.codificar();
                    int i = 0;
                    while(i<txt.txt.Length)
                    {
                        Console.WriteLine(exibir[i]);
                    }
                }

            }
        }
    }
}
