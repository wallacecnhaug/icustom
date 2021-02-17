using icustom.dominio.entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.contexto.configuracoes
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //builder.ToTable("tb_usuario");

            builder.HasKey(_ => _.Id);
            builder.HasAlternateKey(_ => _.Login);

            builder.Property(_ => _.Id)
                //.HasColumnName("id")
                .IsRequired().ValueGeneratedOnAdd();

            builder.Property(_ => _.Login)
                //.HasColumnName("login")
                .IsRequired().HasMaxLength(50);

            builder.Property(_ => _.Nome)
                //.HasColumnName("nome")
                .IsRequired().HasMaxLength(200);

            builder.Property(_ => _.Senha)
                //.HasColumnName("senha")
                .IsRequired().HasMaxLength(500);
        }
    }
}
