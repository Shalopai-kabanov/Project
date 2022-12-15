using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MB.Migrations
{
    public partial class another : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "General_Partners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    General_partner_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_General_Partners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Phone_number = table.Column<int>(type: "int", nullable: false),
                    Number_of_floors = table.Column<int>(type: "int", nullable: false),
                    Amount_of_apartments = table.Column<int>(type: "int", nullable: false),
                    Hotel_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Object_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Object_type_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Object_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Objects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Object_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount_of_objects = table.Column<int>(type: "int", nullable: false),
                    Object_material = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paid_Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_of_paid_service = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paid_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partner_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Partner_type_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partner_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Date_of_reservation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_of_end_reservation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Residents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone_number = table.Column<int>(type: "int", nullable: false),
                    Seria = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_of_role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Type_Of_Apartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_Of_Apartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Room_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Amount_of_room = table.Column<int>(type: "int", nullable: false),
                    Floor_number = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Type_of_apartment_id = table.Column<int>(type: "int", nullable: false),
                    Hotel_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartments_Hotels_Hotel_id",
                        column: x => x.Hotel_id,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apartments_Type_Of_Apartments_Type_of_apartment_id",
                        column: x => x.Type_of_apartment_id,
                        principalTable: "Type_Of_Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_Hotel_id",
                table: "Apartments",
                column: "Hotel_id");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_Type_of_apartment_id",
                table: "Apartments",
                column: "Type_of_apartment_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "General_Partners");

            migrationBuilder.DropTable(
                name: "Object_Types");

            migrationBuilder.DropTable(
                name: "Objects");

            migrationBuilder.DropTable(
                name: "Paid_Services");

            migrationBuilder.DropTable(
                name: "Partner_Types");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Residents");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Type_Of_Apartments");
        }
    }
}
