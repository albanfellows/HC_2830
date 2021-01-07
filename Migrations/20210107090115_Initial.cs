using Microsoft.EntityFrameworkCore.Migrations;

namespace EnumFilterTest.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StringField = table.Column<string>(type: "TEXT", nullable: true),
                    DecimalField = table.Column<decimal>(type: "TEXT", nullable: true),
                    BadNullableEnumField = table.Column<int>(type: "INTEGER", nullable: true),
                    GoodNullableEnumField = table.Column<int>(type: "INTEGER", nullable: true),
                    BadEnumField = table.Column<int>(type: "INTEGER", nullable: false),
                    GoodEnumField = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestObjects", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TestObjects",
                columns: new[] { "Id", "BadEnumField", "BadNullableEnumField", "DecimalField", "GoodEnumField", "GoodNullableEnumField", "StringField" },
                values: new object[] { 1, 1, 1, 1.2345m, 1, 1, "First Object" });

            migrationBuilder.InsertData(
                table: "TestObjects",
                columns: new[] { "Id", "BadEnumField", "BadNullableEnumField", "DecimalField", "GoodEnumField", "GoodNullableEnumField", "StringField" },
                values: new object[] { 2, 2, 2, 12.345m, 2, 2, "Second Object" });

            migrationBuilder.InsertData(
                table: "TestObjects",
                columns: new[] { "Id", "BadEnumField", "BadNullableEnumField", "DecimalField", "GoodEnumField", "GoodNullableEnumField", "StringField" },
                values: new object[] { 3, 3, 3, 123.45m, 3, 3, "Third Object" });

            migrationBuilder.InsertData(
                table: "TestObjects",
                columns: new[] { "Id", "BadEnumField", "BadNullableEnumField", "DecimalField", "GoodEnumField", "GoodNullableEnumField", "StringField" },
                values: new object[] { 4, 0, 0, 1234.5m, 0, 0, "Another Object" });

            migrationBuilder.InsertData(
                table: "TestObjects",
                columns: new[] { "Id", "BadEnumField", "BadNullableEnumField", "DecimalField", "GoodEnumField", "GoodNullableEnumField", "StringField" },
                values: new object[] { 5, 3, 3, 12345m, 3, 3, "Final Object" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestObjects");
        }
    }
}
