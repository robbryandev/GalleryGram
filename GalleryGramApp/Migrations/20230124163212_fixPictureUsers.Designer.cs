﻿// <auto-generated />
using System;
using GalleryGram.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GalleryGram.Migrations
{
    [DbContext(typeof(GalleryGramContext))]
    [Migration("20230124163212_fixPictureUsers")]
    partial class fixPictureUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = "8f7949b4-c254-4616-ac70-f5560eeeedf2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e801e29c-a3ce-468c-9856-c4b8b77da8eb",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "DAVID@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPZnfxUi/uzXTiwEq/Jx/JkOoBfvYE4hVpcMhTC7pOn3iIZ3S1jy0sRUHfge3/wX6g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2ebae7d4-c1d1-40ea-9e68-ed92c760c8f3",
                            TwoFactorEnabled = false,
                            UserName = "david@gmail.com"
                        },
                        new
                        {
                            Id = "810e1de1-a854-4f5e-bb32-cf597c60c163",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4ef41810-74c7-4742-bc19-0c4ee1de5823",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ROBERT@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEP01g2udxPhw3kR56q300y2me9EqIZvnMHePMWMZspXCbKdX0xbHJ8LXmdWICtx1yA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a13ece42-b79f-4597-a155-10754a91c1bb",
                            TwoFactorEnabled = false,
                            UserName = "robert@gmail.com"
                        },
                        new
                        {
                            Id = "76eda766-b4fa-4389-a8e6-c4fe85be42b1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e4442c41-4e72-4724-9f3e-80d708527095",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "LUCAS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOfvWO+NsHsu9CZMRH1JaPEEi/b5hhmvwhAcfWe9sHWMMzQhwxSeDi6lLJC207ISrA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7dbdcbd4-771c-4cf3-9ea3-ee173dd3aedf",
                            TwoFactorEnabled = false,
                            UserName = "lucas@gmail.com"
                        });
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
                            fileName = "https://via.placeholder.com/600/92c952",
                            user_id = "8f7949b4-c254-4616-ac70-f5560eeeedf2"
                        },
                        new
                        {
                            picture_id = 2,
                            fileName = "https://via.placeholder.com/600/771796",
                            user_id = "8f7949b4-c254-4616-ac70-f5560eeeedf2"
                        },
                        new
                        {
                            picture_id = 3,
                            fileName = "https://via.placeholder.com/600/24f355",
                            user_id = "8f7949b4-c254-4616-ac70-f5560eeeedf2"
                        },
                        new
                        {
                            picture_id = 4,
                            fileName = "https://via.placeholder.com/600/d32776",
                            user_id = "810e1de1-a854-4f5e-bb32-cf597c60c163"
                        },
                        new
                        {
                            picture_id = 5,
                            fileName = "https://via.placeholder.com/600/f66b97",
                            user_id = "810e1de1-a854-4f5e-bb32-cf597c60c163"
                        },
                        new
                        {
                            picture_id = 6,
                            fileName = "https://via.placeholder.com/600/56a8c2",
                            user_id = "810e1de1-a854-4f5e-bb32-cf597c60c163"
                        },
                        new
                        {
                            picture_id = 7,
                            fileName = "https://via.placeholder.com/600/b0f7cc",
                            user_id = "76eda766-b4fa-4389-a8e6-c4fe85be42b1"
                        },
                        new
                        {
                            picture_id = 8,
                            fileName = "https://via.placeholder.com/600/54176f",
                            user_id = "76eda766-b4fa-4389-a8e6-c4fe85be42b1"
                        },
                        new
                        {
                            picture_id = 9,
                            fileName = "https://via.placeholder.com/600/51aa97",
                            user_id = "76eda766-b4fa-4389-a8e6-c4fe85be42b1"
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