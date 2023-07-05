using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace job_coaching_blazor_server.Migrations
{
    /// <inheritdoc />
    public partial class added_appointments_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPost",
                table: "UserPost");

            migrationBuilder.RenameTable(
                name: "UserPost",
                newName: "UsersPosts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersPosts",
                table: "UsersPosts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URlId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelpSeekerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelperEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersPosts",
                table: "UsersPosts");

            migrationBuilder.RenameTable(
                name: "UsersPosts",
                newName: "UserPost");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPost",
                table: "UserPost",
                column: "Id");
        }
    }
}
