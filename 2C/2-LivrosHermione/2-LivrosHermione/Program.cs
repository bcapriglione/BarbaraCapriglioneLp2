using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LivrosHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i=0,phr,totalpags=0;
            double diasparaler;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe quantas pgs pode ler por hr");
            phr = Convert.ToInt32(Console.ReadLine());
            livro[] a = new livro[n];
            while(i<n)
            {
                a[i] = new livro();
                a[i].titulo = Console.ReadLine();
                a[i].pags = Convert.ToInt32(Console.ReadLine());
                a[i].diasdev = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            i=0;
            while (i < n)
            {
                totalpags = totalpags + a[i].pags;
                i++;
            }

            double sla;
            sla = totalpags / phr;
            Console.WriteLine(sla/24);
        }
    }
}
