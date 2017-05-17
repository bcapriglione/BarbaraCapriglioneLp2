using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            string data, mes, dia, ano; 
            
            Console.WriteLine("informe a data");
            data = Console.ReadLine();

            mes = data.Substring(3, 2);
            dia = data.Substring(0, 2);
            ano = data.Substring(6, 4);

            switch (mes)
            {
                case"01":
                    mes = " de janeiro";
                    break;

                case "02":
                    mes = "de fevereiro";
                    break;

                case "03":
                    mes = "de março";
                    break;

                case "04":
                    mes = "de abril";
                    break;

                case "05":
                    mes = "de maio";
                    break;

                case "06":
                    mes = "de junho";
                    break;

                case "07":
                    mes = "de julho";
                    break;

                case "08":
                    mes = "de agosto";
                    break;

                case "09":
                    mes = " de setembro";
                    break;

                case "10":
                    mes = "de outubro";
                    break;

                case "11":
                    mes = "de novembro";
                    break;

                case "12":
                    mes = "de dezembro";
                    break;
            }

            Console.WriteLine("{0} {1} de {2}", dia, mes, ano);
            Console.ReadKey();
        }
    }
}
