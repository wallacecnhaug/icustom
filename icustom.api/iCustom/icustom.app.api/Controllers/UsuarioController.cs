using icustom.dominio.entidades;
using icustom.servico.contrato;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<List<Usuario>> ListarTodos()
        {
            return _usuarioServico.ObterTodos();
        }

        [HttpPost]
        [Route("Adicionar")]
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
    }
}
