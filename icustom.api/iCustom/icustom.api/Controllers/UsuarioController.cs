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

        /// <summary>
        /// Lista todos os Usuários existentes no banco de dados.
        /// </summary>
        /// <returns>Lista dos dados dos Usuários.</returns>
        [HttpGet]
        [Authorizacao]
        public async Task<List<Usuario>> ListarTodos()
        {
            return _usuarioServico.ObterTodos();
        }

        /// <summary>
        /// Adiciona um Usuário no banco de dados.
        /// </summary>
        /// <param name="model">Dados de Usuário para persistência.</param>
        /// <returns>Mensagem de sucesso ou erro da ação solicitada.</returns>
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

                return Ok($"Usuário {model.nome.Trim()} ({model.login.Trim()}) cadastrado com sucesso.");
            }
            catch (System.Exception ex)
            {
                return this.TratarErro(ex);
            }
        }

        /// <summary>
        /// Obtém autenticação utilizando JWT para um determinado Usuário já salvo em banco de dados.
        /// </summary>
        /// <param name="login">Login para autenticação a ser validado.</param>
        /// <param name="senha">Senha para autenticação a ser validado.</param>
        /// <returns>Retorna o TOKEN JWT para o usuário solicitado.</returns>
        [HttpGet]
        [AutorizacaoAnonima]
        public async Task<ActionResult<string>> ObterAutenticacao(string login, string senha)
        {
            return Ok(_usuarioServico.Autenticar(login, senha));
        }

        /// <summary>
        /// Realiza uma verificação se o usuário tem um TOKEN válido.
        /// </summary>
        /// <returns>Confirmação do token válido.</returns>
        [HttpGet]
        [Authorizacao]
        public async Task<ActionResult<string>> Autenticado()
        {
            return "Token válido.";
        }
    }
}
