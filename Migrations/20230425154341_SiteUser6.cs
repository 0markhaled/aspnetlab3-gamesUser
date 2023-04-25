using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rp_ef_maria.Migrations
{
    /// <inheritdoc />
    public partial class SiteUser6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "SiteUser",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "SiteUser",
                newName: "FirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "SiteUser",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "SiteUser",
                newName: "Password");
        }
    }
}
