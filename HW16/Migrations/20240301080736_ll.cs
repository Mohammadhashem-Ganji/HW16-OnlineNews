using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW16.Migrations
{
    /// <inheritdoc />
    public partial class ll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Workeflows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminIdId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Workeflows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Workeflows_Tbl_Users_AdminIdId",
                        column: x => x.AdminIdId,
                        principalTable: "Tbl_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserIdId = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    image = table.Column<byte>(type: "tinyint", nullable: false),
                    WorkflowId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_Categories",
                        column: x => x.CategoryId,
                        principalTable: "Tbl_Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Article_Workflows",
                        column: x => x.WorkflowId,
                        principalTable: "Tbl_Workeflows",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tbl_Articles_Tbl_Users_UserIdId",
                        column: x => x.UserIdId,
                        principalTable: "Tbl_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Articles_CategoryId",
                table: "Tbl_Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Articles_UserIdId",
                table: "Tbl_Articles",
                column: "UserIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Articles_WorkflowId",
                table: "Tbl_Articles",
                column: "WorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Workeflows_AdminIdId",
                table: "Tbl_Workeflows",
                column: "AdminIdId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Articles");

            migrationBuilder.DropTable(
                name: "Tbl_Categories");

            migrationBuilder.DropTable(
                name: "Tbl_Workeflows");

            migrationBuilder.DropTable(
                name: "Tbl_Users");
        }
    }
}
