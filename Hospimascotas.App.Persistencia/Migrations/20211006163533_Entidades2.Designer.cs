﻿// <auto-generated />
using System;
using Hospimascotas.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hospimascotas.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211006163533_Entidades2")]
    partial class Entidades2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Hospimascotas.App.Dominio.Historia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Entorno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MascotaEnfermaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MascotaEnfermaId")
                        .IsUnique();

                    b.ToTable("Historias");
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.MascotaEnferma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AuxiliarVeterinario_designadoId")
                        .HasColumnType("int");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<int>("Latitud")
                        .HasColumnType("int");

                    b.Property<int>("Longitud")
                        .HasColumnType("int");

                    b.Property<int?>("MedicoEncargadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoMascota")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuxiliarVeterinario_designadoId");

                    b.HasIndex("MedicoEncargadoId");

                    b.ToTable("MascotasEnfermas");
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.SignosVitales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FechaHora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MascotaEnfermaId")
                        .HasColumnType("int");

                    b.Property<int>("Signo")
                        .HasColumnType("int");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MascotaEnfermaId");

                    b.ToTable("SignosVitales");
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaHora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HistoriaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaId");

                    b.ToTable("SugerenciasCuidado");
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.AuxiliarVeterinario", b =>
                {
                    b.HasBaseType("Hospimascotas.App.Dominio.Persona");

                    b.Property<int>("HorasLaborales")
                        .HasColumnType("int");

                    b.Property<int>("No_Certificado")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("AuxiliarVeterinario");
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.Dueño", b =>
                {
                    b.HasBaseType("Hospimascotas.App.Dominio.Persona");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MascotaEnfermaId")
                        .HasColumnType("int");

                    b.HasIndex("MascotaEnfermaId")
                        .IsUnique()
                        .HasFilter("[MascotaEnfermaId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Dueño");
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.MedicoVeterinario", b =>
                {
                    b.HasBaseType("Hospimascotas.App.Dominio.Persona");

                    b.Property<int>("CetificadoVeterinario")
                        .HasColumnType("int");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("MedicoVeterinario");
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.Historia", b =>
                {
                    b.HasOne("Hospimascotas.App.Dominio.MascotaEnferma", null)
                        .WithOne("HistoriaMedica")
                        .HasForeignKey("Hospimascotas.App.Dominio.Historia", "MascotaEnfermaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.MascotaEnferma", b =>
                {
                    b.HasOne("Hospimascotas.App.Dominio.AuxiliarVeterinario", "AuxiliarVeterinario_designado")
                        .WithMany()
                        .HasForeignKey("AuxiliarVeterinario_designadoId");

                    b.HasOne("Hospimascotas.App.Dominio.MedicoVeterinario", "MedicoEncargado")
                        .WithMany("MascotasAsignadas")
                        .HasForeignKey("MedicoEncargadoId");

                    b.Navigation("AuxiliarVeterinario_designado");

                    b.Navigation("MedicoEncargado");
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.SignosVitales", b =>
                {
                    b.HasOne("Hospimascotas.App.Dominio.MascotaEnferma", null)
                        .WithMany("signosVitales")
                        .HasForeignKey("MascotaEnfermaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.HasOne("Hospimascotas.App.Dominio.Historia", null)
                        .WithMany("SugerenciaCuidados")
                        .HasForeignKey("HistoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.Dueño", b =>
                {
                    b.HasOne("Hospimascotas.App.Dominio.MascotaEnferma", null)
                        .WithOne("DueñoEncargado")
                        .HasForeignKey("Hospimascotas.App.Dominio.Dueño", "MascotaEnfermaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.Historia", b =>
                {
                    b.Navigation("SugerenciaCuidados");
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.MascotaEnferma", b =>
                {
                    b.Navigation("DueñoEncargado");

                    b.Navigation("HistoriaMedica");

                    b.Navigation("signosVitales");
                });

            modelBuilder.Entity("Hospimascotas.App.Dominio.MedicoVeterinario", b =>
                {
                    b.Navigation("MascotasAsignadas");
                });
#pragma warning restore 612, 618
        }
    }
}