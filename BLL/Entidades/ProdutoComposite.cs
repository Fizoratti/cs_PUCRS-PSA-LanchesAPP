using System;
using System.Collections.Generic;

namespace BLL.Entidades
{
    public class ProdutoComposite : IProduto
    {
        public ProdutoComposite()
        {
           
        }

        public int Codigo { get; set; }

        public String Nome { get; set; }

        public decimal Preco {
            get
            {
                decimal total = 0m;
                foreach (IProduto p in produtos)
                {
                    total += p.Preco;
                }
                return total - (total * 10 / 100m);
            }
            set { }
        }

        private  List<IProduto> produtos = new List<IProduto>();


        void adicionarProduto(IProduto produto)
        {
            produtos.Add(produto);
        }

        IProduto getProduto(int codigo)
        {
            IProduto produto = new Produto();
            foreach (IProduto p in produtos)
            {
                if (p.Codigo == codigo)
                {
                    produto = p;
                }
            }
            return produto;
        }

        public override string ToString()
        {
            return "Produto { Cod: " + Codigo + " Nome: " + Nome +
            " Preco Unitario: " + Preco + "}";
        }
    }
}
