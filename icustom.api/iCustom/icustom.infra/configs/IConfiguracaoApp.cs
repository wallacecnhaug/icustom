using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.infra.configs
{
    public interface IConfiguracaoApp
    {
        string GetConnectionStringSQLServer();
        bool GetBancoDados_InMemory();
        void SetBancoDados_InMemory(bool inMemory);
    }
}
