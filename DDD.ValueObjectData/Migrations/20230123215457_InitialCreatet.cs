using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDD.ValueObjectData.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullNameFirstName = table.Column<string>(name: "fullName_FirstName", type: "nvarchar(max)", nullable: false),
                    fullNameLastName = table.Column<string>(name: "fullName_LastName", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
