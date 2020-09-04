using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TestBlackSipBack.Data.DataAccess.Configuration;
using TestBlackSipBack.Domain.Entities;

namespace TestBlackSipBack.Data.DataAccess
{
    public partial class TestBlackSip_AlejandroMartinezContext : DbContext
    {
        public TestBlackSip_AlejandroMartinezContext()
        {
        }

        public TestBlackSip_AlejandroMartinezContext(DbContextOptions<TestBlackSip_AlejandroMartinezContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MenuItem> MenuItem { get; set; }
        public virtual DbSet<Registro> Registro { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MenuItemConfiguration());
            modelBuilder.ApplyConfiguration(new RegistroConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
