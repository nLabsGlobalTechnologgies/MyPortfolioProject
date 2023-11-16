﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portfolio.API.Context;

#nullable disable

namespace Portfolio.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231116094729_mg1")]
    partial class mg1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Portfolio.API.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EndMonth")
                        .HasColumnType("int");

                    b.Property<int?>("EndYear")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartMonth")
                        .HasColumnType("int");

                    b.Property<int>("StartYear")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3267),
                            Description = "Example Description",
                            Name = "Istanbul Education Academy",
                            StartMonth = 9,
                            StartYear = 2023
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3303),
                            Description = "Example Description",
                            Name = "Istanbul Education Academy",
                            StartMonth = 9,
                            StartYear = 2023
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3306),
                            Description = "Example Description",
                            Name = "Istanbul Education Academy",
                            StartMonth = 9,
                            StartYear = 2023
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3307),
                            Description = "Example Description",
                            Name = "Istanbul Education Academy",
                            StartMonth = 9,
                            StartYear = 2023
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3308),
                            Description = "Example Description",
                            Name = "Istanbul Education Academy",
                            StartMonth = 9,
                            StartYear = 2023
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3315),
                            Description = "Example Description",
                            Name = "Istanbul Education Academy",
                            StartMonth = 9,
                            StartYear = 2023
                        });
                });

            modelBuilder.Entity("Portfolio.API.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EndMonth")
                        .HasColumnType("int");

                    b.Property<int>("EndYear")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartMonth")
                        .HasColumnType("int");

                    b.Property<int>("StartYear")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3386),
                            Description = "Example Description",
                            EndMonth = 0,
                            EndYear = 0,
                            Name = "Istanbul Education Academy",
                            StartMonth = 9,
                            StartYear = 2023
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3395),
                            Description = "Example Description",
                            EndMonth = 0,
                            EndYear = 0,
                            Name = "Istanbul Education Academy",
                            StartMonth = 9,
                            StartYear = 2023
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3397),
                            Description = "Example Description",
                            EndMonth = 0,
                            EndYear = 0,
                            Name = "Istanbul Education Academy",
                            StartMonth = 9,
                            StartYear = 2023
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3398),
                            Description = "Example Description",
                            EndMonth = 0,
                            EndYear = 0,
                            Name = "Istanbul Education Academy",
                            StartMonth = 9,
                            StartYear = 2023
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3399),
                            Description = "Example Description",
                            EndMonth = 0,
                            EndYear = 0,
                            Name = "Istanbul Education Academy",
                            StartMonth = 9,
                            StartYear = 2023
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3402),
                            Description = "Example Description",
                            EndMonth = 0,
                            EndYear = 0,
                            Name = "Istanbul Education Academy",
                            StartMonth = 9,
                            StartYear = 2023
                        });
                });

            modelBuilder.Entity("Portfolio.API.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Github")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiveDemo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3462),
                            Description = "Example Description",
                            Github = "https://github.com/turkmvc",
                            ImageUrl = "project1.png",
                            LiveDemo = "https://turkmvc.github.io",
                            Name = "E-Finance"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3471),
                            Description = "Example Description",
                            Github = "https://github.com/turkmvc",
                            ImageUrl = "project1.png",
                            LiveDemo = "https://turkmvc.github.io",
                            Name = "E-Finance"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3473),
                            Description = "Example Description",
                            Github = "https://github.com/turkmvc",
                            ImageUrl = "project1.png",
                            LiveDemo = "https://turkmvc.github.io",
                            Name = "E-Finance"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3474),
                            Description = "Example Description",
                            Github = "https://github.com/turkmvc",
                            ImageUrl = "project1.png",
                            LiveDemo = "https://turkmvc.github.io",
                            Name = "E-Finance"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3476),
                            Description = "Example Description",
                            Github = "https://github.com/turkmvc",
                            ImageUrl = "project1.png",
                            LiveDemo = "https://turkmvc.github.io",
                            Name = "E-Finance"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3479),
                            Description = "Example Description",
                            Github = "https://github.com/turkmvc",
                            ImageUrl = "project1.png",
                            LiveDemo = "https://turkmvc.github.io",
                            Name = "E-Finance"
                        });
                });

            modelBuilder.Entity("Portfolio.API.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3529),
                            Description = "Example Description",
                            Icon = "fa-laptop-code",
                            Name = "FullStack .Net Developper"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3539),
                            Description = "Example Description",
                            Icon = "fa-laptop-code",
                            Name = "FullStack .Net Developper"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3541),
                            Description = "Example Description",
                            Icon = "fa-laptop-code",
                            Name = "FullStack .Net Developper"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3543),
                            Description = "Example Description",
                            Icon = "fa-laptop-code",
                            Name = "FullStack .Net Developper"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3544),
                            Description = "Example Description",
                            Icon = "fa-laptop-code",
                            Name = "FullStack .Net Developper"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3547),
                            Description = "Example Description",
                            Icon = "fa-laptop-code",
                            Name = "FullStack .Net Developper"
                        });
                });

            modelBuilder.Entity("Portfolio.API.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CvUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Freelance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linkedin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 37,
                            City = "Elazığ",
                            Country = "Türkiye",
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3758),
                            CvUrl = "https://www.jobseeker.com/d/3foz0mLM0QP18NuMSkYHDN/view",
                            DateOfBirth = new DateTime(1987, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Degree = "CS",
                            Description = "Description",
                            Freelance = "Available",
                            ImageUrl = "profile.png",
                            Linkedin = "https://linkedin.com/in/turkmvc",
                            Name = "Cuma KÖSE",
                            Office = "Elazığ",
                            PhoneNumber = "+9555 444 33 22",
                            Profession = "FullStack .Net Developper Trainer",
                            Website = "https://turkmvc.github.io"
                        });
                });

            modelBuilder.Entity("Portfolio.API.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3593),
                            Name = "C#",
                            Rating = 76
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3602),
                            Name = "C#",
                            Rating = 76
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3603),
                            Name = "C#",
                            Rating = 76
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3605),
                            Name = "C#",
                            Rating = 76
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3606),
                            Name = "C#",
                            Rating = 76
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
