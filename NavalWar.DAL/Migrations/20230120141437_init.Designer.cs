﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NavalWar.DAL;

#nullable disable

namespace NavalWar.DAL.Migrations
{
    [DbContext(typeof(NavalContext))]
    [Migration("20230120141437_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NavalWar.DAL.Models.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Player", (string)null);
                });

            modelBuilder.Entity("NavalWar.DAL.Models.Session", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("PlayerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PlayerID");

                    b.ToTable("Session", (string)null);
                });

            modelBuilder.Entity("NavalWar.DAL.Models.Session", b =>
                {
                    b.HasOne("NavalWar.DAL.Models.Player", null)
                        .WithMany("Sessions")
                        .HasForeignKey("PlayerID");
                });

            modelBuilder.Entity("NavalWar.DAL.Models.Player", b =>
                {
                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
