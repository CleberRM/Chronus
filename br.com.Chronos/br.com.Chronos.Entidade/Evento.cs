﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace br.com.Chronos.Entidade
{
    public class Evento : AEntidade
    {
        public int IdEvento {get; set;}
        public string Descricao { get; set; }
        public string CorHexadecimal { get; set; }
        public string ResponsavelCriacao { get; set; }
    }
}
