using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tar_4.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "SeriePeliculaLibros",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SignoZodiacal",
                table: "Personajes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "SeriePeliculaLibros");

            migrationBuilder.DropColumn(
                name: "SignoZodiacal",
                table: "Personajes");
        }
    }
}
