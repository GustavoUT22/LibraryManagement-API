﻿// <auto-generated />
using System;
using LibraryManagement_API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManagement_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryManagement_API.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BornDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nationality")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BornDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Author 1",
                            Nationality = "Nationality 1"
                        },
                        new
                        {
                            Id = 2,
                            BornDate = new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Author 2",
                            Nationality = "Nationality 2"
                        });
                });

            modelBuilder.Entity("LibraryManagement_API.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("Genre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("int");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Available = true,
                            Genre = "Fiction",
                            PublicationYear = 2000,
                            PublisherId = 1,
                            Quantity = 5,
                            Title = "Book 1"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Available = true,
                            Genre = "Non-Fiction",
                            PublicationYear = 2010,
                            PublisherId = 2,
                            Quantity = 3,
                            Title = "Book 2"
                        });
                });

            modelBuilder.Entity("LibraryManagement_API.Entities.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Loans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            LoanDate = new DateTime(2024, 7, 7, 4, 50, 53, 241, DateTimeKind.Local).AddTicks(465),
                            ReturnDate = new DateTime(2024, 7, 21, 4, 50, 53, 241, DateTimeKind.Local).AddTicks(466),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            LoanDate = new DateTime(2024, 7, 7, 4, 50, 53, 241, DateTimeKind.Local).AddTicks(474),
                            ReturnDate = new DateTime(2024, 7, 21, 4, 50, 53, 241, DateTimeKind.Local).AddTicks(475),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("LibraryManagement_API.Entities.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "publisher1@example.com",
                            Name = "Publisher 1",
                            Phone = "123-456-7890"
                        },
                        new
                        {
                            Id = 2,
                            Email = "publisher2@example.com",
                            Name = "Publisher 2",
                            Phone = "098-765-4321"
                        });
                });

            modelBuilder.Entity("LibraryManagement_API.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "user1@example.com",
                            Name = "User 1",
                            RegistrationDate = new DateTime(2024, 7, 7, 4, 50, 53, 241, DateTimeKind.Local).AddTicks(416)
                        },
                        new
                        {
                            Id = 2,
                            Email = "user2@example.com",
                            Name = "User 2",
                            RegistrationDate = new DateTime(2024, 7, 7, 4, 50, 53, 241, DateTimeKind.Local).AddTicks(433)
                        });
                });

            modelBuilder.Entity("LibraryManagement_API.Entities.Book", b =>
                {
                    b.HasOne("LibraryManagement_API.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagement_API.Entities.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("LibraryManagement_API.Entities.Loan", b =>
                {
                    b.HasOne("LibraryManagement_API.Entities.Book", "Book")
                        .WithMany("Loans")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagement_API.Entities.User", "User")
                        .WithMany("Loans")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LibraryManagement_API.Entities.Book", b =>
                {
                    b.Navigation("Loans");
                });

            modelBuilder.Entity("LibraryManagement_API.Entities.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibraryManagement_API.Entities.User", b =>
                {
                    b.Navigation("Loans");
                });
#pragma warning restore 612, 618
        }
    }
}
