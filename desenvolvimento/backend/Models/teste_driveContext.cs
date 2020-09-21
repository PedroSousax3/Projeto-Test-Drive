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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;user id=root;password=1234;database=teste_drive", x => x.ServerVersion("8.0.18-mysql"));
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
