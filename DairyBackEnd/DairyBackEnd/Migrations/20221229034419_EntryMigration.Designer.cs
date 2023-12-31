﻿// <auto-generated />
using System;
using DairyBackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiaryBackEnd.Migrations
{
    [DbContext(typeof(DataContextClass))]
    [Migration("20221229034419_EntryMigration")]
    partial class EntryMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DairyBackEnd.Models.Registration", b =>
                {
                    b.Property<int>("uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("uid"));

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("uid");

                    b.ToTable("tblregistration");
                });

            modelBuilder.Entity("DiaryBackEnd.Models.Entry", b =>
                {
                    b.Property<int>("did")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("did"));

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("uid")
                        .HasColumnType("int");

                    b.HasKey("did");

                    b.ToTable("tblentry");
                });

            modelBuilder.Entity("DiaryBackEnd.Models.Profile", b =>
                {
                    b.Property<int>("pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pid"));

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bano")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dlno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("uid")
                        .HasColumnType("int");

                    b.HasKey("pid");

                    b.ToTable("tblprofile");
                });
#pragma warning restore 612, 618
        }
    }
}
