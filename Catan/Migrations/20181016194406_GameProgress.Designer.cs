﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Catan.DBL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Catan.Migrations
{
    [DbContext(typeof(DatabaseLayer))]
    [Migration("20181016194406_GameProgress")]
    partial class GameProgress
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Catan.Clases.Road", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("GameStatusGame");

                    b.Property<int>("X");

                    b.Property<int>("Y");

                    b.HasKey("Id");

                    b.HasIndex("GameStatusGame");

                    b.ToTable("Road");
                });

            modelBuilder.Entity("Catan.DBL.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<Guid>("Admin");

                    b.Property<Guid>("User1");

                    b.Property<Guid>("User2");

                    b.Property<Guid>("User3");

                    b.Property<Guid>("User4");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Catan.DBL.GameStatus", b =>
                {
                    b.Property<Guid>("Game")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CurrentTurn");

                    b.Property<int>("Rubber");

                    b.Property<List<int>>("User1_Develops");

                    b.Property<List<int>>("User1_Raws");

                    b.Property<List<int>>("User1_Towns");

                    b.Property<List<int>>("User1_Villages");

                    b.Property<List<int>>("User2_Develops");

                    b.Property<List<int>>("User2_Raws");

                    b.Property<List<int>>("User2_Towns");

                    b.Property<List<int>>("User2_Villages");

                    b.Property<List<int>>("User3_Develops");

                    b.Property<List<int>>("User3_Raws");

                    b.Property<List<int>>("User3_Towns");

                    b.Property<List<int>>("User3_Villages");

                    b.Property<List<int>>("User4_Develops");

                    b.Property<List<int>>("User4_Raws");

                    b.Property<List<int>>("User4_Towns");

                    b.Property<List<int>>("User4_Villages");

                    b.HasKey("Game");

                    b.ToTable("GameLogs");
                });

            modelBuilder.Entity("Catan.DBL.Land", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<List<int>>("Geks");

                    b.Property<List<int>>("GeksToken");

                    b.HasKey("Id");

                    b.ToTable("Lands");
                });

            modelBuilder.Entity("Catan.DBL.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid>("Token");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Catan.Clases.Road", b =>
                {
                    b.HasOne("Catan.DBL.GameStatus")
                        .WithMany("User1_Roads")
                        .HasForeignKey("GameStatusGame");
                });
#pragma warning restore 612, 618
        }
    }
}
