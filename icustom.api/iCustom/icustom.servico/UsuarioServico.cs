using icustom.contexto.contratos;
using icustom.dominio.entidades;
using icustom.servico.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace icustom.servico
{
    public class UsuarioServico : BaseServico, IUsuarioServico
    {
        IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void Adicionar(Usuario usuario)
        {
            _usuarioRepositorio.Adicionar(usuario);
            _usuarioRepositorio.Salvar();
        }

        public List<Usuario> ObterTodos()
        {
            return _usuarioRepositorio.ObterTodos().ToList();
        }
    }
}
