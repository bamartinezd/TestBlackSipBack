using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TestBlackSipBack.Domain.Entities;

namespace TestBlackSipBack.Data.DataAccess.Configuration
{
    class MenuItemConfiguration : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.IdmenuItemPadre).HasColumnName("IDMenuItemPadre");

            builder.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Uri)
                .HasColumnName("URI")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.HasOne(d => d.MenuItemPadre)
                .WithMany(p => p.InverseIdMenuItemPadre)
                .HasForeignKey(d => d.IdmenuItemPadre)
                .HasConstraintName("FK__MenuItem__IDMenu__24927208");
        }
    }
}
