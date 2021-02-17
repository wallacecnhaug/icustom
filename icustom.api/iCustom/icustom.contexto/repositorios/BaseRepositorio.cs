using icustom.contexto.contratos;
using icustom.dominio.contratos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace icustom.contexto.repositorios
{
    public abstract class BaseRepositorio<TEntidade> : IBaseRepositorio<TEntidade>
        where TEntidade : class
    {
        private DbContext _Contexto;
        private DbSet<TEntidade> _Comando;

        public DbContext Contexto { get => _Contexto; }
        public DbSet<TEntidade> Comando { get => _Comando; }

        public BaseRepositorio(IContexto contexto)
        {
            _Contexto = contexto.GetContexto();
            _Comando = _Contexto.Set<TEntidade>();
        }

        public void Adicionar(TEntidade entidade)
        {
            _Comando.Add(entidade);
        }

        public void Atualizar(TEntidade entidade)
        {
            _Comando.Update(entidade);
        }

        public TEntidade ObterPorId(int id)
        {
            return _Comando.Find(id);
        }

        public List<TEntidade> ObterTodos()
        {
            return _Comando.ToList();
        }

        public void Remover(TEntidade entidade)
        {
            _Comando.Remove(entidade);
        }

        public void Salvar()
        {
            _Contexto.SaveChanges();
        }

        public virtual void Dispose()
        {
            _Contexto.Dispose();
            _Contexto = null;
        }
    }
}
