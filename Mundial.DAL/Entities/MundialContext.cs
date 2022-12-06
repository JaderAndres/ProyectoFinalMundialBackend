using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mundial.DAL.Entities
{
    public partial class MundialContext : DbContext
    {
        public MundialContext()
        {
        }

        public MundialContext(DbContextOptions<MundialContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asistencia> Asistencia { get; set; }
        public virtual DbSet<Equipo> Equipo { get; set; }
        public virtual DbSet<Goleador> Goleador { get; set; }
        public virtual DbSet<Jugador> Jugador { get; set; }
        public virtual DbSet<Posicion> Posicion { get; set; }
        public virtual DbSet<Resultado> Resultado { get; set; }
        public virtual DbSet<TablaPosicion> TablaPosicion { get; set; }
        public virtual DbSet<TarjetaRoja> TarjetaRoja { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asistencia>(entity =>
            {
                entity.HasOne(d => d.Jugador)
                    .WithMany(p => p.Asistencia)
                    .HasForeignKey(d => d.JugadorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Asistenci__Jugad__34C8D9D1");
            });

            modelBuilder.Entity<Equipo>(entity =>
            {
                entity.HasIndex(e => e.Nombre)
                    .HasName("UQ__Equipo__75E3EFCF89731E9E")
                    .IsUnique();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Goleador>(entity =>
            {
                entity.HasOne(d => d.Jugador)
                    .WithMany(p => p.Goleador)
                    .HasForeignKey(d => d.JugadorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Goleador__Jugado__2F10007B");
            });

            modelBuilder.Entity<Jugador>(entity =>
            {
                entity.Property(e => e.Apellido)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Estatura).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Equipo)
                    .WithMany(p => p.Jugador)
                    .HasForeignKey(d => d.EquipoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Jugador__EquipoI__2C3393D0");

                entity.HasOne(d => d.Posicion)
                    .WithMany(p => p.Jugador)
                    .HasForeignKey(d => d.PosicionId)
                    .HasConstraintName("FK__Jugador__Posicio__2B3F6F97");
            });

            modelBuilder.Entity<Posicion>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Resultado>(entity =>
            {
                entity.Property(e => e.GolesaFavor)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GolesenContra)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Equipo)
                    .WithMany(p => p.Resultado)
                    .HasForeignKey(d => d.EquipoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Resultado__Equip__31EC6D26");
            });

            modelBuilder.Entity<TablaPosicion>(entity =>
            {
                entity.Property(e => e.Gc).HasColumnName("GC");

                entity.Property(e => e.Gf).HasColumnName("GF");

                entity.Property(e => e.Pe).HasColumnName("PE");

                entity.Property(e => e.Pj).HasColumnName("PJ");

                entity.Property(e => e.Pp).HasColumnName("PP");

                entity.HasOne(d => d.Equipo)
                    .WithMany(p => p.TablaPosicion)
                    .HasForeignKey(d => d.EquipoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TablaPosi__Equip__3A81B327");
            });

            modelBuilder.Entity<TarjetaRoja>(entity =>
            {
                entity.HasOne(d => d.Jugador)
                    .WithMany(p => p.TarjetaRoja)
                    .HasForeignKey(d => d.JugadorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TarjetaRo__Jugad__37A5467C");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Clave)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
