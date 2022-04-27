﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RadarLiterario.Models;

namespace RadarLiterario.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220427225527_Livro")]
    partial class Livro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("RadarLiterario.Models.Livro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("genero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("sinopse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("RadarLiterario.Models.Usuario", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("ConfirmarSenha")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Email");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
