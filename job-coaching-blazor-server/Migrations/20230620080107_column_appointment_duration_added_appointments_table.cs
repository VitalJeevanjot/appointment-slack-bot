using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace job_coaching_blazor_server.Migrations
{
    /// <inheritdoc />
    public partial class column_appointment_duration_added_appointments_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentDurationMinutes",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDurationMinutes",
                table: "Appointments");
        }
    }
}
