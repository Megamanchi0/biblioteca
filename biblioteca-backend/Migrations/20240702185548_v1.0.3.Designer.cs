﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using biblioteca_backend;

#nullable disable

namespace biblioteca_backend.Migrations
{
    [DbContext(typeof(DBBibliotecaContext))]
    [Migration("20240702185548_v1.0.3")]
    partial class v103
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("biblioteca_backend.Models.DetallePrestamoLibro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdLibro")
                        .HasColumnType("int");

                    b.Property<int>("IdPrestamo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdLibro");

                    b.HasIndex("IdPrestamo");

                    b.ToTable("DetallePrestamoLibro");
                });

            modelBuilder.Entity("biblioteca_backend.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("biblioteca_backend.Models.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdGenero")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdGenero");

                    b.ToTable("Libro");
                });

            modelBuilder.Entity("biblioteca_backend.Models.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("biblioteca_backend.Models.Prestamo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaPrestamo")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdPerfil")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPerfil");

                    b.ToTable("Prestamo");
                });

            modelBuilder.Entity("biblioteca_backend.Models.DetallePrestamoLibro", b =>
                {
                    b.HasOne("biblioteca_backend.Models.Libro", "Libro")
                        .WithMany("DetallePrestamoLibro")
                        .HasForeignKey("IdLibro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("biblioteca_backend.Models.Prestamo", "Prestamo")
                        .WithMany("DetallePrestamoLibro")
                        .HasForeignKey("IdPrestamo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Libro");

                    b.Navigation("Prestamo");
                });

            modelBuilder.Entity("biblioteca_backend.Models.Libro", b =>
                {
                    b.HasOne("biblioteca_backend.Models.Genero", "Genero")
                        .WithMany("Libros")
                        .HasForeignKey("IdGenero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("biblioteca_backend.Models.Prestamo", b =>
                {
                    b.HasOne("biblioteca_backend.Models.Perfil", "Perfil")
                        .WithMany("Prestamos")
                        .HasForeignKey("IdPerfil")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("biblioteca_backend.Models.Genero", b =>
                {
                    b.Navigation("Libros");
                });

            modelBuilder.Entity("biblioteca_backend.Models.Libro", b =>
                {
                    b.Navigation("DetallePrestamoLibro");
                });

            modelBuilder.Entity("biblioteca_backend.Models.Perfil", b =>
                {
                    b.Navigation("Prestamos");
                });

            modelBuilder.Entity("biblioteca_backend.Models.Prestamo", b =>
                {
                    b.Navigation("DetallePrestamoLibro");
                });
#pragma warning restore 612, 618
        }
    }
}
