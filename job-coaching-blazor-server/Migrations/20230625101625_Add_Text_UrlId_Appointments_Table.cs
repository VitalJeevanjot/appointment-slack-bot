using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace job_coaching_blazor_server.Migrations
{
    /// <inheritdoc />
    public partial class Add_Text_UrlId_Appointments_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_UsersPosts_UserPostId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_UserPostId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "UserPostId",
                table: "Appointments");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlId",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "UrlId",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "UserPostId",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserPostId",
                table: "Appointments",
                column: "UserPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_UsersPosts_UserPostId",
                table: "Appointments",
                column: "UserPostId",
                principalTable: "UsersPosts",
                principalColumn: "Id");
        }
    }
}
