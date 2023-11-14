using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ProjectTechnologgies_ProjectId",
                table: "ProjectTechnologgies",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPrinciples_ProjectId",
                table: "ProjectPrinciples",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectApproachies_ProjectId",
                table: "ProjectApproachies",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectApproachies_Projects_ProjectId",
                table: "ProjectApproachies",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectPrinciples_Projects_ProjectId",
                table: "ProjectPrinciples",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTechnologgies_Projects_ProjectId",
                table: "ProjectTechnologgies",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectApproachies_Projects_ProjectId",
                table: "ProjectApproachies");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectPrinciples_Projects_ProjectId",
                table: "ProjectPrinciples");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTechnologgies_Projects_ProjectId",
                table: "ProjectTechnologgies");

            migrationBuilder.DropIndex(
                name: "IX_ProjectTechnologgies_ProjectId",
                table: "ProjectTechnologgies");

            migrationBuilder.DropIndex(
                name: "IX_ProjectPrinciples_ProjectId",
                table: "ProjectPrinciples");

            migrationBuilder.DropIndex(
                name: "IX_ProjectApproachies_ProjectId",
                table: "ProjectApproachies");
        }
    }
}
