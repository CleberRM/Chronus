﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using br.com.Chronos.Idioma.Resources;

namespace br.com.Chronos.Entidade
{
    public class Cliente : AEntidade
    {

        public Cliente()
        {
            Contatos = new List<Contato>();
            ProdutosAdquiridos = new List<ProdutoCliente>();
        }

        public List<Contato> Contatos { get; set; }
        public List<ProdutoCliente> ProdutosAdquiridos { get; set; }

        public int IdCliente { get; set; }

        [Display(ResourceType = typeof(Language), Name = "NomeReduzido")]
        public string NomeReduzido { get; set; }
        public string NomeCompleto { get; set; }
        public string CNPJeCPF { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public string NomeVendedor { get; set; }
        public string Observacoes { get; set; }
        public string ConexaoRemota { get; set; }

        public int Telefone { get; set; }
        public int Fax { get; set; }
        public int VersaoAtual { get; set; }
        public int QuantidadeLicencas { get; set; }
        public int TipoCliente { get; set; }
        
        public bool ProdutoAcess { get; set; }
        public bool ProdutoOfficeComexMax { get; set; }
        public bool ProdutoOfficeComex2010 { get; set; }
        public bool ProdutoOfficecomexInternacional { get; set; }
        public bool Ativo { get; set; }
        public bool ClienteProspecto { get; set; }
        public string ResponsavelCriacao { get; set; } //TFS
    }
}
