﻿// <auto-generated />
using System;
using EcoEnergyTerceraFase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcoEnergyTerceraFase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250327225458_MigracionCsv")]
    partial class MigracionCsv
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcoEnergyTerceraFase.Models.ConsumAigua", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CodeDistrict")
                        .HasColumnType("int");

                    b.Property<double>("Consumption")
                        .HasColumnType("float");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FontsAndEcoActivities")
                        .HasColumnType("int");

                    b.Property<int>("Network")
                        .HasColumnType("int");

                    b.Property<int>("Poblation")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ConsumAigua");
                });

            modelBuilder.Entity("EcoEnergyTerceraFase.Models.IndicadorsEnergetics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("CCAC_GasolinaAuto")
                        .HasColumnType("float");

                    b.Property<double>("CDEEBC_DemandaElectr")
                        .HasColumnType("float");

                    b.Property<double>("CDEEBC_ProdDisp")
                        .HasColumnType("float");

                    b.Property<double>("CDEEBC_ProdNeta")
                        .HasColumnType("float");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("IndicadorsEnergetics");
                });

            modelBuilder.Entity("EcoEnergyTerceraFase.Models.Simulacions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("CostKWh")
                        .HasColumnType("float");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime2");

                    b.Property<double>("EnergiaGenerada")
                        .HasColumnType("float");

                    b.Property<double>("PreuKWh")
                        .HasColumnType("float");

                    b.Property<double>("Rati")
                        .HasColumnType("float");

                    b.Property<string>("Tipus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Simulacions");
                });
#pragma warning restore 612, 618
        }
    }
}
