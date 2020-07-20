﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using プロジェクト5.Services;

namespace プロジェクト5.Services.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20200720061450_DefinitiveMigration")]
    partial class DefinitiveMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("プロジェクト5.Models.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NomEquip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("プロジェクト5.Models.EquipoSub", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdEquipo")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdEquipo");

                    b.ToTable("EquipoSubs");
                });

            modelBuilder.Entity("プロジェクト5.Models.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApellidoP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechNac")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("FotoJug")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("IdEquipo")
                        .HasColumnType("int");

                    b.Property<string>("NomJug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Posicion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdEquipo");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("プロジェクト5.Models.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Estadio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FechPart")
                        .HasColumnType("int");

                    b.Property<int?>("IdEquipo")
                        .HasColumnType("int");

                    b.Property<int?>("IdEquipoSub")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("TiemJugado")
                        .HasColumnType("time");

                    b.Property<int>("TotalJugLc")
                        .HasColumnType("int");

                    b.Property<int>("TotalJugVis")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdEquipo");

                    b.HasIndex("IdEquipoSub");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("プロジェクト5.Models.ResultadoPartido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Asistencias")
                        .HasColumnType("int");

                    b.Property<int>("AutoGoles")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("Goles")
                        .HasColumnType("int");

                    b.Property<int>("IdJugador")
                        .HasColumnType("int");

                    b.Property<int>("IdPartido")
                        .HasColumnType("int");

                    b.Property<int>("Penales")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TarjAmarilla")
                        .HasColumnType("int");

                    b.Property<int>("TarjRoja")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdJugador");

                    b.HasIndex("IdPartido");

                    b.ToTable("ResultadoPartidos");
                });

            modelBuilder.Entity("プロジェクト5.Models.UserPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserPages");
                });

            modelBuilder.Entity("プロジェクト5.Models.EquipoSub", b =>
                {
                    b.HasOne("プロジェクト5.Models.Equipo", "Equipo")
                        .WithMany("EquipoSubs")
                        .HasForeignKey("IdEquipo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("プロジェクト5.Models.Jugador", b =>
                {
                    b.HasOne("プロジェクト5.Models.Equipo", "Equipo")
                        .WithMany("Jugadores")
                        .HasForeignKey("IdEquipo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("プロジェクト5.Models.Partido", b =>
                {
                    b.HasOne("プロジェクト5.Models.Equipo", "Equipo")
                        .WithMany("Partidos")
                        .HasForeignKey("IdEquipo");

                    b.HasOne("プロジェクト5.Models.EquipoSub", "EquipoSub")
                        .WithMany("Partidos")
                        .HasForeignKey("IdEquipoSub");
                });

            modelBuilder.Entity("プロジェクト5.Models.ResultadoPartido", b =>
                {
                    b.HasOne("プロジェクト5.Models.Jugador", "Jugador")
                        .WithMany("ResultadoPartidos")
                        .HasForeignKey("IdJugador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("プロジェクト5.Models.Partido", "Partido")
                        .WithMany("ResultadoPartidos")
                        .HasForeignKey("IdPartido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
