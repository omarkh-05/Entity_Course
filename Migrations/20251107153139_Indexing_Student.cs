using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Course.Migrations
{
    /// <inheritdoc />
    public partial class Indexing_Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Students_MobileNumber",
                table: "Students",
                column: "MobileNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_Name_BirthDate",
                table: "Students",
                columns: new[] { "Name", "BirthDate" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_MobileNumber",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Name_BirthDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
