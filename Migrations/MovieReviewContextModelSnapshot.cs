﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TermProject.Models;

#nullable disable

namespace TermProject.Migrations
{
    [DbContext(typeof(MovieReviewContext))]
    partial class MovieReviewContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TermProject.Models.MovieReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ReviewerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("MovieReviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieTitle = "Inception",
                            Rating = 9,
                            ReviewText = "A brilliant, mind-bending thriller!",
                            ReviewerName = "Nick"
                        },
                        new
                        {
                            Id = 2,
                            MovieTitle = "The Matrix",
                            Rating = 10,
                            ReviewText = "An absolute sci-fi classic!",
                            ReviewerName = "Jon"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
