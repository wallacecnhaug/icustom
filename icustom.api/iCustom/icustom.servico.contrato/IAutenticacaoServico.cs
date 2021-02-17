using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.servico.contrato
{
    public interface IAutenticacaoServico : IBaseServico
    {
        string GerarToken(string login);
    }
}
