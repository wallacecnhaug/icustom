using icustom.contexto;
using icustom.contexto.contratos;
using icustom.contexto.repositorios;
using icustom.infra.configs;
using icustom.servico;
using icustom.servico.contrato;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace icustom.app.api
{
    public class ServicoConfig
    {
        public static void ConfigurarEscopo(IServiceCollection services)
        {
            services.AddSingleton<IConfiguracaoApp, ConfiguracaoApp>();

            
            services.AddScoped<IContexto, iCustomContexto>();

            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

            services.AddScoped<IUsuarioServico, UsuarioServico>();
            services.AddScoped<IAutenticacaoServico, AutenticacaoServico>();

        }
    }
}
