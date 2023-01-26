﻿// <auto-generated />
using System;
using GalleryGram.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GalleryGramApp.Migrations
{
    [DbContext(typeof(GalleryGramContext))]
    partial class GalleryGramContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GalleryGram.Models.ApplicationUser", b =>
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

                    b.HasData(
                        new
                        {
                            Id = "4947bdd7-f278-4a59-af75-be8bac04c6f5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5881f98c-5d62-4965-816f-196853fd512d",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "DAVID@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENdGs0NuYQ3hL/w4NHD8vpan672hvJM5MrodVncnAx4wzx8LVbr+exYoy3uPyLcybA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "63668cf8-dcd0-4a57-ab44-4cadb6fbb1c3",
                            TwoFactorEnabled = false,
                            UserName = "david@gmail.com"
                        },
                        new
                        {
                            Id = "ec793050-aa29-47ad-af21-bf87286fa27d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3a781fd2-bdcd-490f-951c-c39f7cd0cdfb",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ROBERT@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPQ/Dm3d9/Qb9QECYs1NKb5u2wHokvw/D2uI92h0BL1qLKNiH5QDmgzzvz1h6PAR5w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "06db2b9f-5901-4115-8a30-104e6f0cad64",
                            TwoFactorEnabled = false,
                            UserName = "robert@gmail.com"
                        },
                        new
                        {
                            Id = "775b665d-b75a-40c5-9fd4-1c43e4e81fe4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4564d144-ba8d-463d-b2ee-96e6e81205cf",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "LUCAS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEL2HuVNq4BRN8RQW8ZS1bCG16olIbVTPZn0RWAe1SUaqv8HN/Msibq100hOU1P/PMg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "68fd7897-5504-40d1-9e86-a48efa559ae3",
                            TwoFactorEnabled = false,
                            UserName = "lucas@gmail.com"
                        });
                });

            modelBuilder.Entity("GalleryGram.Models.DbOrder", b =>
                {
                    b.Property<int>("order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("confirmation_id")
                        .HasColumnType("longtext");

                    b.Property<string>("cost")
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.Property<string>("user_id")
                        .HasColumnType("longtext");

                    b.HasKey("order_id");

                    b.ToTable("DbOrders");
                });

            modelBuilder.Entity("GalleryGram.Models.Likes", b =>
                {
                    b.Property<int>("like_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("picture_id")
                        .HasColumnType("int");

                    b.Property<string>("user_id")
                        .HasColumnType("longtext");

                    b.HasKey("like_id");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("GalleryGram.Models.Picture", b =>
                {
                    b.Property<int>("picture_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("fileName")
                        .HasColumnType("longtext");

                    b.Property<string>("user_id")
                        .HasColumnType("longtext");

                    b.HasKey("picture_id");

                    b.ToTable("Pictures");

                    b.HasData(
                        new
                        {
                            picture_id = 1,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vscode/vscode-original.svg",
                            user_id = "4947bdd7-f278-4a59-af75-be8bac04c6f5"
                        },
                        new
                        {
                            picture_id = 2,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/npm/npm-original-wordmark.svg",
                            user_id = "4947bdd7-f278-4a59-af75-be8bac04c6f5"
                        },
                        new
                        {
                            picture_id = 3,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/msdos/msdos-original.svg",
                            user_id = "4947bdd7-f278-4a59-af75-be8bac04c6f5"
                        },
                        new
                        {
                            picture_id = 4,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/markdown/markdown-original.svg",
                            user_id = "ec793050-aa29-47ad-af21-bf87286fa27d"
                        },
                        new
                        {
                            picture_id = 5,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/linkedin/linkedin-original.svg",
                            user_id = "ec793050-aa29-47ad-af21-bf87286fa27d"
                        },
                        new
                        {
                            picture_id = 6,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jquery/jquery-original.svg",
                            user_id = "ec793050-aa29-47ad-af21-bf87286fa27d"
                        },
                        new
                        {
                            picture_id = 7,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jest/jest-plain.svg",
                            user_id = "775b665d-b75a-40c5-9fd4-1c43e4e81fe4"
                        },
                        new
                        {
                            picture_id = 8,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/html5/html5-original.svg",
                            user_id = "775b665d-b75a-40c5-9fd4-1c43e4e81fe4"
                        },
                        new
                        {
                            picture_id = 9,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/github/github-original.svg",
                            user_id = "775b665d-b75a-40c5-9fd4-1c43e4e81fe4"
                        });
                });

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
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

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
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

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
                    b.HasOne("GalleryGram.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GalleryGram.Models.ApplicationUser", null)
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

                    b.HasOne("GalleryGram.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GalleryGram.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
