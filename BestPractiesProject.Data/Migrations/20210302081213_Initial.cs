using Microsoft.EntityFrameworkCore.Migrations;

namespace BestPracticesProject.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Katagori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Katagori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Stok = table.Column<int>(type: "int", nullable: false),
                    KatagoriId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InnerBarcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Katagori_KatagoriId",
                        column: x => x.KatagoriId,
                        principalTable: "Katagori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Katagori",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { 1, false, "Kalemler" });

            migrationBuilder.InsertData(
                table: "Katagori",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { 2, false, "Defterler" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "InnerBarcode", "IsDeleted", "KatagoriId", "Name", "Price", "Stok" },
                values: new object[,]
                {
                    { 1, null, false, 1, "Pilot Kalem", 13.50m, 500 },
                    { 2, null, false, 1, "kursun Kalem", 10.50m, 200 },
                    { 3, null, false, 1, "defter", 12.50m, 50 },
                    { 4, null, false, 2, "kucuk defter ", 17.50m, 500 },
                    { 5, null, false, 2, "orta defter", 15.50m, 200 },
                    { 6, null, false, 2, "buyuk defter", 11.50m, 50 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_KatagoriId",
                table: "Product",
                column: "KatagoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Katagori");
        }
    }
}
