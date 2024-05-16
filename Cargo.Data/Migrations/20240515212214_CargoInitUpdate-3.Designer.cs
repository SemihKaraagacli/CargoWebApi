﻿// <auto-generated />
using System;
using Cargo.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cargo.Data.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240515212214_CargoInitUpdate-3")]
    partial class CargoInitUpdate3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Cargo.Data.Models.CargoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ConsignataryAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConsignataryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConsignataryPhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConsignatarySurname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("LatestDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ShipperAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShipperName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShipperPhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShipperSurname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("Cargo.Data.Models.Types", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("LatestDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("CargoEntityTypes", b =>
                {
                    b.Property<int>("CargosId")
                        .HasColumnType("integer");

                    b.Property<int>("TypesId")
                        .HasColumnType("integer");

                    b.HasKey("CargosId", "TypesId");

                    b.HasIndex("TypesId");

                    b.ToTable("CargoEntityTypes");
                });

            modelBuilder.Entity("CargoEntityTypes", b =>
                {
                    b.HasOne("Cargo.Data.Models.CargoEntity", null)
                        .WithMany()
                        .HasForeignKey("CargosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cargo.Data.Models.Types", null)
                        .WithMany()
                        .HasForeignKey("TypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
