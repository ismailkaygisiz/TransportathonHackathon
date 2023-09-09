﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransportathonHackathon.Persistence.Contexts;

#nullable disable

namespace TransportathonHackathon.Persistence.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20230909085430_edited")]
    partial class edited
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Carrier", b =>
                {
                    b.Property<Guid>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsOnTransitNow")
                        .HasColumnType("bit")
                        .HasColumnName("IsOnTransitNow");

                    b.HasKey("AppUserId");

                    b.ToTable("Carriers", (string)null);
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Company", b =>
                {
                    b.Property<Guid>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CompanyName");

                    b.Property<int>("CompletedJobsCount")
                        .HasColumnType("int");

                    b.Property<int>("DriverCount")
                        .HasColumnType("int");

                    b.HasKey("AppUserId");

                    b.ToTable("Companies", (string)null);
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.HasKey("AppUserId");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Driver", b =>
                {
                    b.Property<Guid>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsOnTransitNow")
                        .HasColumnType("bit")
                        .HasColumnName("IsOnTransitNow");

                    b.HasKey("AppUserId");

                    b.ToTable("Drivers", (string)null);
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.DriverLicense", b =>
                {
                    b.Property<Guid>("DriverId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("DriverId");

                    b.Property<string>("Classes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Classes");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit")
                        .HasColumnName("IsNew");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<DateTime>("LicenseGetDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("LicenseGetDate");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DriverId");

                    b.ToTable("DriverLicenses", (string)null);
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Identity.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Identity.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Identity.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Identity.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Identity.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Identity.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Identity.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Code");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GloballyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("GloballyName");

                    b.Property<string>("LocallyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LocallyName");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Languages", (string)null);
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Translate", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Key");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LanguageId");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Value");

                    b.HasKey("Key");

                    b.HasIndex("LanguageId");

                    b.ToTable("Translates", (string)null);
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Carrier", b =>
                {
                    b.HasOne("TransportathonHackathon.Domain.Entities.Identity.AppUser", "AppUser")
                        .WithOne("Carrier")
                        .HasForeignKey("TransportathonHackathon.Domain.Entities.Carrier", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Company", b =>
                {
                    b.HasOne("TransportathonHackathon.Domain.Entities.Identity.AppUser", "AppUser")
                        .WithOne("Company")
                        .HasForeignKey("TransportathonHackathon.Domain.Entities.Company", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Customer", b =>
                {
                    b.HasOne("TransportathonHackathon.Domain.Entities.Identity.AppUser", "AppUser")
                        .WithOne("Customer")
                        .HasForeignKey("TransportathonHackathon.Domain.Entities.Customer", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Driver", b =>
                {
                    b.HasOne("TransportathonHackathon.Domain.Entities.Identity.AppUser", "AppUser")
                        .WithOne("Driver")
                        .HasForeignKey("TransportathonHackathon.Domain.Entities.Driver", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.DriverLicense", b =>
                {
                    b.HasOne("TransportathonHackathon.Domain.Entities.Driver", "Driver")
                        .WithOne("DriverLicense")
                        .HasForeignKey("TransportathonHackathon.Domain.Entities.DriverLicense", "DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Identity.AppRoleClaim", b =>
                {
                    b.HasOne("TransportathonHackathon.Domain.Entities.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Identity.AppUserClaim", b =>
                {
                    b.HasOne("TransportathonHackathon.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Identity.AppUserLogin", b =>
                {
                    b.HasOne("TransportathonHackathon.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Identity.AppUserRole", b =>
                {
                    b.HasOne("TransportathonHackathon.Domain.Entities.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportathonHackathon.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Identity.AppUserToken", b =>
                {
                    b.HasOne("TransportathonHackathon.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Translate", b =>
                {
                    b.HasOne("TransportathonHackathon.Domain.Entities.Language", "Language")
                        .WithMany("Translates")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Driver", b =>
                {
                    b.Navigation("DriverLicense");
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Identity.AppUser", b =>
                {
                    b.Navigation("Carrier");

                    b.Navigation("Company");

                    b.Navigation("Customer");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("TransportathonHackathon.Domain.Entities.Language", b =>
                {
                    b.Navigation("Translates");
                });
#pragma warning restore 612, 618
        }
    }
}
