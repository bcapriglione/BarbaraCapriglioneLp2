using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
       


        static void Main(string[] args)
        {

            int qntdveiculo, potenciamotor, i=0;
            string modelo, carro, potencia;
            double quilometragem;

            Console.WriteLine("Informe o numero de veiculos");
            qntdveiculo = Convert.ToInt32(Console.ReadLine());

            while (i < qntdveiculo)
            {

            Console.WriteLine("Informe o modelo ");
            modelo = Console.ReadLine();

            Console.WriteLine("Informe a quilometragem rodada");
            quilometragem = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a potencia do motor ");
            potenciamotor = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("{0}, {1}, {2}", modelo, carro, potencia);
                if (quilometragem <= 5000)
              {
                  carro = "Novo";

              }
              else if ( quilometragem > 5000 && quilometragem <= 30000)
              {
                  carro = "Seminovo";
              }
              else
              {
                  carro= "Velho";
              }

              if (potenciamotor >200)
              {
                  potencia = "Potente";
              }
                else if (potenciamotor >= 120 && potenciamotor <= 200)
              {
                  potencia = "Forte";
              }
              else
              {
                  potencia = "Popular";
              }
              return classificar;
                
            }
       

 
              

        
        
        
        }
        public static string classificar (string modelo,double quilometragem,int potenciamotor)
        {
            if (quilometragem <= 5000)
            {
                carro = "Novo";

            }
            else if (quilometragem > 5000 && quilometragem <= 30000)
            {
                carro = "Seminovo";
            }
            else
            {
                carro = "Velho";
            }

            if (potenciamotor > 200)
            {
                potencia = "Potente";
            }
            else if (potenciamotor >= 120 && potenciamotor <= 200)
            {
                potencia = "Forte";
            }
            else
            {
                potencia = "Popular";
            }
        }
           
    

        }
    }

