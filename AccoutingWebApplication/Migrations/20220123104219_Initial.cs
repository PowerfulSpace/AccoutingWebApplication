using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccoutingWebApplication.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departaments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DepartamentName = table.Column<string>(nullable: true),
                    DateAddedDepartament = table.Column<DateTime>(nullable: false),
                    DateChangeInformationDepartament = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    DateEmployeeAdded = table.Column<DateTime>(nullable: false),
                    DateChangeEmployee = table.Column<DateTime>(nullable: false),
                    EmploymentDate = table.Column<DateTime>(nullable: false),
                    DepartamentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employes_Departaments_DepartamentId",
                        column: x => x.DepartamentId,
                        principalTable: "Departaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employes_DepartamentId",
                table: "Employes",
                column: "DepartamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employes");

            migrationBuilder.DropTable(
                name: "Departaments");
        }
    }
}
