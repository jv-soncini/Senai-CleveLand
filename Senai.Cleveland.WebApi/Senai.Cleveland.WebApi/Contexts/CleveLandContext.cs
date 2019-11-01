using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Senai.Cleveland.WebApi.Domains
{
    public partial class CleveLandContext : DbContext
    {
        public CleveLandContext()
        {
        }

        public CleveLandContext(DbContextOptions<CleveLandContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Especialidade> Especialidade { get; set; }
        public virtual DbSet<Medicos> Medicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress; Initial Catalog=T_Cleveland;User Id=sa;Pwd=132");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Especialidade>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidade);

                entity.Property(e => e.Especialidade1)
                    .IsRequired()
                    .HasColumnName("Especialidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Medicos>(entity =>
            {
                entity.HasKey(e => e.IdMedico);

                entity.HasIndex(e => e.Crm)
                    .HasName("UQ__Medicos__D836F7D12FCB3E2C")
                    .IsUnique();

                entity.Property(e => e.Crm).HasColumnName("crm");

                entity.Property(e => e.DataNascimento).HasColumnType("date");

                entity.Property(e => e.Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.EspecialidadeNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.Especialidade)
                    .HasConstraintName("FK__Medicos__Especia__5DCAEF64");
            });
        }
    }
}
