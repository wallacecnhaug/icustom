using icustom.app.api.Helpers;
using icustom.dominio.entidades;
using icustom.servico.contrato;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace icustom.app.api.Controllers
{
    public class UsuarioController : BaseController
    {
        IUsuarioServico _usuarioServico;

        public UsuarioController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpGet]
        [Authorizacao]
        public async Task<List<Usuario>> ListarTodos()
        {
            return _usuarioServico.ObterTodos();
        }

        [HttpPost]
        [AutorizacaoAnonima]
        public async Task<ActionResult<string>> Adicionar(string login, string nome, string senha)
        {
            _usuarioServico.Adicionar(
                new Usuario()
                {
                    Login = login,
                    Nome = nome,
                    Senha = senha
                });

            return Ok($"Usuário {login.Trim()}-{nome.Trim()} Cadastrado com sucesso.");
        }

        [HttpPost]
        [AutorizacaoAnonima]
        public async Task<ActionResult<string>> Autenticar(string login, string senha)
        {
            return Ok(_usuarioServico.Autenticar(login, senha));
        }

        [HttpGet]
        [Authorizacao]
        public async Task<ActionResult<string>> Autenticado()
        {
            return "Token válido.";
        }
    }
}
