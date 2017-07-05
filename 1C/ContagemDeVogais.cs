using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contagem_de_Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt;
            int qtd=0;
            Console.WriteLine(" escreva seu texto");
            txt= Console.ReadLine().ToUpper();
             
            for (int i=0; i < txt.Length; i++)
            {
                if (txt[i]== 'A' || txt[i] == 'E' || txt[i] == 'I' || txt[i]== 'O' || txt[i]== 'U')
                {
                    qtd++;

                }
                else
                {
                    qtd = qtd;
                }

            }
            Console.WriteLine(qtd);
            Console.ReadKey();

                
                

                
            
        }
    }
}
