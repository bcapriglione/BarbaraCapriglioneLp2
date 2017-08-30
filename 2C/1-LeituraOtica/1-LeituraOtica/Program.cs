using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i=0;
            string[] resp = new string[1000001];
            n = Convert.ToInt32(Console.ReadLine());

            while (i<n)
            {
                int A, B, C, D, E;

                A = Convert.ToInt32(Console.ReadLine());
                B = Convert.ToInt32(Console.ReadLine());
                C = Convert.ToInt32(Console.ReadLine());
                D = Convert.ToInt32(Console.ReadLine());
                E = Convert.ToInt32(Console.ReadLine());

                if ((A <= 100) && (B >= 155) && (C >= 155) && (D >= 155) && (E >= 155))
                    resp[i] = "A";
                else if ((A >= 155) && (B <= 100) && (C >= 155) && (D >= 155) && (E >= 155))
                    resp[i] = "B";
                else if ((A >= 155) && (B >= 155) && (C <= 100) && (D >= 155) && (E >= 155))
                    resp[i] = "C";
                else if ((A >= 155) && (B >= 155) && (C >= 155) && (D <= 100) && (E >= 155))
                    resp[i] = "D";
                else if ((A >= 155) && (B >= 155) && (C >= 155) && (D >= 155) && (E <= 100))
                    resp[i] = "E";
                else
                    resp[i] = "*";
                i++;

            }

            i = 0;
            while(i<n)
            {
                Console.WriteLine(resp[i]);
                i++;
            }
        }
    }
}
