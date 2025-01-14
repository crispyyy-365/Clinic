using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Migrations
{
    /// <inheritdoc />
    public partial class CreateEmployeePhotoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeePhotoId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EmployeePhoto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePhoto", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeePhotoId",
                table: "Employees",
                column: "EmployeePhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeePhoto_EmployeePhotoId",
                table: "Employees",
                column: "EmployeePhotoId",
                principalTable: "EmployeePhoto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeePhoto_EmployeePhotoId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "EmployeePhoto");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeePhotoId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeePhotoId",
                table: "Employees");
        }
    }
}
