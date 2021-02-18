using icustom.api.Models;
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
        public async Task<ActionResult> Adicionar([FromBody] UsuarioModel model)
        {
            try
            {
                _usuarioServico.Adicionar(
                    new Usuario()
                    {
                        Login = model.login,
                        Nome = model.nome,
                        Senha = model.senha
                    });

                return Ok($"Usuário {model.login.Trim()}-{model.nome.Trim()} Cadastrado com sucesso.");
            }
            catch (System.Exception ex)
            {
                return this.TratarErro(ex);
            }
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
