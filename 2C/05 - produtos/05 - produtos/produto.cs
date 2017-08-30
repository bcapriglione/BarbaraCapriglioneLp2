using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___produtos
{
    class produto
    {
        private int id;
 
            public int Id
        {
            get { return id; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
        }

        public double Preco { get; set; }

        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
        }


        public produto (int id,string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.Preco = Preco;
            this.quantidade = 0;

        }

        public void Repor(int n)
        {
            quantidade += n;
        }

        public void Retirar(int n)
        {
            if (quantidade > n)
                quantidade -= n;
            else
                Console.WriteLine("Erro");
        
        }
            
            
            
           
        

    
    }
}
