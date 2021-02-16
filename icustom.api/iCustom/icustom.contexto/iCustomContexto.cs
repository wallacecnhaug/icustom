using icustom.contexto.configuracoes;
using icustom.contexto.contratos;
using icustom.dominio.entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.contexto
{
    public class iCustomContexto : DbContext, IContexto
    {
        public iCustomContexto(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbContext GetContexto()
        {
            return this;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UsuarioConfig());

            base.OnModelCreating(builder);
        }
    }
}
