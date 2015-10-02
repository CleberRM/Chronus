﻿using br.com.Chronos.AcessoDados;
using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using SimpleInjector;

namespace br.com.Chronos.DependencyInjection
{
    public class DIConfig
    {
        public void ConfigurarDI(Container container)
        {
            container.Register<IAcoesBanco<Cliente>, ADCliente>();
            container.Register<IAcoesBanco<Contato>, ADContato>();
            container.Register<IAcoesBanco<DocumentosAnexos>, ADDocumentosAnexos>();
            container.Register<IAcoesBanco<Eventos>, ADEventos>();
            //container.Register<IAcoesBanco<Escritorio>, ADEscritorio>();
            container.Register<IAcoesBanco<FollowUpOSCliente>, ADFollowUpOSCliente>();
            container.Register<IAcoesBanco<LancamentoEvento>, ADLancamentoEvento>();
            container.Register<IAcoesBanco<MensagemDados>, ADMensagemDados>();
            container.Register<IAcoesBanco<Modalidade>, ADModalidade>();
            container.Register<IAcoesBanco<OrdemDeServico>, ADOrdemDeServico>();
            container.Register<IAcoesBanco<Setor>, ADSetor>();
            container.Register<IAcoesBanco<Usuario>, ADUsuario>();
            container.Register<OSContext>(Lifestyle.Scoped);

            container.Register<ANegocio<Cliente>, BLCliente>();
            container.Register<ANegocio<Contato>, BLContato>();
            container.Register<ANegocio<DocumentosAnexos>,BLDocumentosAnexos>();
            container.Register<ANegocio<Eventos>, BLEventos>();
            //container.Register<ANegocio<Escritorio>, BLEscritorio>();
            container.Register<ANegocio<FollowUpOSCliente>, BLFollowUpOSCliente>();
            container.Register<ANegocio<Modalidade>, BLModalidade>();
            container.Register<ANegocio<OrdemDeServico>, BLOrdemDeServico>();
            container.Register<ANegocio<Setor>, BLSetor>();
            container.Register<ANegocio<Usuario>, BLUsuario>();
        }
    }
}