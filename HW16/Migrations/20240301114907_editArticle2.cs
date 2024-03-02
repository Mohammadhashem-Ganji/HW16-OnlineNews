using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW16.Migrations
{
    /// <inheritdoc />
    public partial class editArticle2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Articles_Tbl_Users_UserIdId",
                table: "Tbl_Articles");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "Tbl_Articles",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_Articles_UserIdId",
                table: "Tbl_Articles",
                newName: "IX_Tbl_Articles_UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Articles_Tbl_Users_UserID",
                table: "Tbl_Articles",
                column: "UserID",
                principalTable: "Tbl_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Articles_Tbl_Users_UserID",
                table: "Tbl_Articles");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Tbl_Articles",
                newName: "UserIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_Articles_UserID",
                table: "Tbl_Articles",
                newName: "IX_Tbl_Articles_UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Articles_Tbl_Users_UserIdId",
                table: "Tbl_Articles",
                column: "UserIdId",
                principalTable: "Tbl_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
