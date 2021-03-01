using icustom.api;
using icustom.app.api;
using icustom.contexto.contratos;
using icustom.infra.configs;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.FeatureFilters;
using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.teste.unit.Base
{
    public abstract class BaseTeste
    {
        protected ServiceProvider serviceProvider;
        protected IConfiguracaoApp configuracaoApp;

        private void ConfigureServices()
        {

            var services = new ServiceCollection();

            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            services.AddSingleton<IConfiguration>(configuration).AddFeatureManagement().AddFeatureFilter<PercentageFilter>();//.AddFeatureFilter<AccountIdFilter>();

            ServicoConfig.ConfigurarEscopo(services);

            serviceProvider = services.BuildServiceProvider();

            configuracaoApp = serviceProvider.GetRequiredService<IConfiguracaoApp>();
            configuracaoApp.SetBancoDados_InMemory(true);

            Constantes.ChaveAutenticacao = configuration["Jwt:Key"];
        }

        protected BaseTeste()
        {
            ConfigureServices();
        }
    }
}
