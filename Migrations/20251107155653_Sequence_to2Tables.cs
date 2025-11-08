using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Course.Migrations
{
    /// <inheritdoc />
    public partial class Sequence_to2Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "DilevaryOrder",
                startValue: 100L);

            migrationBuilder.AddColumn<int>(
                name: "DilevaryOrder",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValueSql: "next value for DilevaryOrder");

            migrationBuilder.CreateTable(
                name: "Uniform",
                columns: table => new
                {
                    UniformID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DilevaryOrder = table.Column<int>(type: "int", nullable: false, defaultValueSql: "next value for DilevaryOrder")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uniform", x => x.UniformID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uniform");

            migrationBuilder.DropColumn(
                name: "DilevaryOrder",
                table: "Books");

            migrationBuilder.DropSequence(
                name: "DilevaryOrder");
        }
    }
}
