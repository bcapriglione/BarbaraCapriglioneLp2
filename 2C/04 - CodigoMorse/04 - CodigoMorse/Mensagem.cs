using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___CodigoMorse
{
    class mensagem
    {
        public string txt;

        string[] tabela = new string[26] 
        {
            ".-", "-...", "-.-.","-..",".","..-.","--.","....","..",
            ".---","-.-", ".-..", " --", "-.", "---", ".--.", "--.- ", 
            ".-.", "...", "-", "..-", "...-", ".--", " -..-", "-.--", "--.."
        };

        char[] tabela2 = new char[26]
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
        };

        public string[] codificar ()
        {
            int i = 0;
            string[] retorno = new string [txt.Length];
            int[] posiçao = new int[26];
            while (i<txt.Length)
            {
                posiçao[i] = txt[i] - 'A';
                i++;
            }

            i = 0;

            
                       
            while (i<txt.Length)
            {
               retorno[i] = tabela[posiçao[i]];
            }

            return (retorno);
        
        }

        public void decodificar ()
        {
            int i = 0;
            while(i<txt.Length)
            {


            }
            

            
        }
       

         
        

        

    }
}
