﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwitterSimplified.Data;

namespace TwitterSimplified.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605144403_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TwitterSimplified.Models.ProfileModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("TwitterSimplified.Models.TweetModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.Property<int?>("UserIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.HasIndex("UserIdId");

                    b.ToTable("Tweets");
                });

            modelBuilder.Entity("TwitterSimplified.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TwitterSimplified.Models.ProfileModel", b =>
                {
                    b.HasOne("TwitterSimplified.Models.UserModel", "User")
                        .WithOne("Profile")
                        .HasForeignKey("TwitterSimplified.Models.ProfileModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TwitterSimplified.Models.TweetModel", b =>
                {
                    b.HasOne("TwitterSimplified.Models.UserModel", "User")
                        .WithMany("Tweets")
                        .HasForeignKey("UserId1");

                    b.HasOne("TwitterSimplified.Models.UserModel", "UserId")
                        .WithMany()
                        .HasForeignKey("UserIdId");
                });
#pragma warning restore 612, 618
        }
    }
}
