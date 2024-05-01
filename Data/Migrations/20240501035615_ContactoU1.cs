using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NebulaCars.Data.Migrations
{
    /// <inheritdoc />
    public partial class ContactoU1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "t_contacto");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "t_contacto",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "t_contacto");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "t_contacto",
                type: "text",
                nullable: true);
        }
    }
}
