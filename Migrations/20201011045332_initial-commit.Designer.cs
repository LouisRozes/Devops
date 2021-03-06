﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial1;

namespace Parcial1.Migrations
{
    [DbContext(typeof(Db))]
    [Migration("20201011045332_initial-commit")]
    partial class initialcommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Parcial1.Persona", b =>
                {
                    b.Property<int>("personaid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("apellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("lugar")
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .HasColumnType("TEXT");

                    b.Property<int?>("vehiculoid")
                        .HasColumnType("INTEGER");

                    b.HasKey("personaid");

                    b.HasIndex("vehiculoid");

                    b.ToTable("personas");
                });

            modelBuilder.Entity("Parcial1.Vehiculo", b =>
                {
                    b.Property<int>("vehiculoid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("color")
                        .HasColumnType("TEXT");

                    b.Property<string>("descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("marca")
                        .HasColumnType("TEXT");

                    b.Property<string>("modelo")
                        .HasColumnType("TEXT");

                    b.Property<string>("placa")
                        .HasColumnType("TEXT");

                    b.HasKey("vehiculoid");

                    b.ToTable("vechiculos");
                });

            modelBuilder.Entity("Parcial1.Persona", b =>
                {
                    b.HasOne("Parcial1.Vehiculo", "vehiculo")
                        .WithMany("personas")
                        .HasForeignKey("vehiculoid");
                });
#pragma warning restore 612, 618
        }
    }
}
