﻿// <auto-generated />
using System;
using JN_Mission6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JN_Mission6.Migrations
{
    [DbContext(typeof(MovieApplicationContext))]
    [Migration("20240221184235_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("JN_Mission6.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("JN_Mission6.Models.MovieSubmit", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CopiedToPlex")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("LentTo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("JN_Mission6.Models.MovieSubmit", b =>
                {
                    b.HasOne("JN_Mission6.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
