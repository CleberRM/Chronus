﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class Produto : AEntidade
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public string ResponsavelCriacao { get; set; }
    }
}
