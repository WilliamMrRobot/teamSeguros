﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using teamSegurosApi.Data;

namespace teamSegurosApi.Migrations
{
    [DbContext(typeof(SgContext))]
    [Migration("20191103215526_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("teamSegurosApi.Models.Ciudad", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Ciudades");

                    b.HasData(
                        new
                        {
                            Id = new Guid("60e168bf-b3fe-414f-b37a-294db75cdb94"),
                            Nombre = "Bogota"
                        },
                        new
                        {
                            Id = new Guid("cbf14e62-5e96-4597-9d25-6ee222872fb3"),
                            Nombre = "Medellin"
                        },
                        new
                        {
                            Id = new Guid("bb21e244-b2d4-40d9-a5a1-facf93ff43cd"),
                            Nombre = "Cali"
                        });
                });

            modelBuilder.Entity("teamSegurosApi.Models.Marca", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid?>("VehiculoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Marcas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("12080c6c-b388-4f2c-ba5d-182aa8a69dbd"),
                            Nombre = "Mazda"
                        },
                        new
                        {
                            Id = new Guid("7aea73ff-00ea-43b1-8578-8f589bddf643"),
                            Nombre = "Renault"
                        },
                        new
                        {
                            Id = new Guid("c4f8d288-714a-4729-a9a4-6fdbd549ccd2"),
                            Nombre = "Nissan"
                        });
                });

            modelBuilder.Entity("teamSegurosApi.Models.Modelo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MarcaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("VehiculoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Modeloss");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eab4b435-750c-47be-8784-f075533d3a73"),
                            MarcaId = new Guid("12080c6c-b388-4f2c-ba5d-182aa8a69dbd"),
                            Nombre = "Mazda3"
                        },
                        new
                        {
                            Id = new Guid("d738a7d8-72e7-43cb-ac6f-6943cd7f91f2"),
                            MarcaId = new Guid("7aea73ff-00ea-43b1-8578-8f589bddf643"),
                            Nombre = "Symbol"
                        },
                        new
                        {
                            Id = new Guid("662b509c-c60b-4462-9dd6-5ee2261e456a"),
                            MarcaId = new Guid("c4f8d288-714a-4729-a9a4-6fdbd549ccd2"),
                            Nombre = "Versa"
                        });
                });

            modelBuilder.Entity("teamSegurosApi.Models.Rol", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d1f43590-adc3-4812-95bd-3035e4b5e4fd"),
                            Nombre = "Administrador"
                        },
                        new
                        {
                            Id = new Guid("9da8beda-e526-4e47-a801-9735d1bfeb57"),
                            Nombre = "Usuario"
                        });
                });

            modelBuilder.Entity("teamSegurosApi.Models.Seguro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.Property<Guid>("VehiculoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Seguros");
                });

            modelBuilder.Entity("teamSegurosApi.Models.TipoDocumento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TipoDocumentos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d095f315-bc3f-4204-bcfc-4c5c644fbc30"),
                            Nombre = "Cedula de ciudadania"
                        },
                        new
                        {
                            Id = new Guid("3cf031a9-8991-40c2-b1d4-998369de3b23"),
                            Nombre = "Tarjeta de identidad"
                        });
                });

            modelBuilder.Entity("teamSegurosApi.Models.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("CiudadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("NumeroDocumento")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<Guid>("RolId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TipoDocumentoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.HasIndex("RolId");

                    b.HasIndex("TipoDocumentoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("teamSegurosApi.Models.Vehiculo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Año")
                        .HasColumnType("int");

                    b.Property<Guid>("MarcaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ModeloId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.HasKey("Id");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("teamSegurosApi.Models.Marca", b =>
                {
                    b.HasOne("teamSegurosApi.Models.Vehiculo", null)
                        .WithMany("Marca")
                        .HasForeignKey("VehiculoId");
                });

            modelBuilder.Entity("teamSegurosApi.Models.Modelo", b =>
                {
                    b.HasOne("teamSegurosApi.Models.Marca", "Marca")
                        .WithMany("Modelo")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("teamSegurosApi.Models.Vehiculo", null)
                        .WithMany("Modelo")
                        .HasForeignKey("VehiculoId");
                });

            modelBuilder.Entity("teamSegurosApi.Models.Seguro", b =>
                {
                    b.HasOne("teamSegurosApi.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("teamSegurosApi.Models.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("VehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("teamSegurosApi.Models.Usuario", b =>
                {
                    b.HasOne("teamSegurosApi.Models.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("teamSegurosApi.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("teamSegurosApi.Models.TipoDocumento", "TipoDocumento")
                        .WithMany()
                        .HasForeignKey("TipoDocumentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}