using icustom.contexto;
using icustom.contexto.contratos;
using icustom.contexto.repositorios;
using icustom.servico;
using icustom.servico.contrato;
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
            services.AddScoped<IContexto, iCustomContexto>();

            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IUsuarioServico, UsuarioServico>();
        }
    }
}
