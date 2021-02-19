using icustom.contexto.contratos;
using icustom.dominio.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace icustom.contexto.repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(IContexto contexto) : base(contexto)
        {

        }

        public Usuario ObterPorLogin(string login, string senha)
        {
            return Comando.FirstOrDefault(_ => _.Login == login && _.Senha == senha);
        }
    }
}
