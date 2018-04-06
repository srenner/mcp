using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace mcp.web.Data.Migrations
{
    public partial class ProjectDependencyFix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Project_ProjectID1",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_ProjectID1",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectID1",
                table: "Project");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectID1",
                table: "Project",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectID1",
                table: "Project",
                column: "ProjectID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Project_ProjectID1",
                table: "Project",
                column: "ProjectID1",
                principalTable: "Project",
                principalColumn: "ProjectID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
