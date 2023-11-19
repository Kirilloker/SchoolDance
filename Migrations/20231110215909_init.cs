using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace SchoolDance.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "administrators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fullName = table.Column<string>(type: "longtext", nullable: true),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    isMale = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    login = table.Column<string>(type: "longtext", nullable: true),
                    password = table.Column<string>(type: "longtext", nullable: true),
                    workExperienceMonth = table.Column<int>(type: "int", nullable: false),
                    phoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    position = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administrators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    className = table.Column<string>(type: "longtext", nullable: true),
                    weekdays = table.Column<string>(type: "longtext", nullable: true),
                    danceHallId = table.Column<int>(type: "int", nullable: false),
                    groupId = table.Column<int>(type: "int", nullable: false),
                    coachId = table.Column<int>(type: "int", nullable: false),
                    DanceStyleId = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "coaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    danceStylesId = table.Column<string>(type: "longtext", nullable: true),
                    fullName = table.Column<string>(type: "longtext", nullable: true),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    isMale = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    login = table.Column<string>(type: "longtext", nullable: true),
                    password = table.Column<string>(type: "longtext", nullable: true),
                    workExperienceMonth = table.Column<int>(type: "int", nullable: false),
                    phoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    position = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coaches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "danceHalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    roomNumber = table.Column<int>(type: "int", nullable: false),
                    capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danceHalls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "danceStyles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: true),
                    description = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danceStyles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nameGroup = table.Column<string>(type: "longtext", nullable: true),
                    maxNumberStudent = table.Column<int>(type: "int", nullable: false),
                    studentId = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    paymentTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    endDateTopUp = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fullName = table.Column<string>(type: "longtext", nullable: true),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    isMale = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    login = table.Column<string>(type: "longtext", nullable: true),
                    password = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "supportMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    personId = table.Column<int>(type: "int", nullable: false),
                    typeMessage = table.Column<string>(type: "longtext", nullable: true),
                    message = table.Column<string>(type: "longtext", nullable: true),
                    isSolved = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supportMessages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administrators");

            migrationBuilder.DropTable(
                name: "classes");

            migrationBuilder.DropTable(
                name: "coaches");

            migrationBuilder.DropTable(
                name: "danceHalls");

            migrationBuilder.DropTable(
                name: "danceStyles");

            migrationBuilder.DropTable(
                name: "groups");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "supportMessages");
        }
    }
}
