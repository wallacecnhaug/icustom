using icustom.dominio.entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.contexto.contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario ObterPorLogin(string login, string senha);
    }
}
