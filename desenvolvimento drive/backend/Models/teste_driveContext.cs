using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace backend.Models
{
    public partial class teste_driveContext : DbContext
    {
        public teste_driveContext()
        {
        }

        public teste_driveContext(DbContextOptions<teste_driveContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAgendamento> TbAgendamento { get; set; }
        public virtual DbSet<TbCarro> TbCarro { get; set; }
        public virtual DbSet<TbCliente> TbCliente { get; set; }
        public virtual DbSet<TbFuncionario> TbFuncionario { get; set; }
        public virtual DbSet<TbLogin> TbLogin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;user id=root;password=45923617xx;database=teste_drive", x => x.ServerVersion("8.0.20-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAgendamento>(entity =>
            {
                entity.HasKey(e => e.IdAgendamento)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCarro)
                    .HasName("id_carro_idx");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("id_cliente_idx");

                entity.HasIndex(e => e.IdFuncionario)
                    .HasName("id_funcionari_idx");

                entity.Property(e => e.DsAgendamento)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsStatus)
                    .HasDefaultValueSql("'Aguardando Comfirmação'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdCarroNavigation)
                    .WithMany(p => p.TbAgendamento)
                    .HasForeignKey(d => d.IdCarro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_carro");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbAgendamento)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_cliente");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.TbAgendamento)
                    .HasForeignKey(d => d.IdFuncionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_funcionario");
            });

            modelBuilder.Entity<TbCarro>(entity =>
            {
                entity.HasKey(e => e.IdCarro)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsCarro)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCor)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmMarca)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmModelo)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TpCarro)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsCelular)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCep)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCnh)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsComplemento)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCpf)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsEndereco)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsRg)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmCliente)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbFuncionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsCnh)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCpf)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsNumero)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsRg)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmCargo)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmEndereço)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbLogin>(entity =>
            {
                entity.HasKey(e => e.IdLogin)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("id_cliente");

                entity.HasIndex(e => e.IdFuncionario)
                    .HasName("id_funcionario");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsSenha)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbLogin)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_login_ibfk_1");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.TbLogin)
                    .HasForeignKey(d => d.IdFuncionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_login_ibfk_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
