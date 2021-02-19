using icustom.contexto.configuracoes;
using icustom.contexto.contratos;
using icustom.dominio.entidades;
using icustom.infra.configs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.contexto
{
    public class iCustomContexto : DbContext, IContexto
    {
        IConfiguracaoApp _configuracaoApp;

        public iCustomContexto(IConfiguracaoApp configuracaoApp) : base()
        {
            _configuracaoApp = configuracaoApp;
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbContext GetContexto()
        {
            return this;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_configuracaoApp.GetBancoDados_InMemory())
            {
                optionsBuilder.UseInMemoryDatabase("InMemoryICUSTOM");
            }
            else
            {
                optionsBuilder.UseSqlServer(_configuracaoApp.GetConnectionStringSQLServer());
            }

            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UsuarioConfig());

            base.OnModelCreating(builder);
        }
    }
}
