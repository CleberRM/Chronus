﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class FollowUpOSCliente : AEntidade
    {
        public int IdFollow { get; set; }
        public string Descricao { get; set; }
        public int IdOrdemServico { get; set; }
        public virtual OrdemDeServico OrdemServico { get; set; }
        public string ResponsavelCriacao { get; set; }
    }

}
