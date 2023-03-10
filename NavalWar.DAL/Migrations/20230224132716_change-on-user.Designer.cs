// <auto-generated />
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
    [Migration("20230224132716_change-on-user")]
    partial class changeonuser
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
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "SessionId");

                    b.HasIndex("UserName");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("NavalWar.DAL.Models.Ship", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID"));

                    b.Property<int>("PV")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerSessionId")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerUserId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PlayerUserId", "PlayerSessionId");

                    b.ToTable("Ship");
                });

            modelBuilder.Entity("NavalWar.DAL.Models.Shot", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<bool>("IsHit")
                        .HasColumnType("bit");

                    b.Property<int?>("PlayerSessionId")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerUserId")
                        .HasColumnType("int");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerUserId", "PlayerSessionId");

                    b.ToTable("Shot");
                });

            modelBuilder.Entity("NavalWar.DAL.Models.User", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("NavalWar.DAL.Models.Player", b =>
                {
                    b.HasOne("NavalWar.DAL.Models.User", "User")
                        .WithMany("Players")
                        .HasForeignKey("UserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NavalWar.DAL.Models.Ship", b =>
                {
                    b.HasOne("NavalWar.DAL.Models.Player", null)
                        .WithMany("Ships")
                        .HasForeignKey("PlayerUserId", "PlayerSessionId");
                });

            modelBuilder.Entity("NavalWar.DAL.Models.Shot", b =>
                {
                    b.HasOne("NavalWar.DAL.Models.Player", null)
                        .WithMany("Shots")
                        .HasForeignKey("PlayerUserId", "PlayerSessionId");
                });

            modelBuilder.Entity("NavalWar.DAL.Models.Player", b =>
                {
                    b.Navigation("Ships");

                    b.Navigation("Shots");
                });

            modelBuilder.Entity("NavalWar.DAL.Models.User", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
