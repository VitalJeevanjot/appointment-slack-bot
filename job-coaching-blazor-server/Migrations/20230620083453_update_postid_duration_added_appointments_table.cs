using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace job_coaching_blazor_server.Migrations
{
    /// <inheritdoc />
    public partial class update_postid_duration_added_appointments_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "PostId",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
