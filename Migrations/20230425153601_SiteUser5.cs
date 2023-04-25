using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rp_ef_maria.Migrations
{
    /// <inheritdoc />
    public partial class SiteUser5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SiteUser",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "SiteUser",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "SiteUser");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "SiteUser");
        }
    }
}
