using Microsoft.VisualStudio.TestTools.UnitTesting;
using icustom.servico;
using System;
using System.Collections.Generic;
using System.Text;
using icustom.teste.unit.Base;
using icustom.servico.contrato;
using Microsoft.Extensions.DependencyInjection;
using icustom.dominio.entidades;
using System.Linq;

namespace icustom.servico.Tests
{
    [TestClass()]
    public class UsuarioServicoTests: BaseTeste
    {
        private IUsuarioServico _usuarioServico;

        [TestInitialize]
        public void Inicializar()
        {
            _usuarioServico = serviceProvider.GetRequiredService<IUsuarioServico>();
        }

        [TestCleanup]
        public void Limpeza()
        {
            _usuarioServico.Dispose();
            _usuarioServico = null;
        }

        [TestMethod()]
        public void Adicionar_UsuarioValido_ComSucesso()
        {
            _usuarioServico.Adicionar(new Usuario()
            {
                Login = "login_adicionado@gmail.com",
                Nome = "login adicionado",
                Senha = "123"
            });

            var usuarioAdicionado = _usuarioServico.ObterTodos().FirstOrDefault(_ => _.Nome == "login adicionado");

            Assert.IsNotNull(usuarioAdicionado);
        }

        [TestMethod()]
        public void Autenticar_UsuarioValido_ComSucesso()
        {
            _usuarioServico.Adicionar(new Usuario()
            {
                Login = "login_autenticacao@gmail.com",
                Nome = "login autenticação",
                Senha = "123"
            });

            var token = _usuarioServico.Autenticar("login_autenticacao@gmail.com", "123");

            Assert.IsTrue(!string.IsNullOrEmpty(token));
        }

        [TestMethod()]
        public void ObterTodos_ComSucesso()
        {
            for (int i = 0; i < 3; i++)
            {
                _usuarioServico.Adicionar(new Usuario()
                {
                    Login = $"todos-{i}@gmail.com",
                    Nome = $"todos-{i}",
                    Senha = $"123-{i}"
                });
            }

            var usuarios = _usuarioServico.ObterTodos().Where(_ => _.Nome.StartsWith("todos-")).ToList();

            Assert.IsTrue(usuarios.Count == 3);
        }
    }
}