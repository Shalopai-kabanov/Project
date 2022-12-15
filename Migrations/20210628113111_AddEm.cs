using Microsoft.EntityFrameworkCore.Migrations;

namespace MB.Migrations
{
    public partial class AddEm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Hotel_id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Role_id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Hotel_id",
                table: "Employees",
                column: "Hotel_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Role_id",
                table: "Employees",
                column: "Role_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Hotels_Hotel_id",
                table: "Employees",
                column: "Hotel_id",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Roles_Role_id",
                table: "Employees",
                column: "Role_id",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Hotels_Hotel_id",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Roles_Role_id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Hotel_id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Role_id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Hotel_id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Role_id",
                table: "Employees");
        }
    }
}
