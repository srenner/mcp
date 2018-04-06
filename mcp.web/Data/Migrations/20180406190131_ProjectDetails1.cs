using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace mcp.web.Data.Migrations
{
    public partial class ProjectDetails1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Vehicle",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Vehicle",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Project",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Project",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Project",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Project",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Project",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectID1",
                table: "Project",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TargetEndDate",
                table: "Project",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TargetStartDate",
                table: "Project",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProjectStatus",
                columns: table => new
                {
                    ProjectStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    ProjectID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStatus", x => x.ProjectStatusID);
                    table.ForeignKey(
                        name: "FK_ProjectStatus_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStep",
                columns: table => new
                {
                    ProjectStepID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    Name = table.Column<string>(maxLength: 500, nullable: true),
                    ProjectID = table.Column<int>(nullable: false),
                    ProjectStepID1 = table.Column<int>(nullable: true),
                    StepNumber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStep", x => x.ProjectStepID);
                    table.ForeignKey(
                        name: "FK_ProjectStep_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectStep_ProjectStep_ProjectStepID1",
                        column: x => x.ProjectStepID1,
                        principalTable: "ProjectStep",
                        principalColumn: "ProjectStepID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStatusHistory",
                columns: table => new
                {
                    ProjectStatusHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectID = table.Column<int>(nullable: false),
                    ProjectStatusID = table.Column<int>(nullable: false),
                    StatusDate = table.Column<DateTime>(nullable: false),
                    StatusNote = table.Column<string>(maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStatusHistory", x => x.ProjectStatusHistoryID);
                    table.ForeignKey(
                        name: "FK_ProjectStatusHistory_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectStatusHistory_ProjectStatus_ProjectStatusID",
                        column: x => x.ProjectStatusID,
                        principalTable: "ProjectStatus",
                        principalColumn: "ProjectStatusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectItem",
                columns: table => new
                {
                    ProjectItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    Name = table.Column<string>(maxLength: 500, nullable: true),
                    ProductHyperlinkID = table.Column<int>(nullable: true),
                    ProjectID = table.Column<int>(nullable: true),
                    ProjectStepID = table.Column<int>(nullable: true),
                    SortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectItem", x => x.ProjectItemID);
                    table.ForeignKey(
                        name: "FK_ProjectItem_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectItem_ProjectStep_ProjectStepID",
                        column: x => x.ProjectStepID,
                        principalTable: "ProjectStep",
                        principalColumn: "ProjectStepID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductHyperlink",
                columns: table => new
                {
                    ProductHyperlinkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ProjectItemID = table.Column<int>(nullable: true),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductHyperlink", x => x.ProductHyperlinkID);
                    table.ForeignKey(
                        name: "FK_ProductHyperlink_ProjectItem_ProjectItemID",
                        column: x => x.ProjectItemID,
                        principalTable: "ProjectItem",
                        principalColumn: "ProjectItemID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectID1",
                table: "Project",
                column: "ProjectID1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductHyperlink_ProjectItemID",
                table: "ProductHyperlink",
                column: "ProjectItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectItem_ProductHyperlinkID",
                table: "ProjectItem",
                column: "ProductHyperlinkID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectItem_ProjectID",
                table: "ProjectItem",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectItem_ProjectStepID",
                table: "ProjectItem",
                column: "ProjectStepID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStatus_ProjectID",
                table: "ProjectStatus",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStatusHistory_ProjectID",
                table: "ProjectStatusHistory",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStatusHistory_ProjectStatusID",
                table: "ProjectStatusHistory",
                column: "ProjectStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStep_ProjectID",
                table: "ProjectStep",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStep_ProjectStepID1",
                table: "ProjectStep",
                column: "ProjectStepID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Project_ProjectID1",
                table: "Project",
                column: "ProjectID1",
                principalTable: "Project",
                principalColumn: "ProjectID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectItem_ProductHyperlink_ProductHyperlinkID",
                table: "ProjectItem",
                column: "ProductHyperlinkID",
                principalTable: "ProductHyperlink",
                principalColumn: "ProductHyperlinkID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Project_ProjectID1",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductHyperlink_ProjectItem_ProjectItemID",
                table: "ProductHyperlink");

            migrationBuilder.DropTable(
                name: "ProjectStatusHistory");

            migrationBuilder.DropTable(
                name: "ProjectStatus");

            migrationBuilder.DropTable(
                name: "ProjectItem");

            migrationBuilder.DropTable(
                name: "ProductHyperlink");

            migrationBuilder.DropTable(
                name: "ProjectStep");

            migrationBuilder.DropIndex(
                name: "IX_Project_ProjectID1",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectID1",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "TargetEndDate",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "TargetStartDate",
                table: "Project");
        }
    }
}
