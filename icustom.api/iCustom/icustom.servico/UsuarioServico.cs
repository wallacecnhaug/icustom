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

        public override void Dispose()
        {
            _usuarioRepositorio.Dispose();
            _usuarioRepositorio = null;

            _autenticacaoServico.Dispose();
            _autenticacaoServico = null;

            base.Dispose();
        }

        public bool Adicionar(Usuario usuario)
        {
            bool sucesso = false;
            try
            {
                _usuarioRepositorio.Adicionar(usuario);
                _usuarioRepositorio.Salvar();

                sucesso = true;
            }
            catch (Exception ex)
            {
                throw TratarErro(ex);
            }
            return sucesso;
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
