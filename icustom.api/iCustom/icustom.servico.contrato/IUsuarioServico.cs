using icustom.dominio.entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.servico.contrato
{
    public interface IUsuarioServico : IBaseServico
    {
        bool Adicionar(Usuario usuario);
        List<Usuario> ObterTodos();

        string Autenticar(string login, string senha);
    }
}
