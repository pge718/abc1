using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sulekha.Migrations
{
    public partial class Sulekha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    TypeName = table.Column<string>(nullable: false),
                    TypeCode = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.TypeName);
                });

            migrationBuilder.CreateTable(
                name: "Signup",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Contact_Number = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    retypePassword = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    AID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Contact_Number = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: false),
                    timeSlot = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DoctorID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    DoctorTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.AID);
                    table.ForeignKey(
                        name: "FK_Appointment_Doctor_DoctorTypeName",
                        column: x => x.DoctorTypeName,
                        principalTable: "Doctor",
                        principalColumn: "TypeName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    Business_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Service_name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Information = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SubService_name = table.Column<string>(nullable: true),
                    TypeName = table.Column<int>(nullable: false),
                    DoctorTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.Business_ID);
                    table.ForeignKey(
                        name: "FK_Business_Doctor_DoctorTypeName",
                        column: x => x.DoctorTypeName,
                        principalTable: "Doctor",
                        principalColumn: "TypeName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_DoctorTypeName",
                table: "Appointment",
                column: "DoctorTypeName");

            migrationBuilder.CreateIndex(
                name: "IX_Business_DoctorTypeName",
                table: "Business",
                column: "DoctorTypeName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.DropTable(
                name: "Signup");

            migrationBuilder.DropTable(
                name: "Doctor");
        }
    }
}
