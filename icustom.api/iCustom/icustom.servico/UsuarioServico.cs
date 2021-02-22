using icustom.contexto.contratos;
using icustom.dominio.entidades;
using icustom.infra.exceptions;
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
        IAutenticacaoServico _autenticacaoServico;

        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio, IAutenticacaoServico autenticacaoServico)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _autenticacaoServico = autenticacaoServico;
        }

        public void Adicionar(Usuario usuario)
        {
            _usuarioRepositorio.Adicionar(usuario);
            _usuarioRepositorio.Salvar();
        }

        public string Autenticar(string login, string senha)
        {
            string token = "";

            var usuario = _usuarioRepositorio.ObterPorLogin(login, senha);

            if (usuario != null)
            {
                token = _autenticacaoServico.GerarToken();
            }
            else
                throw new NaoEncontradoExceptionBusiness("Usuário não encontrado ou senha inválida.");

            return token;
        }

        public List<Usuario> ObterTodos()
        {
            return _usuarioRepositorio.ObterTodos().ToList();
        }
    }
}
