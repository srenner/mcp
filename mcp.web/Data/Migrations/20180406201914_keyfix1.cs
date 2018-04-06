using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace mcp.web.Data.Migrations
{
    public partial class keyfix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectStatusHistory_ProjectStatus_ProjectStatusID",
                table: "ProjectStatusHistory");

            migrationBuilder.AddColumn<int>(
                name: "ProjectStatusID",
                table: "Project",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectStatusID",
                table: "Project",
                column: "ProjectStatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_ProjectStatus_ProjectStatusID",
                table: "Project",
                column: "ProjectStatusID",
                principalTable: "ProjectStatus",
                principalColumn: "ProjectStatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectStatusHistory_ProjectStatus_ProjectStatusID",
                table: "ProjectStatusHistory",
                column: "ProjectStatusID",
                principalTable: "ProjectStatus",
                principalColumn: "ProjectStatusID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_ProjectStatus_ProjectStatusID",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectStatusHistory_ProjectStatus_ProjectStatusID",
                table: "ProjectStatusHistory");

            migrationBuilder.DropIndex(
                name: "IX_Project_ProjectStatusID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectStatusID",
                table: "Project");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectStatusHistory_ProjectStatus_ProjectStatusID",
                table: "ProjectStatusHistory",
                column: "ProjectStatusID",
                principalTable: "ProjectStatus",
                principalColumn: "ProjectStatusID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
