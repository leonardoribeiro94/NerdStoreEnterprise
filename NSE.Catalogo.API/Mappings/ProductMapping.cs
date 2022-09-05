﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NSE.Catalogo.API.Models;

namespace NSE.Catalogo.API.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("Varchar(250)");

            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnType("Varchar(500)");

            builder.Property(c => c.Imagem)
                .IsRequired()
                .HasColumnType("Varchar(250)");

            builder.ToTable("Produtos");
        }
    }
}
