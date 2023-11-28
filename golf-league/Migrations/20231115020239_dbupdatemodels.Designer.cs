﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using golf_league.Models;

#nullable disable

namespace golf_league.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231115020239_dbupdatemodels")]
    partial class dbupdatemodels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("golf_league.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdateDt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("golf_league.Models.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDt")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("CurrIndex")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdateDt")
                        .HasColumnType("datetime2");

                    b.Property<long>("PlayerTypeId")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("StartIndex")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("PlayerTypeId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("golf_league.Models.PlayerType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdateDt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlayerType");
                });

            modelBuilder.Entity("golf_league.Models.Player", b =>
                {
                    b.HasOne("golf_league.Models.PlayerType", "PlayerType")
                        .WithMany()
                        .HasForeignKey("PlayerTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlayerType");
                });
#pragma warning restore 612, 618
        }
    }
}
