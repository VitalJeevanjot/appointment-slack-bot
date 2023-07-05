using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace job_coaching_blazor_server.Migrations
{
    /// <inheritdoc />
    public partial class renamed_userpost_user_post_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPosts",
                table: "UserPosts");

            migrationBuilder.RenameTable(
                name: "UserPosts",
                newName: "UserPost");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPost",
                table: "UserPost",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPost",
                table: "UserPost");

            migrationBuilder.RenameTable(
                name: "UserPost",
                newName: "UserPosts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPosts",
                table: "UserPosts",
                column: "Id");
        }
    }
}
