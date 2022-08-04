using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayerAuto.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Headlights = table.Column<bool>(type: "bit", nullable: false),
                    Wheels = table.Column<int>(type: "int", nullable: false),
                    CarsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Cars_CarsId",
                        column: x => x.CarsId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Car", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boats", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buses", null });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1054), "Mercedes", null },
                    { 2, 1, new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1062), "BMW", null },
                    { 3, 1, new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1063), "AUDI", null },
                    { 4, 2, new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1064), "Abacus", null },
                    { 5, 2, new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1064), "Absolute", null },
                    { 6, 2, new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1065), "Admiral Boats", null },
                    { 7, 3, new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1066), "MAN", null },
                    { 8, 2, new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1066), "DAF", null },
                    { 9, 2, new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1067), "ISUZU", null }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "CarsId", "Color", "Headlights", "Wheels" },
                values: new object[] { 1, 1, "Black", true, 4 });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "CarsId", "Color", "Headlights", "Wheels" },
                values: new object[] { 2, 2, "White", true, 0 });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "CarsId", "Color", "Headlights", "Wheels" },
                values: new object[] { 3, 3, "Blue", true, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_CarsId",
                table: "ProductFeatures",
                column: "CarsId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
