using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Portfolio.API.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartMonth = table.Column<int>(type: "int", nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    EndMonth = table.Column<int>(type: "int", nullable: true),
                    EndYear = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartMonth = table.Column<int>(type: "int", nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    EndMonth = table.Column<int>(type: "int", nullable: false),
                    EndYear = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiveDemo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Github = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Freelance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CvUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Office = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CreatedDate", "Description", "EndMonth", "EndYear", "Name", "StartMonth", "StartYear", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3267), "Example Description", null, null, "Istanbul Education Academy", 9, 2023, null },
                    { 2, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3303), "Example Description", null, null, "Istanbul Education Academy", 9, 2023, null },
                    { 3, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3306), "Example Description", null, null, "Istanbul Education Academy", 9, 2023, null },
                    { 4, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3307), "Example Description", null, null, "Istanbul Education Academy", 9, 2023, null },
                    { 5, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3308), "Example Description", null, null, "Istanbul Education Academy", 9, 2023, null },
                    { 6, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3315), "Example Description", null, null, "Istanbul Education Academy", 9, 2023, null }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "CreatedDate", "Description", "EndMonth", "EndYear", "Name", "StartMonth", "StartYear", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3386), "Example Description", 0, 0, "Istanbul Education Academy", 9, 2023, null },
                    { 2, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3395), "Example Description", 0, 0, "Istanbul Education Academy", 9, 2023, null },
                    { 3, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3397), "Example Description", 0, 0, "Istanbul Education Academy", 9, 2023, null },
                    { 4, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3398), "Example Description", 0, 0, "Istanbul Education Academy", 9, 2023, null },
                    { 5, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3399), "Example Description", 0, 0, "Istanbul Education Academy", 9, 2023, null },
                    { 6, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3402), "Example Description", 0, 0, "Istanbul Education Academy", 9, 2023, null }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedDate", "Description", "Github", "ImageUrl", "LiveDemo", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3462), "Example Description", "https://github.com/turkmvc", "project1.png", "https://turkmvc.github.io", "E-Finance", null },
                    { 2, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3471), "Example Description", "https://github.com/turkmvc", "project1.png", "https://turkmvc.github.io", "E-Finance", null },
                    { 3, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3473), "Example Description", "https://github.com/turkmvc", "project1.png", "https://turkmvc.github.io", "E-Finance", null },
                    { 4, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3474), "Example Description", "https://github.com/turkmvc", "project1.png", "https://turkmvc.github.io", "E-Finance", null },
                    { 5, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3476), "Example Description", "https://github.com/turkmvc", "project1.png", "https://turkmvc.github.io", "E-Finance", null },
                    { 6, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3479), "Example Description", "https://github.com/turkmvc", "project1.png", "https://turkmvc.github.io", "E-Finance", null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedDate", "Description", "Icon", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3529), "Example Description", "fa-laptop-code", "FullStack .Net Developper", null },
                    { 2, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3539), "Example Description", "fa-laptop-code", "FullStack .Net Developper", null },
                    { 3, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3541), "Example Description", "fa-laptop-code", "FullStack .Net Developper", null },
                    { 4, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3543), "Example Description", "fa-laptop-code", "FullStack .Net Developper", null },
                    { 5, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3544), "Example Description", "fa-laptop-code", "FullStack .Net Developper", null },
                    { 6, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3547), "Example Description", "fa-laptop-code", "FullStack .Net Developper", null }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Age", "City", "Country", "CreatedDate", "CvUrl", "DateOfBirth", "Degree", "Description", "Freelance", "ImageUrl", "Linkedin", "Name", "Office", "PhoneNumber", "Profession", "UpdatedDate", "Website" },
                values: new object[] { 1, 37, "Elazığ", "Türkiye", new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3758), "https://www.jobseeker.com/d/3foz0mLM0QP18NuMSkYHDN/view", new DateTime(1987, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CS", "Description", "Available", "profile.png", "https://linkedin.com/in/turkmvc", "Cuma KÖSE", "Elazığ", "+9555 444 33 22", "FullStack .Net Developper Trainer", null, "https://turkmvc.github.io" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedDate", "Name", "Rating", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3593), "C#", 76, null },
                    { 2, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3602), "C#", 76, null },
                    { 3, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3603), "C#", 76, null },
                    { 4, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3605), "C#", 76, null },
                    { 5, new DateTime(2023, 11, 16, 12, 47, 29, 375, DateTimeKind.Local).AddTicks(3606), "C#", 76, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
