﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class ProdutoCliente : AEntidade
    {

        public ProdutoCliente(Cliente cliente)
        {
            Cliente = cliente;
            IdCliente = cliente.Id;
        }

        public int IdProduto { get; set; }
        public Produto DescricaoProduto { get; set; }

        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}