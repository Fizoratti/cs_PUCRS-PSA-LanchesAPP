using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Entidades
{
    public class Produto : IProduto
    {
        //private int codigo;
        //...
        //public int getCodigo() { return codigo; }
       // public void setCodigo(int value)
        //{
        //    codigo = value;
       // }

        // {
        //     get { return codigo; }
        //     set { codigo = value; }
        // }

        public int Codigo { get; set; }

        public String Nome { get; set; }

        public decimal Preco { get; set; }

        public override string ToString()
        {
            return "Produto { Cod: " + Codigo + " Nome: " + Nome +
                " Preco Unitario: " + Preco + "}";
        }
    }
}
