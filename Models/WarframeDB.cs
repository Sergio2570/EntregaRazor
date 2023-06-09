﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntregaRazor.Models
{
    public partial class WarframeDB : DbContext
    {
        public WarframeDB()
        {
        }

        public WarframeDB(DbContextOptions<WarframeDB> options)
            : base(options)
        {
        }

        public virtual DbSet<Agrietados> Agrietados { get; set; }
        public virtual DbSet<Animales> Animales { get; set; }
        public virtual DbSet<Archguns> Archguns { get; set; }
        public virtual DbSet<Archmelee> Archmelee { get; set; }
        public virtual DbSet<Archwing> Archwing { get; set; }
        public virtual DbSet<Centinelas> Centinelas { get; set; }
        public virtual DbSet<CuerpoAcuerpo> CuerpoAcuerpo { get; set; }
        public virtual DbSet<Equipamiento> Equipamiento { get; set; }
        public virtual DbSet<Mods> Mods { get; set; }
        public virtual DbSet<Parches> Parches { get; set; }
        public virtual DbSet<Planetas> Planetas { get; set; }
        public virtual DbSet<Primarias> Primarias { get; set; }
        public virtual DbSet<Recursos> Recursos { get; set; }
        public virtual DbSet<Reliquias> Reliquias { get; set; }
        public virtual DbSet<Secundarias> Secundarias { get; set; }
        public virtual DbSet<Sindicatos> Sindicatos { get; set; }
        public virtual DbSet<Warframes> Warframes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agrietados>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Agrietad__75E3EFCE5131A49B");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Arma)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Buff1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Buff2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Buff3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeBuff)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Propietario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor1).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Valor2).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Valor3).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ValorDebuff).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<Animales>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Animales__75E3EFCE4F582B4D");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Velocidad).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<Archguns>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Archguns__75E3EFCE1B4BCB78");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cadencia).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Cc)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("CC");

                entity.Property(e => e.Cd)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("CD");

                entity.Property(e => e.Dmg).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Faccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ms)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("MS");

                entity.Property(e => e.Recarga).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Sc)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("SC");
            });

            modelBuilder.Entity<Archmelee>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Archmele__75E3EFCECB658665");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cc)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("CC");

                entity.Property(e => e.Cd)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("CD");

                entity.Property(e => e.Dmg).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Radio).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Sc)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("SC");

                entity.Property(e => e.Velocidad).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<Archwing>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Archwing__75E3EFCE490DB800");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Velocidad).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<Centinelas>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Centinel__75E3EFCE7556C4C3");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Velocidad).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<CuerpoAcuerpo>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__CuerpoAC__75E3EFCE4C5CAD84");

                entity.ToTable("CuerpoACuerpo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cc)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("CC");

                entity.Property(e => e.Cd)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("CD");

                entity.Property(e => e.Dmg).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.DmgPesado).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Faccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Radio).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Sc)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("SC");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Velocidad).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<Equipamiento>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Equipami__75E3EFCE3ECF4F7F");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mods>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Mods__75E3EFCEC1148E77");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aumento1)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Aumento2)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Instalacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SetMods)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Parches>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Parche)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Planetas>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Planetas__75E3EFCEC1DC033D");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Jefe)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroPlaneta).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Primarias>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Primaria__75E3EFCE8965E235");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cadencia).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Cc)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("CC");

                entity.Property(e => e.Cd)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("CD");

                entity.Property(e => e.Dmg).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Faccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ms)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("MS");

                entity.Property(e => e.Recarga).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Sc)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("SC");

                entity.Property(e => e.Secundario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Recursos>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Recursos__75E3EFCE96F7A6D6");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Obtencion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reliquias>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Reliquia__75E3EFCE6CA9FD73");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bronce1)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bronce2)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bronce3)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BronceExcepcional).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BronceIntacta).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BroncePerfecta).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BronceRadiante).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Oro)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OroExcepcional).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.OroIntacta).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.OroPerfecta).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.OroRadiante).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Plata1)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Plata2)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PlataExcepcional).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.PlataIntacta).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.PlataPerfecta).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.PlataRadiante).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Secundarias>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Secundar__75E3EFCE3879883A");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cadencia).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Cc)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("CC");

                entity.Property(e => e.Cd)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("CD");

                entity.Property(e => e.Dmg).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Faccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ms)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("MS");

                entity.Property(e => e.Recarga).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Sc)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("SC");

                entity.Property(e => e.Secundario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sindicatos>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Sindicat__75E3EFCEC732E808");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aliado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Enemigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enfrentado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Warframes>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Warframe__75E3EFCEDFD73452");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Elemento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Velocidad).HasColumnType("decimal(9, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}