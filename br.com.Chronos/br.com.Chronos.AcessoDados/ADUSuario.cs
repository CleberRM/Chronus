﻿using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADUsuario : IAcoesBanco<Usuario>
    {
        public bool ExcluirEntidadePor(int id)
        {
            using (OSContext contexto = new OSContext())
            {

                var result = RetornarEntidadePor(id);
                if (result != null)
                {
                    contexto.Usuarios.Remove(result);
                    contexto.SaveChanges();
                    return true;

                }
                return false;
            }
        }

        public Usuario RetornarEntidadePor(int id)
        {
            using (OSContext contexto = new OSContext())
            {
                return (from c in contexto.Usuarios
                       where c.Id == id
                       select c).FirstOrDefault();
            }

        }

        public IList<Usuario> RetornarLista(Usuario entidade)
        {
            using (OSContext contexto = new OSContext())
            {
                return contexto.Usuarios.Where(x => x.NomeUsuario.Contains(entidade.NomeUsuario)).ToList();
            }
        }

        public int Salvar(Usuario entidade)
        {
            using (OSContext contexto = new OSContext())
            {
                var result = RetornarEntidadePor(entidade.Id);

                if (result != null)
                {
                    contexto.Entry(result).CurrentValues.SetValues(entidade);
                }
                else
                {
                    contexto.Usuarios.Add(entidade);
                }

                contexto.SaveChanges();
                return entidade.Id;
            }
        }
    }
}
