using icustom.dominio.entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.servico.contrato
{
    public interface IUsuarioServico : IBaseServico
    {
        void Adicionar(Usuario usuario);
        List<Usuario> ObterTodos();
    }
}
