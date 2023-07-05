using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace job_coaching_blazor_server.Migrations
{
    /// <inheritdoc />
    public partial class added_users_posts_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearsOfExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeOfCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequiredHelp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPosts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserPosts");
        }
    }
}
