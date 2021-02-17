using icustom.dominio.contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.contexto.contratos
{
    public interface IBaseRepositorio<TEntidade>: IDisposable 
        where TEntidade :  class
    {
        void Adicionar(TEntidade entidade);

        void Atualizar(TEntidade entidade);

        void Remover(TEntidade entidade);

        TEntidade ObterPorId(int id);

        List<TEntidade> ObterTodos();

        void Salvar();
    }
}

