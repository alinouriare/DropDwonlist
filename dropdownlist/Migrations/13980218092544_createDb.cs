using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dropdownlist.Migrations
{
    public partial class createDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "provinceTbl",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProvinceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provinceTbl", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "cityTbl",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(nullable: true),
                    ProvinceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cityTbl", x => x.ID);
                    table.ForeignKey(
                        name: "FK_cityTbl_provinceTbl_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "provinceTbl",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userinfiTbl",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    CityID = table.Column<int>(nullable: false),
                    ProvinceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userinfiTbl", x => x.ID);
                    table.ForeignKey(
                        name: "FK_userinfiTbl_cityTbl_CityID",
                        column: x => x.CityID,
                        principalTable: "cityTbl",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cityTbl_ProvinceID",
                table: "cityTbl",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_userinfiTbl_CityID",
                table: "userinfiTbl",
                column: "CityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userinfiTbl");

            migrationBuilder.DropTable(
                name: "cityTbl");

            migrationBuilder.DropTable(
                name: "provinceTbl");
        }
    }
}
