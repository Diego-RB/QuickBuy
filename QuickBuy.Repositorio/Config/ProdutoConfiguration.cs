using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            //O builder utiliza o padrão Fluent
            builder.HasKey(pr => pr.Id);
            builder
                .Property(pr => pr.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(pr => pr.Descricao)
                .IsRequired()
                .HasMaxLength(400);
            builder
                .Property(pr => pr.Preco)
                .IsRequired();

        }
    }
}
