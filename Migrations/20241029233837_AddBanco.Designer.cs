﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UiHelpapi.Context;

#nullable disable

namespace UiHelpAPI.Migrations
{
    [DbContext(typeof(DatabaseContexto))]
    [Migration("20241029233837_AddBanco")]
    partial class AddBanco
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UiHelpapi.Models.Adm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Adm");
                });

            modelBuilder.Entity("UiHelpapi.Models.HorarioDeFuncionamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DiaSemana")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<TimeSpan>("Horario1")
                        .HasColumnType("time(6)");

                    b.Property<TimeSpan>("Horario2")
                        .HasColumnType("time(6)");

                    b.Property<int>("PontosDeColetaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PontosDeColetaId");

                    b.ToTable("HorarioDeFuncionamento");
                });

            modelBuilder.Entity("UiHelpapi.Models.PontosDeColeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CNPJ")
                        .HasColumnType("longtext");

                    b.Property<string>("Categoria")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PontosDeColeta");
                });

            modelBuilder.Entity("UiHelpapi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("UiHelpapi.Models.HorarioDeFuncionamento", b =>
                {
                    b.HasOne("UiHelpapi.Models.PontosDeColeta", "PontosDeColeta")
                        .WithMany("HorariosDeFuncionamento")
                        .HasForeignKey("PontosDeColetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PontosDeColeta");
                });

            modelBuilder.Entity("UiHelpapi.Models.PontosDeColeta", b =>
                {
                    b.Navigation("HorariosDeFuncionamento");
                });
#pragma warning restore 612, 618
        }
    }
}