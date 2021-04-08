using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace JaliBackend.Infraestrutura.CrossCutting.IOC
{
    /// <summary>
    /// Modulo IOC
    /// </summary>
    public class ModuloIOC : Module
    {
        /// <summary>
        /// Sobrescreve método Load
        /// </summary>
        /// <param name="builder">builder</param>
        protected override void Load(ContainerBuilder builder)
        {
            ConfiguracaoIOC.Carregar(builder);
        }

    }
}
