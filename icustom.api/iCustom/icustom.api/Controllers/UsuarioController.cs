using icustom.api.Models;
using icustom.app.api.Helpers;
using icustom.dominio.entidades;
using icustom.infra.exceptions;
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
                if (model.Valido())
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
                else throw new ExceptionBusiness("Problema ao adicionar usuário: Modelo inválido.");
            }
            catch (System.Exception ex)
            {
                return this.TratarErro(ex);
            }
        }

        /// <summary>
        /// Obtém autenticação utilizando JWT para um determinado Usuário já salvo em banco de dados.
        /// </summary>
        /// <param name="model">Dados para realizar o login.</param>
        /// <returns>Retorna o TOKEN JWT para o usuário solicitado.</returns>
        [HttpPost]
        [AutorizacaoAnonima]
        public async Task<ActionResult<icustom.api.Models.LoginModel>> Autenticar([FromBody] icustom.api.Models.LoginModel model)
        {
            try
            {
                if (model.Valido())
                {
                    string login = model.email;
                    string senha = model.senha;

                    var token = _usuarioServico.Autenticar(login, senha);

                    return Ok(
                        new LoginModel()
                        {
                            email = login,
                            token = token
                        });
                }
                else
                    throw new ExceptionBusiness("Dados para autenticação não foram informados.");
            }
            catch (System.Exception ex)
            {
                return this.TratarErro(ex);
            }
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
