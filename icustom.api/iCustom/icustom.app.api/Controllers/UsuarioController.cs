using icustom.app.api.Helpers;
using icustom.dominio.entidades;
using icustom.servico.contrato;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace icustom.app.api.Controllers
{
    [Route("api/[controller]")]

    public class UsuarioController : BaseController
    {
        IUsuarioServico _usuarioServico;

        public UsuarioController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpGet]
        [Route("ListarTodos")]
        [Authorizacao]
        public async Task<List<Usuario>> ListarTodos()
        {
            return _usuarioServico.ObterTodos();
        }

        [HttpPost]
        [Route("Adicionar")]
        [AutorizacaoAnonima]
        public async Task<ActionResult> Adicionar(string login, string nome, string senha)
        {
            _usuarioServico.Adicionar(
                new Usuario()
                {
                    Login = login,
                    Nome = nome,
                    Senha = senha
                });

            return Ok();
        }

        [HttpPost]
        [AutorizacaoAnonima]
        [Route("Autenticar")]
        public async Task<ActionResult<string>> Autenticar(string login, string senha)
        {
            return Ok(_usuarioServico.Autenticar(login, senha));
        }

        [HttpGet]
        [Authorizacao]
        [Route("Autenticado")]
        public async Task<ActionResult<string>> Autenticado()
        {
            return User.Identity.Name;
        }
    }
}
