using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Apresentacao.Domains;

namespace Apresentacao.Contexts
{
    public partial class ApresentacaoContext : DbContext
    {
        public ApresentacaoContext()
        {
        }

        public ApresentacaoContext(DbContextOptions<ApresentacaoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Avaliacao> Avaliacao { get; set; }
        public virtual DbSet<Avaliador> Avaliador { get; set; }
        public virtual DbSet<TipoAvaliacao> TipoAvaliacao { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-65B9MRT\\SQLEXPRESS01;Initial Catalog=projeto;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avaliacao>(entity =>
            {
                entity.HasKey(e => e.IdAvaliacao)
                    .HasName("PK__avaliaca__272BC05D2C831BAE");

                entity.ToTable("avaliacao");

                entity.Property(e => e.IdAvaliacao).HasColumnName("id_avaliacao");

                entity.Property(e => e.IdAvaliador).HasColumnName("id_avaliador");

                entity.Property(e => e.IdTipoAvaliacao).HasColumnName("id_tipo_avaliacao");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Nota)
                    .HasColumnName("nota")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdAvaliadorNavigation)
                    .WithMany(p => p.Avaliacao)
                    .HasForeignKey(d => d.IdAvaliador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__avaliacao__id_av__0C85DE4D");

                entity.HasOne(d => d.IdTipoAvaliacaoNavigation)
                    .WithMany(p => p.Avaliacao)
                    .HasForeignKey(d => d.IdTipoAvaliacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__avaliacao__id_ti__0A9D95DB");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Avaliacao)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__avaliacao__id_us__0B91BA14");
            });

            modelBuilder.Entity<Avaliador>(entity =>
            {
                entity.HasKey(e => e.IdAvaliador)
                    .HasName("PK__avaliado__2279801F3DD5EC00");

                entity.ToTable("avaliador");

                entity.HasIndex(e => e.NomeAvaliador)
                    .HasName("UQ__avaliado__1781D57FAA575A4B")
                    .IsUnique();

                entity.Property(e => e.IdAvaliador).HasColumnName("id_avaliador");

                entity.Property(e => e.Funcao)
                    .IsRequired()
                    .HasColumnName("funcao")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NomeAvaliador)
                    .IsRequired()
                    .HasColumnName("nome_avaliador")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoAvaliacao>(entity =>
            {
                entity.HasKey(e => e.IdTipoAvaliacao)
                    .HasName("PK__tipo_ava__A6EA1D9A07819E6C");

                entity.ToTable("tipo_avaliacao");

                entity.HasIndex(e => e.Titulo)
                    .HasName("UQ__tipo_ava__38FA640FB3F50DE5")
                    .IsUnique();

                entity.Property(e => e.IdTipoAvaliacao).HasColumnName("id_tipo_avaliacao");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__usuario__4E3E04AD9CE0E301");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.EmailUsuario)
                    .HasName("UQ__usuario__CD3151FF469637BE")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.EmailUsuario)
                    .IsRequired()
                    .HasColumnName("email_usuario")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdadeUsuario).HasColumnName("idade_usuario");

                entity.Property(e => e.NomeUsuario)
                    .IsRequired()
                    .HasColumnName("nome_usuario")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SenhaUsuario)
                    .IsRequired()
                    .HasColumnName("senha_usuario")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
