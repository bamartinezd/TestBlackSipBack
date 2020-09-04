using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TestBlackSipBack.Domain.Entities;

namespace TestBlackSipBack.Data.DataAccess.Configuration
{
    class RegistroConfiguration : IEntityTypeConfiguration<Registro>
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

            builder.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Procesado).HasDefaultValueSql("((0))");
        }
    }
}
