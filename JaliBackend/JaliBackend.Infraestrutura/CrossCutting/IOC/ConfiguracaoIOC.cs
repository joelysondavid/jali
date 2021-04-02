using Autofac;
using JaliBackend.Aplicacao;
using JaliBackend.Aplicacao.Interfaces;
using JaliBackend.Aplicacao.Interfaces.Mappers;
using JaliBackend.Aplicacao.Mappers;
using JaliBackend.Dominio.Core.Interfaces.Repositorios;
using JaliBackend.Dominio.Core.Interfaces.Servicos;
using JaliBackend.Dominio.Servicos;
using JaliBackend.Infraestrutura.Dados.Repositorios;

namespace JaliBackend.Infraestrutura.CrossCutting.IOC
{
    /// <summary>
    /// Implementação da configuração IOC
    /// </summary>
    public class ConfiguracaoIOC
    {
        public static void Carregar(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<AplicacaoServicoLivro>().As<IAplicacaoServicoLivro>();
            builder.RegisterType<AplicacaoServicoGenero>().As<IAplicacaoServicoGenero>();

            builder.RegisterType<ServicoLivro>().As<IServicoLivro>();
            builder.RegisterType<ServicoGenero>().As<IServicoGenero>();

            builder.RegisterType<RepositorioLivro>().As<IRepositorioLivro>();
            builder.RegisterType<RepositorioGenero>().As<IRepositorioGenero>();

            builder.RegisterType<MapperLivro>().As<IMapperLivro>();
            builder.RegisterType<MapperGenero>().As<IMapperGenero>();

            #endregion
        }

    }
}
