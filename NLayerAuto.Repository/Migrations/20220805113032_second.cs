using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayerAuto.Repository.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFeatures_Cars_CarsId",
                table: "ProductFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductFeatures",
                table: "ProductFeatures");

            migrationBuilder.RenameTable(
                name: "ProductFeatures",
                newName: "CarsFeatures");

            migrationBuilder.RenameIndex(
                name: "IX_ProductFeatures_CarsId",
                table: "CarsFeatures",
                newName: "IX_CarsFeatures_CarsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarsFeatures",
                table: "CarsFeatures",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 5, 14, 30, 32, 643, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 5, 14, 30, 32, 643, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 5, 14, 30, 32, 643, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 5, 14, 30, 32, 643, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 5, 14, 30, 32, 643, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 5, 14, 30, 32, 643, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 5, 14, 30, 32, 643, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 5, 14, 30, 32, 643, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 5, 14, 30, 32, 643, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.AddForeignKey(
                name: "FK_CarsFeatures_Cars_CarsId",
                table: "CarsFeatures",
                column: "CarsId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarsFeatures_Cars_CarsId",
                table: "CarsFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarsFeatures",
                table: "CarsFeatures");

            migrationBuilder.RenameTable(
                name: "CarsFeatures",
                newName: "ProductFeatures");

            migrationBuilder.RenameIndex(
                name: "IX_CarsFeatures_CarsId",
                table: "ProductFeatures",
                newName: "IX_ProductFeatures_CarsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductFeatures",
                table: "ProductFeatures",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 4, 3, 16, 51, 937, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFeatures_Cars_CarsId",
                table: "ProductFeatures",
                column: "CarsId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
