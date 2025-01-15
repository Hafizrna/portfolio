using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Migrations
{
    public partial class ab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dbdata",
                table: "Dbdata");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Dbdata",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Dbdata",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dbdata",
                table: "Dbdata",
                column: "phone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dbdata",
                table: "Dbdata");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Dbdata",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Dbdata",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dbdata",
                table: "Dbdata",
                column: "name");
        }
    }
}
