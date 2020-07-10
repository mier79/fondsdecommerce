using Microsoft.EntityFrameworkCore.Migrations;

namespace fondsdecommerce.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achalandage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfClient = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    typ = table.Column<int>(nullable: true),
                    AchalandageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achalandage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Achalandage_Achalandage_AchalandageId",
                        column: x => x.AchalandageId,
                        principalTable: "Achalandage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Commerces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    RegistreCommerce = table.Column<string>(nullable: true),
                    AchalId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commerces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commerces_Achalandage_AchalId",
                        column: x => x.AchalId,
                        principalTable: "Achalandage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Commerces",
                columns: new[] { "Id", "AchalId", "Name", "RegistreCommerce" },
                values: new object[] { 1, null, "Walmart", "91AD" });

            migrationBuilder.InsertData(
                table: "Commerces",
                columns: new[] { "Id", "AchalId", "Name", "RegistreCommerce" },
                values: new object[] { 2, null, "CBI", "96SR" });

            migrationBuilder.InsertData(
                table: "Commerces",
                columns: new[] { "Id", "AchalId", "Name", "RegistreCommerce" },
                values: new object[] { 3, null, "Puma", "105UC" });

            migrationBuilder.CreateIndex(
                name: "IX_Achalandage_AchalandageId",
                table: "Achalandage",
                column: "AchalandageId");

            migrationBuilder.CreateIndex(
                name: "IX_Commerces_AchalId",
                table: "Commerces",
                column: "AchalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commerces");

            migrationBuilder.DropTable(
                name: "Achalandage");
        }
    }
}
