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
            int n;
            n = int.Parse(Console.ReadLine());
            string[] resposta = new string [1000001];
            for (int i=0; i < n; i++)
            {
                int A, B, C, D, E;

                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                C = int.Parse(Console.ReadLine());
                D = int.Parse(Console.ReadLine());
                E = int.Parse(Console.ReadLine());

                if ((A <= 100) && (B >= 155) && (C >= 155) && (D >= 155) && (E >= 155)) 
                {
                    resposta[i] = "A";
                }
                    
                else if ((A >= 155) && (B <= 100) && (C >= 155) && (D >= 155) && (E >= 155))
                {
                    resposta[i] = "B";
                }
                else if ((A >= 155) && (B >= 155) && (C <= 100) && (D >= 155) && (E >= 155))
                {
                   resposta[i] = "C";
                }
                else if ((A >= 155) && (B >= 155) && (C >= 155) && (D <= 100) && (E >= 155))
                {
                   resposta[i] = "D";
                }
                else if ((A >= 155) && (B >= 155) && (C >= 155) && (D >= 155) && (E <= 100))
                {
                    resposta[i] = "E";
                }
                else
                {
                    resposta[i] = "*";
                }

            }

            for (int i=0; i<n; i++)
            {
                Console.WriteLine("{0}", resposta[i]);
            }



            }


        }
    }

