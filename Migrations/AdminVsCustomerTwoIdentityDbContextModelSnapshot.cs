﻿// <auto-generated />
using System;
using AdminVsCustomerTwo.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdminVsCustomerTwo.Migrations
{
    [DbContext(typeof(AdminVsCustomerTwoIdentityDbContext))]
    partial class AdminVsCustomerTwoIdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
            modelBuilder.Entity("Iuli.Cse19.CarRental.WebApp.Domain.Car", b =>
            {
                b.Property<Guid>("CarId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<string>("CarModel")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.Property<string>("Color")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.Property<string>("LicensePlate")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.Property<Guid>("OwnerId")
                    .HasColumnType("char(36)");

                b.Property<int>("RentPrice")
                    .HasColumnType("int");

                b.HasKey("CarId");

                b.HasIndex("OwnerId");

                b.ToTable("Car");
            });

            modelBuilder.Entity("Iuli.Cse19.CarRental.WebApp.Domain.Customer", b =>
            {
                b.Property<Guid>("CustomerId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<string>("CustomerAddress")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.Property<string>("CustomerCity")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.Property<string>("CustomerEmail")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.Property<string>("CustomerName")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.Property<string>("CustomerPhone")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.HasKey("CustomerId");

                b.ToTable("Customer");
            });

            modelBuilder.Entity("Iuli.Cse19.CarRental.WebApp.Domain.Owner", b =>
            {
                b.Property<Guid>("OwnerId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<string>("OwnerAddress")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.Property<string>("OwnerCity")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.Property<string>("OwnerEmail")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.Property<string>("OwnerName")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.Property<string>("OwnerPhone")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.HasKey("OwnerId");

                b.ToTable("Owner");
            });

            modelBuilder.Entity("AdminVsCustomerTwo.Domain.RentedCarInformation", b =>
            {
                b.Property<Guid>("RentId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<Guid>("CarId")
                    .HasColumnType("char(36)");

                b.Property<Guid>("CustomerId")
                    .HasColumnType("char(36)");

                b.Property<DateTime>("RentEnd")
                    .HasColumnType("datetime(6)");

                b.Property<DateTime>("RentStart")
                    .HasColumnType("datetime(6)");

                b.Property<string>("price")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.HasKey("RentId");

                b.HasIndex("CarId");

                b.HasIndex("CustomerId");

                b.ToTable("RentInfo");
            });

            modelBuilder.Entity("AdminVsCustomerTwo.Domain.Car", b =>
            {
                b.HasOne("Iuli.Cse19.CarRental.WebApp.Domain.Owner", "Owner")
                    .WithMany()
                    .HasForeignKey("OwnerId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Owner");
            });

            modelBuilder.Entity("AdminVsCustomerTwo.Domain.RentedCarInformation", b =>
            {
                b.HasOne("Iuli.Cse19.CarRental.WebApp.Domain.Car", "Car")
                    .WithMany()
                    .HasForeignKey("CarId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("AdminVsCustomerTwo.Domain.Customer", "Customer")
                    .WithMany()
                    .HasForeignKey("CustomerId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Car");

                b.Navigation("Customer");
            });
#pragma warning restore 612, 618
        }
    }
}
