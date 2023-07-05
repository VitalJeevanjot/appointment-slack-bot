using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace job_coaching_blazor_server.Migrations
{
    /// <inheritdoc />
    public partial class update_appointments_remove_fields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HelpSeekerEmail",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "URlId",
                table: "Appointments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HelpSeekerEmail",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URlId",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
