using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.infra.configs
{
    public class ConfiguracaoApp : IConfiguracaoApp
    {
        IConfiguration _configuration;
        bool _bancoDadosInMemory = false;

        public ConfiguracaoApp(IConfiguration configuration)
        {
            _configuration = configuration;
            
            var bancoDados = _configuration["BancoDadosInMemory"].ToString();

            _bancoDadosInMemory = (bancoDados == "1");
        }

        public string GetConnectionStringSQLServer()
        {
            return _configuration.GetConnectionString("icustomSQLServer");
        }

        public bool GetBancoDados_InMemory()
        {
            return _bancoDadosInMemory;
        }

        public void SetBancoDados_InMemory(bool inMemory)
        {
            _bancoDadosInMemory = inMemory;
        }
    }
}
