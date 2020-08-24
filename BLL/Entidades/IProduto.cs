using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Entidades
{
    public interface IProduto
    {
        int Codigo { get; set; }

        string Nome { get; set; }
        
        decimal Preco { get; set; }

    }
}
