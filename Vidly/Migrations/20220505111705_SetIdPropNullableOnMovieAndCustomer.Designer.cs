﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vidly.Models;

namespace Vidly.Migrations
{
    [DbContext(typeof(VidlyDbContext))]
    [Migration("20220505111705_SetIdPropNullableOnMovieAndCustomer")]
    partial class SetIdPropNullableOnMovieAndCustomer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vidly.Models.Customer", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSubscribedForNewsletter")
                        .HasColumnType("bit");

                    b.Property<byte>("MembershipTypeId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("MembershipTypeId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = new DateTime(1976, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsSubscribedForNewsletter = true,
                            MembershipTypeId = (byte)1,
                            Name = "Tim"
                        },
                        new
                        {
                            Id = 2,
                            Birthdate = new DateTime(1983, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsSubscribedForNewsletter = true,
                            MembershipTypeId = (byte)2,
                            Name = "Tom"
                        },
                        new
                        {
                            Id = 3,
                            IsSubscribedForNewsletter = false,
                            MembershipTypeId = (byte)3,
                            Name = "Tod"
                        },
                        new
                        {
                            Id = 4,
                            Birthdate = new DateTime(1989, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsSubscribedForNewsletter = true,
                            MembershipTypeId = (byte)4,
                            Name = "Jane"
                        });
                });

            modelBuilder.Entity("Vidly.Models.Genre", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = (byte)2,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = (byte)3,
                            Name = "Family"
                        },
                        new
                        {
                            Id = (byte)4,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = (byte)5,
                            Name = "Comedy"
                        });
                });

            modelBuilder.Entity("Vidly.Models.MembershipType", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<byte>("DiscountRate")
                        .HasColumnType("tinyint");

                    b.Property<byte>("DurationInMonths")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("SignUpFee")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("MembershipTypes");

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            DiscountRate = (byte)0,
                            DurationInMonths = (byte)0,
                            Name = "Pay as You Go",
                            SignUpFee = (short)0
                        },
                        new
                        {
                            Id = (byte)2,
                            DiscountRate = (byte)10,
                            DurationInMonths = (byte)1,
                            Name = "Monthly",
                            SignUpFee = (short)30
                        },
                        new
                        {
                            Id = (byte)3,
                            DiscountRate = (byte)15,
                            DurationInMonths = (byte)3,
                            Name = "Quarterly",
                            SignUpFee = (short)90
                        },
                        new
                        {
                            Id = (byte)4,
                            DiscountRate = (byte)20,
                            DurationInMonths = (byte)12,
                            Name = "Annual",
                            SignUpFee = (short)300
                        });
                });

            modelBuilder.Entity("Vidly.Models.Movie", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<byte>("GenreId")
                        .HasColumnType("tinyint");

                    b.Property<byte>("NumberInStock")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = (byte)1,
                            NumberInStock = (byte)15,
                            ReleaseDate = new DateTime(1984, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Terminator"
                        },
                        new
                        {
                            Id = 2,
                            DateAdded = new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = (byte)1,
                            NumberInStock = (byte)15,
                            ReleaseDate = new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Terminator2"
                        },
                        new
                        {
                            Id = 3,
                            DateAdded = new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = (byte)1,
                            NumberInStock = (byte)15,
                            ReleaseDate = new DateTime(1982, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Rambo"
                        },
                        new
                        {
                            Id = 4,
                            DateAdded = new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = (byte)1,
                            NumberInStock = (byte)15,
                            ReleaseDate = new DateTime(1985, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Rambo 2"
                        },
                        new
                        {
                            Id = 5,
                            DateAdded = new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = (byte)1,
                            NumberInStock = (byte)15,
                            ReleaseDate = new DateTime(1988, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Rambo 3"
                        },
                        new
                        {
                            Id = 6,
                            DateAdded = new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = (byte)5,
                            NumberInStock = (byte)15,
                            ReleaseDate = new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Oscar"
                        });
                });

            modelBuilder.Entity("Vidly.Models.Customer", b =>
                {
                    b.HasOne("Vidly.Models.MembershipType", "MembershipType")
                        .WithMany()
                        .HasForeignKey("MembershipTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MembershipType");
                });

            modelBuilder.Entity("Vidly.Models.Movie", b =>
                {
                    b.HasOne("Vidly.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
