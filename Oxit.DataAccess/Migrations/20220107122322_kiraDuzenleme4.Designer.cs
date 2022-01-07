﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Oxit.DataAccess.EntityFramework;

#nullable disable

namespace Oxit.DataAccess.Migrations
{
    [DbContext(typeof(appDbContext))]
    [Migration("20220107122322_kiraDuzenleme4")]
    partial class kiraDuzenleme4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:CollationDefinition:turkish_collection", "tr_TR.UTF-8,tr_TR.UTF-8,icu,False")
                .HasAnnotation("Npgsql:DefaultColumnCollation", "turkish_collection")
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.HasKey("UserId", "ProviderKey");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("UserId", "Value");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Oxit.Common.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("EditDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("EditorId")
                        .HasColumnType("uuid");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NationalId")
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1569ade6-116f-4e63-b15c-b38009211857"),
                            Name = "Ali"
                        });
                });

            modelBuilder.Entity("Oxit.Domain.Models.Fis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("text");

                    b.Property<double?>("Alacak")
                        .HasColumnType("double precision");

                    b.Property<double?>("Borc")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DbKey")
                        .HasColumnType("text");

                    b.Property<string>("FisNo")
                        .HasColumnType("text");

                    b.Property<int?>("FisTip")
                        .HasColumnType("integer");

                    b.Property<string>("FisTur")
                        .HasColumnType("text");

                    b.Property<int>("GecikmeGunu")
                        .HasColumnType("integer");

                    b.Property<double?>("GecikmeTutari")
                        .HasColumnType("double precision");

                    b.Property<double?>("GeciktirilenAnaFaizTutar")
                        .HasColumnType("double precision");

                    b.Property<double?>("GeciktirilenTutar")
                        .HasColumnType("double precision");

                    b.Property<int>("HesapPlaniId")
                        .HasColumnType("integer");

                    b.Property<double?>("KalanTutar")
                        .HasColumnType("double precision");

                    b.Property<bool>("Odendi")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("SonHesaplananGecikmeTarihi")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("Tarih")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("YevNo")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("ZamanindaOdemeTarihi")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double?>("ZamanindaOdenenTutar")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("HesapPlaniId");

                    b.ToTable("Fis");
                });

            modelBuilder.Entity("Oxit.Domain.Models.HesapPlani", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .HasColumnType("text");

                    b.Property<bool>("Aktif")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DbKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double?>("GecikmeTutari")
                        .HasColumnType("double precision");

                    b.Property<string>("Kod")
                        .HasColumnType("text");

                    b.Property<DateTime>("SonCekilmeTarihi")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("HesapPlani");
                });

            modelBuilder.Entity("Oxit.Domain.Models.Kira", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly?>("BaslamaTarihi")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("BitisTarihi")
                        .HasColumnType("date");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirmaAdi")
                        .HasColumnType("text");

                    b.Property<double?>("IsletmeBedeli")
                        .HasColumnType("double precision");

                    b.Property<double?>("IsletmeKDVToplam")
                        .HasColumnType("double precision");

                    b.Property<double?>("KiraBedeli")
                        .HasColumnType("double precision");

                    b.Property<double?>("KiraKDVToplam")
                        .HasColumnType("double precision");

                    b.Property<double?>("KiraVeIsletmeKDVSizToplam")
                        .HasColumnType("double precision");

                    b.Property<double?>("KiraVeIsletmeKDVliToplam")
                        .HasColumnType("double precision");

                    b.Property<double?>("Metrekare")
                        .HasColumnType("double precision");

                    b.Property<double?>("MetrekareIsletmeFiyati")
                        .HasColumnType("double precision");

                    b.Property<double?>("MetrekareKiraFiyati")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Kira");
                });

            modelBuilder.Entity("Oxit.Domain.Models.Fis", b =>
                {
                    b.HasOne("Oxit.Domain.Models.HesapPlani", "HesapPlani")
                        .WithMany("Fis")
                        .HasForeignKey("HesapPlaniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HesapPlani");
                });

            modelBuilder.Entity("Oxit.Domain.Models.HesapPlani", b =>
                {
                    b.Navigation("Fis");
                });
#pragma warning restore 612, 618
        }
    }
}
