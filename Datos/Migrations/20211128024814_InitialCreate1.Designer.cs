﻿// <auto-generated />
using System;
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(ConsultorioContext))]
    [Migration("20211128024814_InitialCreate1")]
    partial class InitialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entidad.Administrador", b =>
                {
                    b.Property<string>("nombreUsuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("contraseña")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("estado")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("tipoUsuario")
                        .HasColumnType("varchar(20)");

                    b.HasKey("nombreUsuario");

                    b.ToTable("administradores");
                });

            modelBuilder.Entity("Entidad.Agenda", b =>
                {
                    b.Property<int>("idAgenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("idAgenda");

                    b.ToTable("agendas");
                });

            modelBuilder.Entity("Entidad.Cita", b =>
                {
                    b.Property<int>("idCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("diagnosticoidDiagnostico")
                        .HasColumnType("int");

                    b.Property<string>("fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pacientenombreUsuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("psicologonombreUsuario")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("idCita");

                    b.HasIndex("diagnosticoidDiagnostico");

                    b.HasIndex("pacientenombreUsuario");

                    b.HasIndex("psicologonombreUsuario");

                    b.ToTable("citas");
                });

            modelBuilder.Entity("Entidad.Diagnostico", b =>
                {
                    b.Property<int>("idDiagnostico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("psicologonombreUsuario")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("idDiagnostico");

                    b.HasIndex("psicologonombreUsuario");

                    b.ToTable("diagnosticos");
                });

            modelBuilder.Entity("Entidad.Disponibilidad", b =>
                {
                    b.Property<int>("idDisponibilidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgendaidAgenda")
                        .HasColumnType("int");

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.HasKey("idDisponibilidad");

                    b.HasIndex("AgendaidAgenda");

                    b.ToTable("disponibilidades");
                });

            modelBuilder.Entity("Entidad.Paciente", b =>
                {
                    b.Property<string>("nombreUsuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Eps")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("apellido")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("contraseña")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("correo")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("direccion")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("estado")
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("identificacion")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("nombre")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("sexo")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoDocumento")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("tipoUsuario")
                        .HasColumnType("varchar(20)");

                    b.HasKey("nombreUsuario");

                    b.ToTable("pacientes");
                });

            modelBuilder.Entity("Entidad.Psicologo", b =>
                {
                    b.Property<string>("nombreUsuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UniversidadEgreso")
                        .HasColumnType("varchar(40)");

                    b.Property<int?>("agendaPsicologoidAgenda")
                        .HasColumnType("int");

                    b.Property<string>("apellido")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("areaEspecializada")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("areaPsicologo")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("contraseña")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("correo")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("direccion")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("estado")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("fechaFinalizacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("identificacion")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("mesesExperiencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("sexo")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoDocumento")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("tipoUsuario")
                        .HasColumnType("varchar(20)");

                    b.HasKey("nombreUsuario");

                    b.HasIndex("agendaPsicologoidAgenda");

                    b.ToTable("psicologos");
                });

            modelBuilder.Entity("Entidad.Tratamiento", b =>
                {
                    b.Property<int>("idTratamiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DiagnosticoidDiagnostico")
                        .HasColumnType("int");

                    b.Property<string>("descripcionTratamiento")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("nombreTratamiento")
                        .HasColumnType("varchar(30)");

                    b.HasKey("idTratamiento");

                    b.HasIndex("DiagnosticoidDiagnostico");

                    b.ToTable("tratamientos");
                });

            modelBuilder.Entity("Entidad.Cita", b =>
                {
                    b.HasOne("Entidad.Diagnostico", "diagnostico")
                        .WithMany()
                        .HasForeignKey("diagnosticoidDiagnostico");

                    b.HasOne("Entidad.Paciente", "paciente")
                        .WithMany("citas")
                        .HasForeignKey("pacientenombreUsuario");

                    b.HasOne("Entidad.Psicologo", "psicologo")
                        .WithMany()
                        .HasForeignKey("psicologonombreUsuario");

                    b.Navigation("diagnostico");

                    b.Navigation("paciente");

                    b.Navigation("psicologo");
                });

            modelBuilder.Entity("Entidad.Diagnostico", b =>
                {
                    b.HasOne("Entidad.Psicologo", "psicologo")
                        .WithMany()
                        .HasForeignKey("psicologonombreUsuario");

                    b.Navigation("psicologo");
                });

            modelBuilder.Entity("Entidad.Disponibilidad", b =>
                {
                    b.HasOne("Entidad.Agenda", null)
                        .WithMany("disponibilidadesPsicologo")
                        .HasForeignKey("AgendaidAgenda");
                });

            modelBuilder.Entity("Entidad.Psicologo", b =>
                {
                    b.HasOne("Entidad.Agenda", "agendaPsicologo")
                        .WithMany()
                        .HasForeignKey("agendaPsicologoidAgenda");

                    b.Navigation("agendaPsicologo");
                });

            modelBuilder.Entity("Entidad.Tratamiento", b =>
                {
                    b.HasOne("Entidad.Diagnostico", null)
                        .WithMany("tramientosSeguir")
                        .HasForeignKey("DiagnosticoidDiagnostico");
                });

            modelBuilder.Entity("Entidad.Agenda", b =>
                {
                    b.Navigation("disponibilidadesPsicologo");
                });

            modelBuilder.Entity("Entidad.Diagnostico", b =>
                {
                    b.Navigation("tramientosSeguir");
                });

            modelBuilder.Entity("Entidad.Paciente", b =>
                {
                    b.Navigation("citas");
                });
#pragma warning restore 612, 618
        }
    }
}
