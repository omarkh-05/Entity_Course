using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Course.Migrations
{
    /// <inheritdoc />
    public partial class Invoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "stdAtts");

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerDescription = table.Column<string>(type: "nvarchar(max)", nullable: false, computedColumnSql: "[CustomerName] + ' ' + [CustomerTitle]"),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    qty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 1m),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[price] * [qty]"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceID);
                });

            migrationBuilder.CreateTable(
                name: "StudentsAttendance",
                schema: "stdAtts",
                columns: table => new
                {
                    AttendanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheName = table.Column<string>(type: "varchar(20)", nullable: false, comment: "شرح عن التيبل"),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsAttendance", x => x.AttendanceID);
                    table.ForeignKey(
                        name: "FK_StudentsAttendance_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsAttendance_StudentID",
                schema: "stdAtts",
                table: "StudentsAttendance",
                column: "StudentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "StudentsAttendance",
                schema: "stdAtts");
        }
    }
}
